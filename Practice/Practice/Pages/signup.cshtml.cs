using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practice.Pages
{
    public class signupModel : PageModel
    {
        private readonly ILogger<signupModel> _logger;

        public signupModel(ILogger<signupModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
