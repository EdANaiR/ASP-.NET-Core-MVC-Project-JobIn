using JobIn.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobIn.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private IJobPostingService jobPostingService;

        public HomeController(IJobPostingService jobPostingService)
        {
            this.jobPostingService = jobPostingService;
        }

        public async Task<IActionResult> Index()
        {
            var jobPostings = await jobPostingService.GetAllJobPostingsWithCayegoryNonDeleteAsync();
            return View(jobPostings);
        }
    }
}
