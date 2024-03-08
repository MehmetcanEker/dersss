using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class VeritasımaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["mesaj"] = "bu mesaj viewData ile tasındı!";
            TempData["mesaj5"] = "bu mesaj tempData ile tasındı!";
            TempData.Keep();
            return View();
        }
        public IActionResult DigerSayfa()
        {
            return View();
        }
    }
}
