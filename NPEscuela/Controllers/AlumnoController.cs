using NPEscuela.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPEscuela.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            using (BDmodels context = new BDmodels())
            {  
                return View(context.Alumnos.ToList());
            }
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            using (BDmodels context = new BDmodels())
            {
                return View(context.Alumnos.Where(x => x.Id_Alumnos == id).FirstOrDefault());
            }
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {
                using (BDmodels contexts = new BDmodels())
                {
                    contexts.Alumnos.Add(alumnos);
                    contexts.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            using (BDmodels context = new BDmodels())
            {
                return View(context.Alumnos.Where(x => x.Id_Alumnos == id).FirstOrDefault());
            }
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alumnos)
        {
            try
            {
                using (BDmodels context = new BDmodels())
                {
                    context.Entry(alumnos).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            using (BDmodels context = new BDmodels())
            {
                return View(context.Alumnos.Where(x => x.Id_Alumnos == id).FirstOrDefault());
            }
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (BDmodels context = new BDmodels())
                {
                    Alumnos alumno = context.Alumnos.Where(x=>x.Id_Alumnos == id).FirstOrDefault();
                    context.Alumnos.Remove(alumno);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
