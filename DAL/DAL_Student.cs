using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_Student
    {
        DAL_DbContext db;
        DAL_DataProvider dataProvider;

        public DAL_Student()
        {
            db = new DAL_DbContext();
            dataProvider = new DAL_DataProvider();
        }

        //CHECK STUDENT LOGIN : 
        public bool checkStudentLogin(int studentId, string password)
        {
            var checkLogin = (from st in db.StudentAcccounts
                              where st.StudentID == studentId && st.Password == password
                              select st.StudentID).ToList();
          

            return checkLogin.Count > 0;
        }

        //SHOW INFORMATION OF A STUDENT : 
        public DTO_Student showStudentInfomation (int studentId)
        {
            DTO_Student student = new DTO_Student();

            var getInfo = (from st in db.Students
                           where st.StudentID == studentId
                           select new
                           {
                               st.StudentName,
                               st.DateOfBirth,
                               st.Address,
                               st.Email,
                               st.Gender,
                               st.Class
                            }).ToList();

            foreach (var item in getInfo)
            {
                student.StudentName = item.StudentName;
                student.Address = item.Address;
                student.Class = item.Class;
                student.DateOfBirth = item.DateOfBirth;
                student.Gender = item.Gender;
                student.Email = item.Email;
                break;
            }

            return student;
        }

        //UPDATE STUDENT INFOMATION : 
        public void updateStudentInfomation(int studentId, string gender, string address, DateTime dateOfBirth)
        {
            DTO_Student student = db.Students.Single(u => u.StudentID == studentId);
            student.Gender = gender;
            student.DateOfBirth = dateOfBirth;
            student.Address = address;
            db.SaveChanges(); 
        }

        //SHOW STUDENT LIST :
        public dynamic showStudentList(string studentClass, string subjectId)
        {
            var showStudentList_NoPoint = (from students in db.Students
                                           where students.Class == studentClass
                                           select new
                                           {
                                               students.StudentID,
                                               students.StudentName,
                                               students.Gender,
                                               students.Email
                                           }
                                           ).ToList();

            var select_StudentLearnThisSubject = (from students in showStudentList_NoPoint
                                                  join points in db.Points
                                                  on students.StudentID equals points.StudentID
                                                  where points.SubjectID == subjectId
                                                  select new
                                                  {
                                                      students.StudentID,
                                                      students.StudentName,
                                                      students.Gender,
                                                      students.Email,
                                                      points.Point
                                                  }
                                                 ).ToList();
            return select_StudentLearnThisSubject;
                                                 
        }

        //INSERT STUDENT : 
        public void insertStudent (DTO_Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        //UPDATE STUDENT INFOMATION BY ADMIN : 
        public void updateStudentInfomationByAdmin(int studentId, string studentName, DateTime dateOfBirth, string gender, string address, string Class, string email)
        {
            DTO_Student student = db.Students.Single(u => u.StudentID == studentId);
            student.StudentName = studentName;
            student.Class = Class;
            student.Email = email;
            student.Gender = gender;
            student.DateOfBirth = dateOfBirth;
            student.Address = address;
            db.SaveChanges();
        }

        //DELETE STUDENT : 
        public void deleteStudent(int studentId)
        {
            var student_Points = from points in db.Points
                                 where points.StudentID == studentId
                                 select points; 

            foreach(var detail in student_Points)
            {
                db.Points.Remove(detail);
            }
            db.SaveChanges();

            var student_Account = db.StudentAcccounts.Single(stc => stc.StudentID == studentId);
            db.StudentAcccounts.Remove(student_Account);
            db.SaveChanges();

            var student = db.Students.Single(c => c.StudentID == studentId);
            db.Students.Remove(student);
            db.SaveChanges();
        }

        //CHECK EXIST STUDENT ID IN SYSTEM : 
        public bool checkStudentIdInSystem(int studentId)
        {
            var check = (
                            from student in db.Students
                            where student.StudentID == studentId
                            select student.StudentID
                        ).ToList();
            return check.Count > 0;
        }
    }
}
