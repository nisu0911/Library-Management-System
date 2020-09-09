using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Entity;

namespace BLL
{
    public class BLLUser
    {
        LibraryMSEntities _db = new LibraryMSEntities();
        public int verifyUser(UserDetails ud)
        {
            var user = _db.verifyUser(ud.Username, ud.Password, ud.UserType);
            if (user != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public List<UserDetails> getUsers()
        {
            List<UserDetails> lst = new List<UserDetails>();
            List<GetUsers_Result> lstusr = _db.GetUsers().ToList();
            foreach (GetUsers_Result item in lstusr)
            {
                lst.Add(new UserDetails() { UserID = item.UserID, FullName = item.FullName, UserType = item.UserType, Username = item.Username, Password = item.Password });
            }
            return lst;
        }
        public int addUser(UserDetails ud)
        {
            var user = _db.AddUser(ud.FullName, ud.Username, ud.UserType, ud.Password);
            if (user != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int updateUser(UserDetails ud)
        {
            var user = _db.UpdateUser(ud.UserID,ud.Username,ud.Password,ud.UserType,ud.FullName);
            if (user != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int deleteUser(UserDetails ud)
        {
            var user = _db.DeleteUser(ud.UserID);
            if (user != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
