using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model; 

namespace DAL
{
    public class DAL_Teacher
    {
        DAL_DbContext db = new DAL_DbContext(); 

        public DAL_Teacher()
        {
            db = new DAL_DbContext();   
        }

        //CHECK LOGIN OF A TEACHER : 
        public bool checkLoginOfTeacher(int teacherId, string password)
        {
            var checkLogin = (from t in db.TeacherAccount
                              where t.TeacherID == teacherId && t.Password == password
                              select t.TeacherID).ToList();

            return checkLogin.Count > 0;
        }

        //SHOW TEACHER INFORMATION : 
        public DTO_Teacher showTeacherInfomation(int teacherId)
        {
            DTO_Teacher teacher = new DTO_Teacher();

            var showInfo = (from t in db.Teachers
                            where t.TeacherID == teacherId
                            select new
                            {
                                t.TeacherName,
                                t.Address,
                                t.DateOfBirth,
                                t.Email,
                                t.Gender,
                                t.Phone
                            }).ToList(); 

            foreach(var item in showInfo)
            {
                teacher.TeacherName = item.TeacherName;
                teacher.Address = item.Address;
                teacher.DateOfBirth = item.DateOfBirth;
                teacher.Email = item.Email;
                teacher.Gender = item.Gender;
                teacher.Phone = item.Phone;
            }
            teacher.TeacherID = teacherId;
            return teacher;

        }

        //UPDATE TEACHER INFORMATION : 
        public void updateTeacherInfomation(int teacherId, DateTime dateOfBirth, string address, string gender, string email, int phone)
        {
            DTO_Teacher teacher = db.Teachers.Single(t => t.TeacherID == teacherId);
            teacher.DateOfBirth = dateOfBirth;
            teacher.Address = address;
            teacher.Gender = gender;
            teacher.Email = email;
            teacher.Phone = phone;

            db.SaveChanges();
        }

        //UPDATE TEACHER INFORMATION BY ADMIN: 
        public void updateTeacherInfomationByAdmin(int teacherId, DateTime dateOfBirth, string address, string gender, string email, int phone, string teacherName)
        {
            DTO_Teacher teacher = db.Teachers.Single(t => t.TeacherID == teacherId);
            teacher.DateOfBirth = dateOfBirth;
            teacher.Address = address;
            teacher.Gender = gender;
            teacher.Email = email;
            teacher.Phone = phone;
            teacher.TeacherName = teacherName;

            db.SaveChanges();
        }

        //CHECK EXIST OF TEACHER 
        public bool checkExistOfTeacher(int teacherId)
        {
            var check = (from list in db.Teachers
                         where list.TeacherID == teacherId
                         select list).ToList();
            return check.Count > 0;
        }

        //DELETE TEACHER : 
        public void deleteTeacher(int teacherId)
        {
            var teach_Class = from tea_Class in db.TeachClasses
                              where tea_Class.TeacherID == teacherId
                              select tea_Class;
            foreach (var detail in teach_Class)
            {
                db.TeachClasses.Remove(detail);
            }
            db.SaveChanges();

            var teacher_Account = db.TeacherAccount.Single(stc => stc.TeacherID == teacherId);
            db.TeacherAccount.Remove(teacher_Account);
            db.SaveChanges();

            var teacher = db.Teachers.Single(c => c.TeacherID == teacherId);
            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }

        //INSERT TEACHER : 
        public void insertTeacher (DTO_Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
        }

        //SHOW ID OF TEACHER LIST : 
        public dynamic showIdOfTeacherList()
        {
            var list = (from teacher in db.TeachClasses
                        select new { Teacher = teacher.TeacherID }
                        ).ToList();
            return list;
        }

        //SHOW NAME OF TEACHER BY ID :
        public string showNameOfTeacherById(int teacherId)
        {
            var teacherName = (from teacher in db.Teachers
                               where teacher.TeacherID == teacherId
                               select teacher.TeacherName
                              ).FirstOrDefault();
            return teacherName;
        }
    }
}
