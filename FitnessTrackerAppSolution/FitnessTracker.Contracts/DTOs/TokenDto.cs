using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Contracts.DTOs
{
    public class TokenDto
    {
        public string AccessToken { get; set; } = string.Empty;

        public TokenDto(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}
