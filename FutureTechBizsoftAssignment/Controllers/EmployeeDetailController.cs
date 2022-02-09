using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutureTechBizsoftAssignment.Models;

namespace FutureTechBizsoftAssignment.Controllers
{
    public class EmployeeDetailController : Controller
    {
        // GET: EmployeeDetail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmpdetails()
        {
            try
            {
                return Json(new { model = (new EmployeeDetailModel().GetEmpdetails()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult getdepartment()
        {
            try
            {
                return Json(new { model = (new EmployeeDetailModel().getdepartment()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult getcity()
        {
            try
            {
                return Json(new { model = (new EmployeeDetailModel().getcity()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult CurrentEmployee()
        {
            return View();
        }
        public ActionResult GetEmpReport()
        {
            try
            {
                return Json(new { model = (new EmployeeDetailModel().GetEmpReport()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetEmpDepReport()
        {
            try
            {
                return Json(new { model = (new EmployeeDetailModel().GetEmpDepReport()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}