using FitnessTracker.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.API.Controllers.Abstract
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        protected readonly IBaseService<T> _service;

        protected BaseController(IBaseService<T> service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            var results = await _service.GetAllAsync();
            return Ok(results);
        }

        [HttpPost]
        public virtual async Task<ActionResult<T>> Add([FromBody] T entity)
        {
            var result = await _service.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = GetEntityId(result) }, result);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();
            await _service.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();
        }

        // This must be implemented by derived controller since reflection-based ID extraction is not reliable
        protected abstract int GetEntityId(T entity);
    }
}
