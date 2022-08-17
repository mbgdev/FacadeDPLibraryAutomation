using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Books
    {
        private int bookId;

        private string bookName;

        private string bookAuthor;

        private string bookType;

        private int bookPageCount;

        private int categoryId;
        
        private string categoryName;


        private bool bookStatus;

        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string BookType { get => bookType; set => bookType = value; }
        public int BookPageCount { get => bookPageCount; set => bookPageCount = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public bool BookStatus { get => bookStatus; set => bookStatus = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
