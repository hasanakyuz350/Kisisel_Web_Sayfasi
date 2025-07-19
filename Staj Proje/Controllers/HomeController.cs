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
            var enTiTy_abaouTme = conTexT.homes.Select(m => new HomeModels
            {
                TiTle = m.TiTle,
                subTiTle = m.subTiTle,
                shortabouTme = m.shortabouTme,
                ImageURL = m.ImageURL
            }).FirstOrDefault();
            var enTiTy_myprojecT = conTexT.myprojecTs.OrderBy(m => m.projecTID).Take(3).Select(m => new MyprojecTModels
            {
                projecTImageURl = m.projecTImageURl,
                TiTle = m.TiTle,
                shorTdecripTion = m.shorTdecripTion
            }).ToList();
            var enTiTy_mylasTprojecT = conTexT.myprojecTs.OrderByDescending(m => m.projecTID).Select(m => new MyprojecTModels
            {
                projecTID = m.projecTID,
                projecTImageURl = m.projecTImageURl,
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
            var enTiTy_abaouTme = conTexT.abouTMes.AsQueryable();
            var model = enTiTy_abaouTme.Select(m => new AbouTMeModels
            {
                mypicTureURL = m.mypicTureURL,
                abouTme = m.abouTme,
                myBiography = m.myBiography,
                myTalenT = m.myTalenT.Select(m => new CaTegoryModels
                {
                    caTegoryname = m.caTegoryname,
                }).ToList()
            }).FirstOrDefault();

            return View(model);
        }
    }
}
