using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using FutureTechBizsoftAssignment.Data;

namespace FutureTechBizsoftAssignment.Models
{
    public class SalaryModel
    {
        public int SEQ_NO { get; set; }
        public int EMP_CODE { get; set; }
        public string MONTH { get; set; }
        public int SALARY { get; set; }
        public string COMMENTS { get; set; }
        public string FULL_NAME { get; set; }
        public string saveSalary(SalaryModel model)
        {
            string message = "";
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();

            var saveSalary = new Emp_Salary_Tbl()
            {
                EMP_CODE = model.EMP_CODE,
                MONTH = model.MONTH,
                SALARY = model.SALARY,
                COMMENTS = model.COMMENTS,
            };
            db.Emp_Salary_Tbl.Add(saveSalary);
            db.SaveChanges();
            return message;
        }

        public List<SalaryModel> getCurrentEmployee()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<SalaryModel> lstSalary = new List<SalaryModel>();
            DataTable dtTable = new DataTable();
            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "uspgetsalary";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dtTable);
                db.Database.Connection.Close();
            }

            foreach (DataRow dr in dtTable.Rows)
            {
                SalaryModel blmodel = new SalaryModel();
                blmodel.SEQ_NO = Convert.ToInt32(dr["SEQ_NO"].ToString());
                blmodel.FULL_NAME = (dr["FULL_NAME"].ToString());
                blmodel.MONTH = (dr["MONTH"].ToString());
                blmodel.SALARY = Convert.ToInt32(dr["SALARY"].ToString());
                blmodel.COMMENTS = (dr["COMMENTS"].ToString());
                lstSalary.Add(blmodel);
            }
            return lstSalary;
        }

        public List<EmployeeMasterModel> getEmployee()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeMasterModel> lstEmp = new List<EmployeeMasterModel>();
            var salaryList = db.Emp_Mas_Tbl.ToList();
            if (salaryList != null)
            {
                foreach (var sal in salaryList)
                {
                    lstEmp.Add(new EmployeeMasterModel()
                    {
                        EMP_CODE = sal.EMP_CODE,
                        FULL_NAME = sal.FULL_NAME,
                    });
                }
            }
            return lstEmp;
        }
    }
}