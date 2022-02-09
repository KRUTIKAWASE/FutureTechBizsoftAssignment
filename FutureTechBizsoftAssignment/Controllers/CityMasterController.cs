using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutureTechBizsoftAssignment.Models;

namespace FutureTechBizsoftAssignment.Controllers
{
    public class CityMasterController : Controller
    {
        // GET: CityMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult saveCity(CityMasterModel model)
        {
            try
            {
                return Json(new { Message = (new CityMasterModel().saveCity(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult getCityList()
        {
            try
            {
                return Json(new { model = (new CityMasterModel().getCityList()) },JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}