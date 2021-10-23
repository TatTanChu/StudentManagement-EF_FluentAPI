using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_TeacherAccount
    {
        DAL_TeacherAccount dal;

        public BLL_TeacherAccount()
        {
            dal = new DAL.DAL_TeacherAccount();
        }

        //CHANGE PASSWORD FOR TEACHER : 
        public void changePasswordForTeacher(int teacherId, string password)
        {
            dal.changPasswordForTeacher(teacherId, password);
        }
    }
}
