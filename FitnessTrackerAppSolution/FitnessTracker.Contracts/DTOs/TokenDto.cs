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
