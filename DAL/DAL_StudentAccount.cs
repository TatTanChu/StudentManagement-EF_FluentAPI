using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_StudentAccount
    {
        DAL_DbContext db;

        public DAL_StudentAccount()
        {
            db = new DAL_DbContext();
        }

        //CHANGE PASSWORD FOR STUDENT ACCOUNT :
        public void changePassword(int studentId, string newPassword)
        {
            DTO_StudentAccount studentAccount = db.StudentAcccounts.Single(st => st.StudentID == studentId);
            studentAccount.Password = newPassword;
            db.SaveChanges();
        }
    }
}
