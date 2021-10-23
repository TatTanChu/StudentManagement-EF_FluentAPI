using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO.Model;

namespace BLL
{
    public class BLL_Admin
    {
        DAL_Admin dal;
        public BLL_Admin()
        {
            dal = new DAL_Admin();
        }

        //CHECK ADMIN LOGIN : 
        public bool checkAdminLogin(string AdminId, string password)
        {
            return dal.checkAdminLogin(AdminId, password);
        }

        //SHOW ADMIN INFORMATION : 
        public DTO_Admin showAdminInfomation(string AdminId)
        {
            return dal.showAdminInfomation(AdminId);
        }

        //UPDATE INFORMATION OF ADMIN : 
        public void updateAdminInformation(string AdminId, string Phone, string Gender, string Email, string AdminName, DateTime? DateOfBirth, string Address)
        {
            dal.updateAdminInformation(AdminId, Phone, Gender, Email, AdminName, DateOfBirth, Address);
        }

        //CHANGE USERNAME OF ADMIN : 
        public void changeUserNameOfAdmin(string AdminId, string AdminIdNew)
        {
            dal.changeUserNameOfAdmin(AdminId, AdminIdNew);
        }

        //CHANGE PASSWORD FOR ADMIN : 
        public void changePasswordOfAdmin(string AdminId, string new_Password)
        {
            dal.changePasswordOfAdmin(AdminId, new_Password);
        }
    }
}
