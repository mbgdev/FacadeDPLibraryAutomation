using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Connection
{
    public class DBConnection
    {
     public static  SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=DbFacadeLibraryAutomation;Integrated Security=True;");
    }
}
