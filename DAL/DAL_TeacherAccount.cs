using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_TeacherAccount
    {
        DAL_DbContext db; 

        public DAL_TeacherAccount()
        {
            db = new DAL_DbContext();
        }

        //CHANGE PASSWORD FOR TEACHER ACCOUNT : 
        public void changPasswordForTeacher(int teacherId, string newPassword)
        {
            DTO_TeacherAccount teacherAccount = db.TeacherAccount.Single(t => t.TeacherID == teacherId);
            teacherAccount.Password = newPassword;
            db.SaveChanges();
        }
    }
}
