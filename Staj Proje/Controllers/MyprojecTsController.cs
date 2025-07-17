using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Staj_Proje.DaTa;
using Staj_Proje.EnTiTy;
using Staj_Proje.Models;

namespace Staj_Proje.Controllers
{
    public class MyprojecTsConTroller : Controller
    {
        private readonly dbconTexT conTexT;
        public MyprojecTsConTroller(dbconTexT conTexT)
        {
            this.conTexT = conTexT;
        }

        public IActionResult myprojecTIndex()
        {
            var enTity = conTexT.myprojecTs.Select(m => new MyprojecTModels
            {
                projecTID = m.projecTID,
                projecTImageURl = m.projecTImageURl,
                TiTle = m.TiTle,
                shorTdecripTion = m.shorTdecripTion
            }).ToList();

            return View(enTity);
        }
        public IActionResult ProjecTdeTail(int myprojecTID)
        {
            if (myprojecTID == null)
            {
                return NotFound();
            }

            var enTiTy_myprojecT = conTexT.myprojecTs.AsQueryable().Where(m => m.projecTID == myprojecTID).Select(m => new MyprojecTModels
            {
                projecTID = m.projecTID,
                projecTImageURl = m.projecTImageURl,
                caTegory = m.caTegory,
                TiTle = m.TiTle,
                descripTion = m.descripTion,
                giThublink = m.giThublink,
                demolink = m.demolink
            }).FirstOrDefault();
            var enTiTy_commenT = conTexT.commenTs.AsQueryable().Where(m => m.projecTID == myprojecTID).Select(m => new CommenTModels
            {
                auThorname = m.auThorname,
                auThorsurname = m.auThorsurname,
                auThormessage = m.auThormessage,
                wriTeTime = DateTime.Now
            }).ToList();
            var model = new CommenTmyprojecTModels()
            {
                myprojecT = enTiTy_myprojecT,
                commenTs = enTiTy_commenT
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult ProjecTdeTail(CommenTmyprojecTModels _auThor, int projecTID)
        {
            if (_auThor == null)
            {
                return NotFound();
            }

            var auThor = new CommenT()
            {
                projecTID = projecTID,
                auThorname = _auThor.CommenTs.auThorname,
                auThorsurname = _auThor.CommenTs.auThorsurname,
                auThormail = _auThor.CommenTs.auThormail,
                auThormessage = _auThor.CommenTs.auThormessage
            };

            conTexT.Add(auThor);
            conTexT.SaveChanges();

            return View();
        }
    }
}
