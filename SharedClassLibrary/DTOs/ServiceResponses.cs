namespace SharedClassLibrary.DTOs
{
	public class ServiceResponses
	{
		public record class GeneralResponse(bool flag , string Message);
		public record class LoginResponse (bool flag , string Message , string Token);
	}
}
