using DataAccessLayer.DAL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLBook
    {

        public static List<Books> BLBookList()
        {
            return DALBook.BooksList();
        }

        public static List<Books> BLBookUnList()
        {
            return DALBook.BooksUnList();
        }



        public static void BLAddBook(Books book)
        {
            DALBook.AddBook(book);
        }




    }
}
