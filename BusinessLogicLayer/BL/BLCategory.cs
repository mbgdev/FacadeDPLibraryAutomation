using DataAccessLayer.DAL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLCategory
    {
        public static List<Category> BLCategoryList()
        {
            return DALCategory.CategoryList();
        }

        public static void BLCategoryAdd(Category category)
        {
            if (category.CategoryName !="" && category.CategoryName.Length <= 30 && category.CategoryName.Length >= 5)
            {
                DALCategory.AddCategory(category);
            }
            else
            {
                //hata
            }
        }


        public static void BLCategoryUpdate(Category category)
        {
            if (category.CategoryName != "" && category.CategoryName.Length >= 5)
            {
                DALCategory.UpdateCategory(category);
            }
        }



    }
}
