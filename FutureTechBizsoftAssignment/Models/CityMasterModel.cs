using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FutureTechBizsoftAssignment.Data;

namespace FutureTechBizsoftAssignment.Models
{
    public class CityMasterModel
    {
        public int CITY_CODE { get; set; }
        public string CITY_NAME { get; set; }
        public string STATE_NAME { get; set; }
        public string COUNRTY_NAME { get; set; }
        public int SORT_NO { get; set; }

        public string saveCity(CityMasterModel model)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
        {
            string message = "";
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();

            var saveCity = new City_Mas_Tbl()
            {
                CITY_NAME = model.CITY_NAME,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                STATE_NAME = model.STATE_NAME,
                COUNRTY_NAME = model.COUNRTY_NAME,
                SORT_NO = model.SORT_NO,
            };
            db.City_Mas_Tbl.Add(saveCity);
            db.SaveChanges();
            return message;
        }

        public List<CityMasterModel> getCityList()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<CityMasterModel> lstCity = new List<CityMasterModel>();
            var cityList = db.City_Mas_Tbl.ToList();
            if (cityList != null)
            {
                foreach (var city in cityList)
                {
                    lstCity.Add(new CityMasterModel()
                    {
                        CITY_CODE = city.CITY_CODE,
                        CITY_NAME = city.CITY_NAME,
                        STATE_NAME = city.STATE_NAME,
                        COUNRTY_NAME = city.COUNRTY_NAME,
                        SORT_NO = city.SORT_NO,
                    });
                }
            }
            return lstCity;
        }
    }
}