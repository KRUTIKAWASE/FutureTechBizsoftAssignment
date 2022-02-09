using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using FutureTechBizsoftAssignment.Data;

namespace FutureTechBizsoftAssignment.Models
{
    public class EmployeeDetailModel
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
        public string CITY_NAME { get; set; }
        public string DEPT_NAME { get; set; }
        public string SALARY { get; set; }
        public string DOB_String { get; set; }
        public string JOINDATE_String { get; set; }
        public int TotalEmp { get; set; }

        public List<EmployeeDetailModel> GetEmpdetails()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeDetailModel> lstDetail = new List<EmployeeDetailModel>();
            DataTable dtTable = new DataTable();
            var date = JOIN_DATE.ToString("yyyy-MM-dd");
            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "uspgetemployeelist";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dtTable);
                db.Database.Connection.Close();
            }

            foreach (DataRow dr in dtTable.Rows)
            {
                EmployeeDetailModel blmodel = new EmployeeDetailModel();
                blmodel.EMP_CODE = Convert.ToInt32(dr["EMP_CODE"].ToString());
                blmodel.FIRST_NAME = (dr["FIRST_NAME"].ToString());
                blmodel.MIDDLE_NAME = (dr["MIDDLE_NAME"].ToString());
                blmodel.LAST_NAME = (dr["LAST_NAME"].ToString());
                blmodel.FULL_NAME = (dr["FULL_NAME"].ToString());
                blmodel.DOB_String = Convert.ToDateTime((dr["DOB"]).ToString()).ToString("MM/dd/yyyy");
                blmodel.JOINDATE_String = Convert.ToDateTime((dr["JOIN_DATE"]).ToString()).ToString("MM/dd/yyyy");
                blmodel.CITY_NAME = (dr["CITY_NAME"].ToString());
                blmodel.DEPT_NAME = (dr["DEPT_NAME"].ToString());
                blmodel.SALARY = (dr["SALARY"].ToString());
                lstDetail.Add(blmodel);
            }
            return lstDetail;
        }

        public List<EmployeeDetailModel> getdepartment()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeDetailModel> deptlst = new List<EmployeeDetailModel>();
            var deptList = db.Dept_Mas_Tbl.ToList();
            if (deptList != null)
            {
                foreach (var dept in deptList)
                {
                    deptlst.Add(new EmployeeDetailModel()
                    {
                        DEPT_CODE = dept.DEPT_CODE,
                        DEPT_NAME = dept.DEPT_NAME,
                    });
                }
            }
            return deptlst;
        }

        public List<EmployeeDetailModel> getcity()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeDetailModel> deptlst = new List<EmployeeDetailModel>();
            var cityList = db.City_Mas_Tbl.ToList();
            if (cityList != null)
            {
                foreach (var city in cityList)
                {
                    deptlst.Add(new EmployeeDetailModel()
                    {
                        CITY_CODE = city.CITY_CODE,
                        CITY_NAME = city.CITY_NAME,
                    });
                }
            }
            return deptlst;
        }
        public List<EmployeeDetailModel> GetEmpReport()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeDetailModel> lstDetail = new List<EmployeeDetailModel>();
            DataTable dtTable = new DataTable();
            
            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "uspgetemployeereport";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dtTable);
                db.Database.Connection.Close();
            }

            foreach (DataRow dr in dtTable.Rows)
            {
                EmployeeDetailModel blmodel = new EmployeeDetailModel();
                blmodel.EMP_CODE = Convert.ToInt32(dr["EMP_CODE"].ToString());
       
                blmodel.FULL_NAME = (dr["FULL_NAME"].ToString());
            
                blmodel.SALARY = (dr["SALARY"].ToString());
                lstDetail.Add(blmodel);
            }
            return lstDetail;
        }
        public List<EmployeeDetailModel> GetEmpDepReport()
        {
            FutureTechBizsoftLLPEntities db = new FutureTechBizsoftLLPEntities();
            List<EmployeeDetailModel> lstDetail = new List<EmployeeDetailModel>();
            DataTable dtTable = new DataTable();

            using (var cmd = db.Database.Connection.CreateCommand())
            {
                db.Database.Connection.Open();
                cmd.CommandText = "uspgetemployeedepreport";
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dtTable);
                db.Database.Connection.Close();
            }

            foreach (DataRow dr in dtTable.Rows)
            {
                EmployeeDetailModel blmodel = new EmployeeDetailModel();
                blmodel.TotalEmp = Convert.ToInt32(dr["TotalEmp"].ToString());

                blmodel.DEPT_NAME = (dr["DEPT_NAME"].ToString());

               
                lstDetail.Add(blmodel);
            }
            return lstDetail;
        }
    }
}