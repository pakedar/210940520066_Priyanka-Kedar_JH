using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2Exam.Models;

namespace WebApplication2Exam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Final> products = new List<Final>();
            string connectionDetails =
               @"server=(LocalDB)\MSSQLLocalDB;database=productInfo;Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionDetails);

            connection.Open();


            SqlCommand command = new SqlCommand("select * from PProducts", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int No = Convert.ToInt32(reader["ProductID"]);
                string Name = reader["ProductName"].ToString();
                string Rate = reader["RateDecimal"].ToString();
                string Description = reader["Description"].ToString();
                string Category = reader["CategoryName"].ToString();

                Final product = new Final(No, Name, Rate, Description, Category);
                products.Add(product);
                               
            }

            connection.Close();
            return View("Index", products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}