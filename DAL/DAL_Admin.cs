using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_Admin
    {
        DAL_DbContext db; 
        
        public DAL_Admin()
        {
            db = new DAL_DbContext();
        }

        //CHECK ADMIN LOGIN : 
        public bool checkAdminLogin(string AdminId, string password)
        {

            var checkLogin = (from a in db.Admins
                              where a.AdminId == AdminId && a.Password == password
                              select a.AdminName).ToList();

            return checkLogin.Count > 0;
        }

        //SHOW ADMIN INFORMATION : 
        public DTO_Admin showAdminInfomation(string AdminId)
        {
            DTO_Admin admin = new DTO_Admin();

            var getInfo = (from a in db.Admins
                           where a.AdminId == AdminId
                           select new
                           {
                               a.Address,
                               a.AdminName,
                               a.DateOfBirth,
                               a.Email,
                               a.Gender,
                               a.Phone, 
                           }
                           ).ToList(); 

            foreach(var item in getInfo)
            {
                admin.Phone = item.Phone;
                admin.Gender = item.Gender;
                admin.Email = item.Email;
                admin.AdminName = item.AdminName;
                admin.DateOfBirth = item.DateOfBirth;
                admin.Address = item.Address;
                break;
            }

            return admin;
        }

        //UPDATE INFORMATION OF ADMIN : 
        public void updateAdminInformation(string AdminId, string Phone, string Gender, string Email, string AdminName, DateTime? DateOfBirth, string Address)
        {
            DTO_Admin admin = db.Admins.Single(a => a.AdminId == AdminId);
            admin.Phone = Phone;
            admin.Gender = Gender;
            admin.Email = Email;
            admin.DateOfBirth = DateOfBirth;
            admin.Address = Address;
            admin.AdminName = AdminName;
            db.SaveChanges();
        }

        //CHANGE USERNAME OF ADMIN : 
        public void changeUserNameOfAdmin(string AdminId, string AdminIdNew)
        {
            DTO_Admin admin = db.Admins.Single(a => a.AdminId == AdminId);
            admin.AdminId = AdminIdNew;
            db.SaveChanges();
        }

        //CHANGE PASSWORD FOR ADMIN : 
        public void changePasswordOfAdmin(string AdminId, string new_Password)
        {
            DTO_Admin admin = db.Admins.Single(a => a.AdminId == AdminId);
            admin.Password = new_Password;
            db.SaveChanges();
        }
    }
}
