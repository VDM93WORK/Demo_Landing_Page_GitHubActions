using Demo_Landing_Page_GitHubActions.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Demo_Landing_Page_GitHubActions.Pages;

public class IndexModel : PageModel
{
    private readonly GreetingService _greetingService;

    public string? Greeting { get; set; }

    public IndexModel(GreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    public void OnGet()
    {
    }
    public void OnPostShowGreeting(string name)
    {
        Greeting = _greetingService.GetGreeting(name);
    }
}