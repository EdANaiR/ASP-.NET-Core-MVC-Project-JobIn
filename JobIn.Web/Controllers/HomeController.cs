using JobIn.Entity.Entities;
using JobIn.Service.Services.Abstractions;
using JobIn.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JobIn.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobPostingService jobPostingService;

        public HomeController(ILogger<HomeController> logger, IJobPostingService jobPostingService)
        {
            _logger = logger;
            this.jobPostingService = jobPostingService;
        }

        public async Task<IActionResult> Index()
        {
            var jobPosting = await jobPostingService.GetAllJobPostingsWithCayegoryNonDeleteAsync();
            return View(jobPosting);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
