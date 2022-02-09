using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutureTechBizsoftAssignment.Models;

namespace FutureTechBizsoftAssignment.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saveSalary(SalaryModel model)
        {
            try
            {
                return Json(new { Message = (new SalaryModel().saveSalary(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult getCurrentEmployee()
        {
            try
            {
                return Json(new { model = (new SalaryModel().getCurrentEmployee()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { message= Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult getEmployee()
        {
            try
            {
                return Json(new { model = (new SalaryModel().getEmployee()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}