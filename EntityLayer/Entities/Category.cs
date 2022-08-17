using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        private int categoryId;

        private string categoryName;

        private bool categoryStatus;

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public bool CategoryStatus { get => categoryStatus; set => categoryStatus = value; }
    }
}
