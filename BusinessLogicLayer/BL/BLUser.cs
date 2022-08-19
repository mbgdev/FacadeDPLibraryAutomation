using DataAccessLayer.DAL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLUser
    {
        public static List<Users> BLUserList()
        {
            return DALUser.UserList();
        }

        public static List<Users> BLUserUnList()
        {
            return DALUser.UserUnList();
        }

        public static void BLAddUser(Users user)
        {
            DALUser.AddUser(user);
        }



    }
}
