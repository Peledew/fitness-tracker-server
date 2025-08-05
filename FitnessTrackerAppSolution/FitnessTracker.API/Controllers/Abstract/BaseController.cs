using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers.Abstract
{
    [ApiController]
    public abstract class BaseController<TDto> : ControllerBase 
        where TDto : class
    {
        protected readonly IBaseService<TDto> _service;

        protected BaseController(IBaseService<TDto> service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TDto>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) 
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TDto>>> GetAll()
        {
            var results = await _service.GetAllAsync();
            return Ok(results);
        }

        [HttpPost]
        public virtual async Task<ActionResult<TDto>> Add([FromBody] TDto entity)
        {
            var result = await _service.AddAsync(entity);
            return Created("", result);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, [FromBody] TDto entity)
        {
            if (entity == null)
                return BadRequest("Request body is null.");

            if (!await _service.ExistsAsync(id)) 
                return NotFound();

            await _service.UpdateAsync(id, entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
