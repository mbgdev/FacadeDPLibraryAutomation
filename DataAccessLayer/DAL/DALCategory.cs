using DataAccessLayer.Connection;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class DALCategory
    {
        public static List<Category> CategoryList()
        {

            List<Category> ent = new List<Category>();

            SqlCommand command = new SqlCommand("select * from TblCategory", DBConnection.sqlConnection);

            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = int.Parse(reader[0].ToString());
                category.CategoryName = reader[1].ToString();
                category.CategoryStatus = (bool)reader[2];
                ent.Add(category);
            }
            command.Connection.Close();
            return ent;








        }



        public static void AddCategory(Category category)
        {

            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName,CategoryStatus) values (@p1,@p2)", DBConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", category.CategoryName);
            command.Parameters.AddWithValue("@p2", category.CategoryStatus);
            DBConnection.sqlConnection.Open();
            command.ExecuteNonQuery();
            DBConnection.sqlConnection.Close();

        }

        public static void UpdateCategory(Category category)
        {
            SqlCommand command = new SqlCommand("Update TblCategory Set CategoryName=@p1,CategoryStatus=@p2  where CategoryID=@p3", DBConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", category.CategoryName);
            command.Parameters.AddWithValue("@p2", category.CategoryStatus);
            command.Parameters.AddWithValue("@p3", category.CategoryId);
            DBConnection.sqlConnection.Open();
            command.ExecuteNonQuery();
            DBConnection.sqlConnection.Close();
        }




    }
}
