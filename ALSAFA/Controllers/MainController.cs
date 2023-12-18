using ALSAFA.IServices;
using ALSAFA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ALSAFA.Controllers
{
    //[Authorize]
    public class MainController : Controller
    {
        private readonly IMainService _mainService;

        public MainController(IMainService mainService)
        {
            _mainService = mainService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _mainService.GetAllCategory();
            return View(model);
        }
    }
}
