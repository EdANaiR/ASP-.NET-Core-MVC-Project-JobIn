
using JobIn.Entity.DTOs.JobPostings;

using JobIn.Service.Services.Abstractions;
using JobIn.Service.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JobIn.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobPostingController : Controller
    {
        private readonly IJobPostingService jobPostingService;
        private readonly ICategoryService categoryService;



        public JobPostingController(IJobPostingService jobPostingService, ICategoryService categoryService)
        {
            this.jobPostingService = jobPostingService;
            this.categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var jobPostings = await jobPostingService.GetAllJobPostingsWithCayegoryNonDeleteAsync();
            return View(jobPostings);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new JobPostingAddDto { Categories = categories });
        }



        [HttpPost]
        public async Task<IActionResult> Add(JobPostingAddDto jobPostingAddDto)
        {

            await jobPostingService.CreateJobPostingAsync(jobPostingAddDto);
            RedirectToAction("Index", "JobPosting", new { Area = "Admin" });

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new JobPostingAddDto { Categories = categories });

        }
    }

}
