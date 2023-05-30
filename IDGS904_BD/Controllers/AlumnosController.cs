using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904_BD.Models;

namespace IDGS904_BD.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using(AlumnosDBContext dbAlumnos=new AlumnosDBContext())
            {
                //select * from alumnos
                return View(dbAlumnos.Alumnos.ToList());
            }
        }
        public ActionResult Create()
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                return View();
            }
        }
        public ActionResult Edit(int? id)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                Alumnos alumno = dbAlumnos.Alumnos.Find(id);
                if (alumno == null)
                {
                    return HttpNotFound();
                }
                return View(alumno);
            }
        }

        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                dbAlumnos.Alumnos.Add(alum);
                dbAlumnos.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                Alumnos alumno = dbAlumnos.Alumnos.Find(id);
                if (alumno == null)
                {
                    return HttpNotFound();
                }
                return View(alumno);
            }
        }
        public ActionResult Edit(int? id, Alumnos alum)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                if (ModelState.IsValid)
                {
                    dbAlumnos.Entry(alum).State = EntityState.Modified;
                    dbAlumnos.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(alum);
            }
        }
    }
}