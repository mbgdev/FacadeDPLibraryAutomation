using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Users
    {
        private int userId;

        private int userNo;

        private string userRole;

        private string userName;

        private string userSurname;

        private string userPassword;

        private string userEmail;

        private string userAddress;

        private bool userStatus;

        public int UserId { get => userId; set => userId = value; }
        public int UserNo { get => userNo; set => userNo = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserSurname { get => userSurname; set => userSurname = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
        public bool UserStatus { get => userStatus; set => userStatus = value; }
    }
}
