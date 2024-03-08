using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MeyveController : Controller
    {
        public object Meyveler { get; private set; }

        public IActionResult Index()
        {

            List<Meyve> Meyveler = new List<Meyve>()
            {

             new Meyve() {Id=1,Ad="Elma",Stok=200 },
             new Meyve() {Id=1,Ad="Armut",Stok=300 } ,
             new Meyve() {Id=1,Ad="Erik",Stok=100 } ,
             new Meyve() {Id=1,Ad="Muz",Stok=150 },
             new Meyve() {Id=1,Ad="Çilek",Stok=250 } ,
             new Meyve() {Id=1,Ad="Mango",Stok=80 },
             new Meyve() {Id=1,Ad="üzüm",Stok=120 }
            };
            int ListeElemansayisi = Meyveler.Count();
            ViewBag.mesaj1 = "bu listede 6 adet ürün varıdr";
            ViewBag.mesaj2 = "bu listede" + Meyveler.Count() + "adet ürün vardır";
            ViewBag.Mesaj3 = "bu listede {listeElemanSayisi} Adet ürün vardır";
            ViewBag.Mesaj4 = "bu listede {ListeElemanSayisi} Adet ürün vardır";

            ViewData["mesaj1"] = "bu listede 6 adet ürün vardır";
            ViewData["mesaj2"] = "bu listede" + Meyveler.Count() + "adet ürün vardır.";
            ViewData["mesaj3"] = "bu listede {listeElemanSayisi} Adet ürün vardır.";
            ViewData["mesaj4"] = "bu listede {ListeElemanSayisi} Adet ürün vardır.";

            TempData["mesaj5"] = "bu mesaj Tempdata ile gonderirmiştir";
            //Meyve meyveTmp = new Meyve() { Id = 11, Ad = "kiraz"i stok = 123};
            //ViewBag.meyveViewBag = meyveTmp;

            return View(Meyveler);
        }
    }

    
}

