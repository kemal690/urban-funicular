using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_and_web_assignment.Pages.DatabaseConnection
{
    public class DatabaseConnect 
    {
        public string DatabaseString()
        {
            string DbString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_and_web_assignmentContext-f0041a96-d18d-46b9-af33-463094b34d70;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return DbString;
        }
    }


}
