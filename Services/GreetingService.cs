namespace Demo_Landing_Page_GitHubActions.Services
{
    public class GreetingService
    {
        public string GetGreeting(string name)
        {
            return $"Ciao {name}! Benvenuto!";
        }
    }
}
