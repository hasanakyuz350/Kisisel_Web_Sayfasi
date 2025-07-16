using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Staj_Proje.DaTa;
using Staj_Proje.Models;
using System.Diagnostics;

namespace Staj_Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly dbconTexT conTexT;
        public HomeController(dbconTexT conTexT)
        {
            this.conTexT = conTexT;
        }

        public IActionResult Index()
        {
            var enTiTy_abaouTme = conTexT.mainpage_abouTme.Select(m => new HomeModels
            {
                TiTle = m.TiTle,
                subTiTle = m.subTiTle,
                shortabouTme = m.shortabouTme,
            }).FirstOrDefault();
            var enTiTy_myprojecT = conTexT.myprojecT.OrderBy(m => m.projecTID).Take(3).Select(m => new MyprojecTModels
            {
                TiTle = m.TiTle,
                shorTdecripTion = m.shorTdecripTion
            }).ToList();
            var enTiTy_mylasTprojecT = conTexT.myprojecT.OrderByDescending(m => m.projecTID).Select(m => new MyprojecTModels
            {
                TiTle = m.TiTle,
                shorTdecripTion = m.shorTdecripTion
            }).FirstOrDefault();

            var model = new HomeProjecTViewModels()
            {
                homemodel = enTiTy_abaouTme,
                myprojecTmodel = enTiTy_myprojecT,
                mylasTprojecT = enTiTy_mylasTprojecT
            };

            return View("Index", model);
        }

        public IActionResult AbouTMe()
        {
            var enTiTy_abaouTme = conTexT.mainpage_abouTme.AsQueryable();
            var model = enTiTy_abaouTme.Select(m => new HomeModels
            {
                ImageURL = m.ImageURL,
                TiTle = m.TiTle,
                subTiTle = m.subTiTle,
            });

            return View(model);
        }
    }
}
