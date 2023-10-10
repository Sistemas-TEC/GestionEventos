using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LayoutTemplateWebApp.Pages
{
    public class Option4Model : PageModel
    {
        private readonly ILogger<Option4Model> _logger;

        public Option4Model(ILogger<Option4Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}