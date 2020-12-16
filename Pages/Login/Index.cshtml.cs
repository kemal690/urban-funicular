using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_and_web_assignment.models;
using Database_and_web_assignment.Pages;
using Database_and_web_assignment.Pages.DatabaseConnection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Database_and_web_assignment.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]


        public logins Login { get; set; }
        public string Message { get; set; }
        public string SessionID;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            DatabaseConnect dbstring = new DatabaseConnect();
            string DbConnection = dbstring.DatabaseString();
            Console.WriteLine(DbConnection);
            SqlConnection conn = new SqlConnection(DbConnection);
            conn.Open();

            Console.WriteLine(Login.Username);
            Console.WriteLine(Login.Password);

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandText = @"SELECT FirstName, Username, User_Type FROM Logins WHERE Username = @Username AND Password = @Password";

                command.Parameters.AddWithValue("@Username", Login.Username);
                command.Parameters.AddWithValue("@Password", Login.Password);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Login.FirstName = reader.GetString(0);
                    Login.Username = reader.GetString(1);
                    Login.User_Type = reader.GetString(2);
                }
            }
            if (!string.IsNullOrEmpty(Login.FirstName))
            {
                SessionID = HttpContext.Session.Id;
                HttpContext.Session.SetString("SessionID", SessionID);
                HttpContext.Session.SetString("username", Login.Username);
                HttpContext.Session.SetString("fname", Login.FirstName);

                if (Login.User_Type == "Student")
                {
                    return RedirectToPage("/Student/StudentIndex");
                }
                if (Login.User_Type == "Teacher")
                {
                    return RedirectToPage("/Login/Create");
                }
                else
                {
                    return RedirectToPage("/Admin/AdminIndex");
                }
            }
            else
            {
                Message = "Invalid Username or Password!";
                return Page();
            }
                
            }
        }
    }


