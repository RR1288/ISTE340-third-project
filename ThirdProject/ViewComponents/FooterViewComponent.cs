using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ThirdProject.Models;
using ThirdProject.Services;

namespace ThirdProject.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly DataRetrieval _dataRetrieval;

        // Inject DataRetrieval service via constructor
        public FooterViewComponent(DataRetrieval dataRetrieval)
        {
            _dataRetrieval = dataRetrieval;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Call the service to fetch the footer data
            var loadedPep = await _dataRetrieval.GetData("footer/");
            var jsonResult = JsonConvert.DeserializeObject<FooterModel>(loadedPep);

            // Return the ViewComponent with the model
            return View(jsonResult);
        }
    }
}
