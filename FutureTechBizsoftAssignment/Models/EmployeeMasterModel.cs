using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FutureTechBizsoftAssignment.Data;

namespace FutureTechBizsoftAssignment.Models
{
    public class EmployeeMasterModel
    {
        public int EMP_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public System.DateTime DOB { get; set; }
        public System.DateTime JOIN_DATE { get; set; }
        public int CITY_CODE { get; set; }
        public int DEPT_CODE { get; set; }
        
        
        public string saveEmployee(EmployeeMasterModel model)
        {
            string message = "";
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();

            var saveEmployee = new Emp_Mas_Tbl()
            {
                FIRST_NAME = model.FIRST_NAME,
                MIDDLE_NAME = model.MIDDLE_NAME,
                LAST_NAME = model.LAST_NAME,
                FULL_NAME = model.FULL_NAME,
                DOB = model.DOB,
                JOIN_DATE = model.JOIN_DATE,
                CITY_CODE = model.CITY_CODE,
                DEPT_CODE = model.DEPT_CODE,
            };
            db.Emp_Mas_Tbl.Add(saveEmployee);
            db.SaveChanges();
            return message;
        }

        
    }
}