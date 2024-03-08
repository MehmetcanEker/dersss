using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            Urun urun =  new Urun(); urun.Id = 1; urun.Ad = "Dell Aspire"; urun.Stok = 100;  
            return View(urun);
        }
        [HttpPost]

        public IActionResult Ekle(Urun urun)
        {
            return View();
        }
        public IActionResult Sil()
        {
            return View();
        }
        public IActionResult Güncele()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }
    }
}
