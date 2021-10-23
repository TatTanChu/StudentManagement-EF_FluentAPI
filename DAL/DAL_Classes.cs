using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_Classes
    {
        DAL_DbContext db; 

        public DAL_Classes()
        {
            db = new DAL_DbContext(); 
        }

        //SHOW CLASS LIST FOR TEACHER : 
        public dynamic showClassListForTeacher(int teacherId)
        {

            var showList = (from teachClass in db.TeachClasses
                            join classes in db.Classes
                            on teachClass.StudentClass equals classes.StudentClass
                            where teachClass.TeacherID == teacherId
                            select new
                            {
                                classes.StudentClass,
                                classes.Quantity,
                                teachClass.SubjectID
                            }
                            ).ToList();


            var searchList = (from list in showList
                              join subjects in db.Subjects
                              on list.SubjectID equals subjects.SubjectID
                              select new
                              {
                                  list.StudentClass,
                                  list.SubjectID,
                                  subjects.SubjectName,
                                  list.Quantity
                              }
                              ).ToList();

            return searchList;
        }

        //SEARCH INFORMATION OF CLASS FOR TEACHER: 
        public dynamic searchClassForTeacher (int teacherId, string searchString)
        {
            var showList = (from teachClass in db.TeachClasses
                            join classes in db.Classes
                            on teachClass.StudentClass equals classes.StudentClass
                            where teachClass.TeacherID == teacherId
                            select new
                            {
                                classes.StudentClass,
                                classes.Quantity,
                                teachClass.SubjectID
                            }
                          ).ToList();


            var searchList = (from list in showList
                              join subjects in db.Subjects
                              on list.SubjectID equals subjects.SubjectID
                              select new
                              {
                                  list.StudentClass,
                                  list.SubjectID,
                                  subjects.SubjectName,
                                  list.Quantity
                              }
                              ).ToList();

            var searchClass = (from list in searchList
                               where list.SubjectName.Contains(searchString) || list.SubjectID.Contains(searchString) || 
                                     list.StudentClass.Contains(searchString) || list.Quantity == int.Parse(searchString)
                               select new
                               {
                                   list.StudentClass,
                                   list.SubjectID,
                                   list.SubjectName,
                                   list.Quantity
                               }
                               ).ToList();
            return searchClass;
        }

        //SHOW CLASS LIST : 
        public dynamic showClassList ()
        {
            var showClassList = (from Class in db.Classes
                                 select new
                                 {
                                     Class.StudentClass,
                                     Class.Quantity
                                 }
                                ).ToList();
            return showClassList;
        }

        //SEARCH CLASS : 
        public dynamic searchClass(string searchString)
        {
            var searchClass = (from list in db.Classes
                               where list.StudentClass.Contains(searchString) || list.Quantity.ToString().Contains(searchString)
                               select new
                               {
                                   list.StudentClass,
                                   list.Quantity
                               }
                               ).ToList();
            return searchClass;
        }

        //DELETE CLASS : 
        public void deleteClass(string studentClass)
        {
            var studentOfClass = from student in db.Students
                                 where student.Class == studentClass
                                 select student; 

            foreach(var student in studentOfClass)
            {
                student.Class = "0";
            }
            db.SaveChanges();

            var teacherTeachForThisClass = from teacher in db.TeachClasses
                                 where teacher.StudentClass == studentClass
                                 select teacher;

            foreach (var teacher in teacherTeachForThisClass)
            {
                db.TeachClasses.Remove(teacher);
            }
            db.SaveChanges();


            var Class = db.Classes.Single(c => c.StudentClass == studentClass);
            db.Classes.Remove(Class);
            db.SaveChanges();
        }

        //UPDATE CLASS INFOMATION :
        public void updateClassInfomation(string studentClass, int quantity)
        {
            var Class = db.Classes.Single(c => c.StudentClass == studentClass);
            Class.StudentClass = studentClass;
            Class.Quantity = quantity;
            db.SaveChanges();
        }

        //INSERT CLASS : 
        public void insertClass(string studentClass, int quantity)
        {
            DTO_Class Class = new DTO_Class();
            Class.StudentClass = studentClass;
            Class.Quantity = quantity;
            db.Classes.Add(Class);
            db.SaveChanges();
        }

        //SHOW NAME OF CLASS LIST :
        public dynamic showNameOfClassList()
        {
            var list = (from classes in db.Classes
                        select new { Class = classes.StudentClass }
                       ).ToList();
            return list;
        }

        //CHECK EXIST OF CLASS : 
        public bool checkExistOfClass(string studentClass)
        {
            var check = (from list in db.Classes
                         where list.StudentClass == studentClass
                         select list.StudentClass
                        ).ToList();

            return check.Count > 0;
        }
    }
}
