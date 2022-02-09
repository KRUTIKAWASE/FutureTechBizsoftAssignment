using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutureTechBizsoftAssignment.Models;

namespace FutureTechBizsoftAssignment.Controllers
{
    public class EmployeeMasterController : Controller
    {
        // GET: EmployeeMaster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saveEmployee(EmployeeMasterModel model)
        {
            try
            {
                return Json(new { Message = (new EmployeeMasterModel().saveEmployee(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

       
    }
}