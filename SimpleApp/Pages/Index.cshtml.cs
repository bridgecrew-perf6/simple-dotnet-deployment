using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleApp.Services;

namespace SimpleApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string FormatedDate { get; set; }

        public void OnGet()
        {
            FormatedDate = new DateService().FormatDate(DateTime.Now);
        }
    }
}