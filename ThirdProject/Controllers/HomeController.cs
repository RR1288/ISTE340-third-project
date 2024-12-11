using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdProject.Models;
using Newtonsoft.Json;
using ThirdProject.Services;

namespace ThirdProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("about/");
            var jsonResult = JsonConvert.DeserializeObject<AboutModel>(loadedPep);
            jsonResult.pageTitle = "About";


            return View(jsonResult);
        }

        public async Task<IActionResult> People()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("people/");
            var jsonResult = JsonConvert.DeserializeObject<PeopleModel>(loadedPep);
            jsonResult.pageTitle = "Our People";
            
            
            return View(jsonResult);
        }
        
        public async Task<IActionResult> Minors()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("minors/");
            var jsonResult = JsonConvert.DeserializeObject<MinorsModel>(loadedPep);
            jsonResult.pageTitle = "Minors";
            
            
            return View(jsonResult);
        }

        public async Task<IActionResult> GetCourseDetails(string courseId)
        {
            // Retrieve the course details
            DataRetrieval dataRetrieval = new DataRetrieval();
            var loadedCourse = await dataRetrieval.GetData($"course/courseID={courseId}");
            var courseDetails = JsonConvert.DeserializeObject<CourseModel>(loadedCourse);

            return Json(courseDetails);
        }


        public async Task<IActionResult> Degrees()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("degrees/");
            var jsonResult = JsonConvert.DeserializeObject<DegreesModel>(loadedPep);
            jsonResult.pageTitle = "Degrees";


            return View(jsonResult);
        }

        public async Task<IActionResult> Employment()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("employment/");
            var jsonResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedPep);
            jsonResult.pageTitle = "Employment";


            return View(jsonResult);
        }

        public async Task<IActionResult> Footer()
        {
            var dataRetrieval = new DataRetrieval();
            var loadedData = await dataRetrieval.GetData("footer/");
            var footerModel = JsonConvert.DeserializeObject<FooterModel>(loadedData);
            ViewData["FooterModel"] = footerModel;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
