using Crud_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_MVC.Controllers
{
    public class HomeController : Controller
    {
       CRUDWITHEFEntities _dbentities= new CRUDWITHEFEntities();
        public ActionResult Index()
        {
            List<EMPLOYEEMASTER> emps = _dbentities.EMPLOYEEMASTERs.ToList(); 
            return View(emps);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(EMPLOYEEMASTER emps)
        {
            EMPLOYEEMASTER emp = _dbentities.EMPLOYEEMASTERs.Add(emps);
            _dbentities.SaveChanges();
            return RedirectToAction("index","Home");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            EMPLOYEEMASTER emp = _dbentities.EMPLOYEEMASTERs.Find(id);
            return View(emp);
        }
        [HttpGet]
        public ActionResult Edit( int id)
        {
            EMPLOYEEMASTER emp = _dbentities.EMPLOYEEMASTERs.Find(id);
            return View(emp);
        }
        
        [HttpPost]
        public ActionResult Edit(EMPLOYEEMASTER emps)
        {
            EMPLOYEEMASTER emp = _dbentities.EMPLOYEEMASTERs.Add(emps);
            _dbentities.Entry(emp).State = EntityState.Modified;
            _dbentities.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            EMPLOYEEMASTER emps = _dbentities.EMPLOYEEMASTERs.Find(id);
            return View(emps);
        }
        [HttpPost]
        public ActionResult Delete(string id)
        {
            int eid = Convert.ToInt32(id);
            EMPLOYEEMASTER emps = _dbentities.EMPLOYEEMASTERs.Find(eid);
            _dbentities.EMPLOYEEMASTERs.Remove(emps);
            _dbentities.SaveChanges();

            return RedirectToAction("index", "Home");

        }
    }
}