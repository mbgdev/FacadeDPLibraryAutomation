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
    public class DALUser
    {

        public static List<Users> UserList()
        {
            List<Users> users = new List<Users>();

            SqlCommand command = new SqlCommand("select * from TblUsers where UserStatus=1", DBConnection.sqlConnection);


            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Users entUser = new Users();
                entUser.UserId = int.Parse(reader["UserId"].ToString());
                entUser.UserNo= int.Parse(reader["UserNo"].ToString());
                entUser.UserRole = reader["UserRole"].ToString();
                entUser.UserName = reader["UserName"].ToString();
                entUser.UserSurname = reader["Usersurname"].ToString();
                entUser.UserPassword = reader["UserPassword"].ToString();
                entUser.UserEmail = reader["UserEmail"].ToString();
                entUser.UserAddress = reader["UserAddress"].ToString();
                entUser.UserStatus=(bool)reader["UserStatus"];


                users.Add(entUser);

            }

            command.Connection.Close();
            return users;


        }

        public static List<Users> UserUnList()
        {
            List<Users> users = new List<Users>();

            SqlCommand command = new SqlCommand("select * from TblUsers where UserStatus=0", DBConnection.sqlConnection);


            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Users entUser = new Users();
                entUser.UserId = int.Parse(reader["UserId"].ToString());
                entUser.UserNo = int.Parse(reader["UserNo"].ToString());
                entUser.UserRole = reader["UserRole"].ToString();
                entUser.UserName = reader["UserName"].ToString();
                entUser.UserSurname = reader["Usersurname"].ToString();
                entUser.UserPassword = reader["UserPassword"].ToString();
                entUser.UserEmail = reader["UserEmail"].ToString();
                entUser.UserAddress = reader["UserAddress"].ToString();
                entUser.UserStatus = (bool)reader["UserStatus"];


                users.Add(entUser);

            }

            command.Connection.Close();
            return users;


        }

        public static void AddUser(Users user)
        {

            SqlCommand command = new SqlCommand("insert into TblUsers (UserNo,UserRole,UserName,UserSurname,UserPassword,UserEmail,UserAddress,UserStatus) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", DBConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", user.UserNo);
            command.Parameters.AddWithValue("@p2", user.UserRole);
            command.Parameters.AddWithValue("@p3", user.UserName);
            command.Parameters.AddWithValue("@p4", user.UserSurname);
            command.Parameters.AddWithValue("@p5", user.UserPassword);
            command.Parameters.AddWithValue("@p6", user.UserEmail);
            command.Parameters.AddWithValue("@p7", user.UserAddress);
            command.Parameters.AddWithValue("@p8", user.UserStatus);
            DBConnection.sqlConnection.Open();
            command.ExecuteNonQuery();
            DBConnection.sqlConnection.Close();

        }

    }
}
