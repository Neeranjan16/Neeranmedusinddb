using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationmovies.Controllers
{
    public class HomeController : Controller
    {
        neemedusindDBEntities2 _Context  = new neemedusindDBEntities2();

        public ActionResult Index()
        {
            var listofData = _Context.NeeranjMovies.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NeeranjMovie model)
        {
            _Context.NeeranjMovies.Add(model);
            _Context.SaveChanges();
            ViewBag.Message = "data insert sucessfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int MovID)

        {
            var data = _Context.NeeranjMovies.Where(x => x.MovID == MovID).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(NeeranjMovie model)
        {
            var data = _Context.NeeranjMovies.Where(x => x.MovID == model.MovID).FirstOrDefault();
            if (data != null)
            {
                data.MovName = model.MovName;
                data.RealaseDate = model.RealaseDate;
                _Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int MovID)
        {
            var data = _Context.NeeranjMovies.Where(x => x.MovID == MovID).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int MovID)
        {
            var data = _Context.NeeranjMovies.Where(x => x.MovID ==MovID).FirstOrDefault();
            _Context.NeeranjMovies.Remove(data);
            _Context.SaveChanges();
            ViewBag.Message = "record deleted sucessfully";
            return RedirectToAction("Index");
        }


    }

}