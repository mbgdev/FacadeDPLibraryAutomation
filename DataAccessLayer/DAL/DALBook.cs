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
    public class DALBook
    {
        public static List<Books> BooksList()
        {
            List<Books> books = new List<Books>();

            SqlCommand command = new SqlCommand("exec ProcedureBookList", DBConnection.sqlConnection);


            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Books entBook = new Books();
                entBook.BookId = int.Parse(reader["BookId"].ToString());
                entBook.BookName = reader["BookName"].ToString();
                entBook.BookAuthor = reader["BookAuthor"].ToString();
                entBook.BookType = reader["BookType"].ToString();
                entBook.BookPageCount = int.Parse(reader["BookPageCount"].ToString());
                entBook.CategoryName = reader["CategoryName"].ToString();
                entBook.BookStatus = (bool)reader["BookStatus"];
             
               
                books.Add(entBook);
                
            }
            
            command.Connection.Close();
            return books;


        }

        public static List<Books> BooksUnList()
        {
            List<Books> books = new List<Books>();

            SqlCommand command = new SqlCommand("exec ProcedureBookUnList", DBConnection.sqlConnection);


            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Books entBook = new Books();
                entBook.BookId = int.Parse(reader["BookId"].ToString());
                entBook.BookName = reader["BookName"].ToString();
                entBook.BookAuthor = reader["BookAuthor"].ToString();
                entBook.BookType = reader["BookType"].ToString();
                entBook.BookPageCount = int.Parse(reader["BookPageCount"].ToString());
                entBook.CategoryName = reader["CategoryName"].ToString();
                entBook.BookStatus = (bool)reader["BookStatus"];


                books.Add(entBook);

            }

            command.Connection.Close();
            return books;


        }



        public static void AddBook(Books book)
        {

            SqlCommand command = new SqlCommand("insert into TblBooks (BookName,BookAuthor,BookType,BookPageCount,CategoryId,BookStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)", DBConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", book.BookName);
            command.Parameters.AddWithValue("@p2", book.BookAuthor);
            command.Parameters.AddWithValue("@p3", book.BookType);
            command.Parameters.AddWithValue("@p4", book.BookPageCount);
            command.Parameters.AddWithValue("@p5", book.CategoryId);
            command.Parameters.AddWithValue("@p6", book.BookStatus);
            DBConnection.sqlConnection.Open();
            command.ExecuteNonQuery();
            DBConnection.sqlConnection.Close();

        }
    }
}
