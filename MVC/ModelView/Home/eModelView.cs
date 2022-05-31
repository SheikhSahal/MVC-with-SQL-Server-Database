using MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.ModelView.Home
{
    public class eModelView
    {
        public List<MDataEmp> GEtdb() 
        {
            List<MDataEmp> DBase = new List<MDataEmp>();

            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("emp_usp_emp", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MDataEmp emp = new MDataEmp();
                        emp.id = Convert.ToInt16(reader["id"]);
                        emp.Name = reader["Name"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.Mobile = reader["Mobile"].ToString();
                        emp.address = reader["address"].ToString();
                        DBase.Add(emp);

                    }
                }
            }
            return DBase;
        }



        public void AddNewEmployee(MDataEmp empl)
        {
            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {

                using (SqlCommand cmd = new SqlCommand("usp_addemp", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Name", empl.Name);
                    cmd.Parameters.AddWithValue("@Email", empl.Email);
                    cmd.Parameters.AddWithValue("@Mobile", empl.Mobile);
                    cmd.Parameters.AddWithValue("@Address", empl.address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public MDataEmp employeedetailbyid(int id)
        {
            MDataEmp employee = new MDataEmp();
            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_details", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    employee.id = Convert.ToInt16(reader["id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Email = reader["Email"].ToString();
                    employee.Mobile = reader["Mobile"].ToString();
                    employee.address = reader["address"].ToString();
                }
            }
            return employee;
        }



        public void updateemp(MDataEmp emp)
        {
            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_updateemp", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", emp.id);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Mobile", emp.Mobile);
                    cmd.Parameters.AddWithValue("@Address", emp.address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Getdeleterecord(int id)
        {
            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_deleterecord", conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                
                }
                
            }
        }


    }
}