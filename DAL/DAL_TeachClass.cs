using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TeachClass
    {
        DAL_DbContext db;

        public DAL_TeachClass()
        {
            db = new DAL_DbContext();
        }

        //CREATE TEACHER CLASS :
        public void createTeachClass(string subjectId, int teacherId, string studentClass)
        {
            DTO_TeachClass teachClass = new DTO_TeachClass();
            teachClass.SubjectID = subjectId;
            teachClass.TeacherID = teacherId;
            teachClass.StudentClass = studentClass;
            db.TeachClasses.Add(teachClass);
            db.SaveChanges();
        }
    }
}
