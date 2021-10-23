using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 

namespace BLL
{
    public class BLL_StudentAccount
    {
        DAL_StudentAccount dal;

        public BLL_StudentAccount()
        {
            dal = new DAL_StudentAccount();
        }

        //CHANGE PASSWORD FOR STUDENT ACCOUNT :
        public void changePassword(int studentId, string newPassword)
        {
            dal.changePassword(studentId, newPassword);
        }
    }
}
