using QLBH.AdminApplication.Models;
using QLBH.APIIntegration;
using QLBH.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace QLBH.AdminApplication.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageApiClient _languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetAll();
            var navigationVm = new NavigationViewModel()
            {
                CurrentLanguageId = HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.DefaultLanguageId),
                Languages = languages.ResultObj
            };

            return View("Default", navigationVm);
        }
    }
}