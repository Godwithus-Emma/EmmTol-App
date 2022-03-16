namespace MyApp.Models
{
    public class AuthenticationTicket
    {
        public bool Success { get; set; }
        public string Ticket { get; set; }
        public string Error { get; set; }
    }
}
