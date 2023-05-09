using CrudMVCTAK.Models;
using CrudMVCTAK.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVCTAK.Controllers
{
    public class ColaboradoresController : Controller
    {
        // GET: Colaboradores
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult List() 
        {
            List<ListColaboradoresViewModel> lst = new List<ListColaboradoresViewModel>();
            using (PruebaTakEntities db = 
                new PruebaTakEntities())
            {
                lst =
                    (from d in db.Colaboradores
                    orderby d.Id descending
                    select new ListColaboradoresViewModel
                    {
                        Id=d.Id,
                        Name=d.Name,
                        LastName=d.LastName,
                        DateN=d.DateN,
                        EstadoCivil=d.EstadoCivil,
                        GradoAC=d.GradoAC,
                        Direccion=d.Direccion,  
                    }).ToList();
            }
            return View(lst);
        }

        public ActionResult New() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(ColaboradoresViewModel model) 
        {
            try
            {
                using (PruebaTakEntities db = new PruebaTakEntities())
                {
                    var oColaboradores = new Colaboradores();
                    oColaboradores.Name = model.Name;
                    oColaboradores.LastName = model.LastName;
                    oColaboradores.DateN    = model.DateN;
                    oColaboradores.EstadoCivil = model.EstadoCivil; 
                    oColaboradores.GradoAC = model.GradoAC;
                    oColaboradores.Direccion = model.Direccion;
                    db.Colaboradores.Add(oColaboradores);
                    db.SaveChanges();
                }

                return Content("1");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public ActionResult Edit(int Id)
        {
            ColaboradoresViewModel model = new ColaboradoresViewModel();
            using (PruebaTakEntities db = new PruebaTakEntities())
            {
                var oColaboradores = db.Colaboradores.Find(Id);
                model.Name = oColaboradores.Name;
                model.LastName = oColaboradores.LastName;
                model.DateN= (DateTime)oColaboradores.DateN;
                model.EstadoCivil = oColaboradores.EstadoCivil;
                model.GradoAC = oColaboradores.GradoAC;
                model.Direccion = oColaboradores.Direccion;
                model.Id = oColaboradores.Id;

            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ColaboradoresViewModel model)
        {
            try
            {
                using (PruebaTakEntities db = new PruebaTakEntities())
                {
                    var oColaboradores = db.Colaboradores.Find(model.Id);
                    oColaboradores.Name = model.Name;
                    oColaboradores.LastName = model.LastName;
                    oColaboradores.DateN = model.DateN;
                    oColaboradores.EstadoCivil = model.EstadoCivil;
                    oColaboradores.GradoAC = model.GradoAC;
                    oColaboradores.Direccion = model.Direccion;
                    db.Entry(oColaboradores).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                return Content("1");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Delete(ColaboradoresViewModel model)
        {
            try
            {
                using (PruebaTakEntities db = new PruebaTakEntities())
                {
                    var oColaboradores = db.Colaboradores.Find(model.Id);
                    db.Colaboradores.Remove(oColaboradores);
                    db.SaveChanges();
                }

                return Content("1");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}