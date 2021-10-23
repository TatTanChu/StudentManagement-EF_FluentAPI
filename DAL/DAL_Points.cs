using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace DAL
{
    public class DAL_Points
    {
        DAL_DbContext db;

        public DAL_Points()
        {
            db = new DAL_DbContext();
        }

        //BLOCK POINT OF STUDENT : 
        public void blockPoint (string subjectId, string studentClass)
        {
            List<DTO_Student> showStudentList_NoPoint = (from students in db.Students
                                                        where students.Class == studentClass
                                                        select students
                                                        ).ToList();

            List<DTO_Point> pointsList = (from point in db.Points
                                          where point.SubjectID == subjectId
                                          select point
                                         ).ToList();

            foreach(DTO_Point point in pointsList)
            {
                foreach(DTO_Student student in showStudentList_NoPoint)
                {
                    if(point.StudentID == student.StudentID)
                    {
                        point.Block = 1;
                        break;
                    }    
                }    
            }    
            db.SaveChanges();
        }

        //UPDATE POINT OF STUDENT : 
        public void updatePoint(string subjectId, int studentId, float Point)
        {
            DTO_Point point = db.Points.Single( p => p.StudentID == studentId && p.SubjectID == subjectId );
            point.Point = Point;
            db.SaveChanges();
        }

        //CHECK BLOCK POINT : 
        public bool checkPoint(string subjectId, string studentClass)
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
                                                  select points.Block
                                                  ).ToList();
            
            foreach (int block in select_StudentLearnThisSubject)
            {
                if (block == 1)
                    return true;
            }
            return false;
        }

        //SHOW PONITS LIST OF ONE STUDENT : 
        public dynamic pointListOfOneStudent(int studentId)
        { 
            var point = (from points in db.Points
                         join subject in db.Subjects
                         on points.SubjectID equals subject.SubjectID
                         where points.StudentID == studentId
                         select new
                         {
                             subject.SubjectName,
                             points.SubjectID,
                             points.Point
                         }
                        ).ToList();
            return point;
        }

        //SHOW AVG POINT OF ONE STUDENT : 
        public float avgPoint(int studentId)
        {
            var pointList = (from points in db.Points
                         join subject in db.Subjects
                         on points.SubjectID equals subject.SubjectID
                         where points.StudentID == studentId
                         select new
                         {
                             points.Point
                         }
                        ).ToList();

            int sumOfSubjects = 0;
            float totalPointOfSubjects = 0;

            foreach(var point in pointList)
            {
                sumOfSubjects = sumOfSubjects + 1;
                totalPointOfSubjects = totalPointOfSubjects + point.Point;
            }

            float avg = (float)(totalPointOfSubjects / sumOfSubjects);

            return avg;
        }

        //SHOW POINT LIST : 
        public dynamic pointList(string subjectId, string studentClass)
        {
            var subjectList = (from list in db.Points
                               where list.SubjectID == subjectId
                               select new
                               {
                                   list.StudentID, 
                                   list.Point
                               }
                              ).ToList();

            var studentList = (from list in db.Students
                               where list.Class == studentClass
                               select new
                               { 
                                   list.StudentID,
                                   list.StudentName, 
                                   list.Gender, 
                                   list.Email
                               }
                              ).ToList();
            var pointList = (
                               from list_1 in subjectList
                               join list_2 in studentList
                               on list_1.StudentID equals list_2.StudentID
                               select new
                               {
                                   list_2.StudentID,
                                   list_2.StudentName,
                                   list_2.Gender,
                                   list_2.Email,
                                   list_1.Point
                               }
                            ).ToList();
            return pointList;
        }

        //UNBLOCK POINT OF STUDENT : 
        public void unBlockPoint(string subjectId, string studentClass)
        {
            List<DTO_Student> showStudentList_NoPoint = (from students in db.Students
                                                         where students.Class == studentClass
                                                         select students
                                                        ).ToList();

            List<DTO_Point> pointsList = (from point in db.Points
                                          where point.SubjectID == subjectId
                                          select point
                                         ).ToList();

            foreach (DTO_Point point in pointsList)
            {
                foreach (DTO_Student student in showStudentList_NoPoint)
                {
                    if (point.StudentID == student.StudentID)
                    {
                        point.Block = 0;
                        break;
                    }
                }
            }
            db.SaveChanges();
        }

        //POINT LIST BY TEACHER ID :
        public dynamic pointListByTeacherId()
        {
            var subjectList = (from list_1 in db.Subjects
                               join list_2 in db.Points
                               on list_1.SubjectID equals list_2.SubjectID
                               select new
                               {
                                   list_1.SubjectID,
                                   list_1.SubjectName
                               }
                              ).ToList();

            var teachClassList = (
                                    from list_1 in subjectList
                                    join list_2 in db.TeachClasses
                                    on list_1.SubjectID equals list_2.SubjectID    
                                    select new
                                    {
                                        list_1.SubjectID,
                                        list_1.SubjectName,
                                        list_2.StudentClass,
                                        list_2.TeacherID
                                    }
                                 ).Distinct().ToList();

            return teachClassList;
        }

        //POINT LIST BY TEACHER ID :
        public dynamic searchPointListByTeacherId(string searchString)
        {
            var subjectList = (from list_1 in db.Subjects
                               join list_2 in db.Points
                               on list_1.SubjectID equals list_2.SubjectID
                               select new
                               {
                                   list_1.SubjectID,
                                   list_1.SubjectName
                               }
                              ).ToList();

            var teachClassList = (
                                    from list_1 in subjectList
                                    join list_2 in db.TeachClasses
                                    on list_1.SubjectID equals list_2.SubjectID
                                    select new
                                    {
                                        list_1.SubjectID,
                                        list_1.SubjectName,
                                        list_2.StudentClass,
                                        list_2.TeacherID
                                    }
                                 ).Distinct().ToList();

            var searchPoint = (from list in teachClassList
                               where list.StudentClass.Contains(searchString) || list.TeacherID.ToString().Contains(searchString) || list.SubjectID.Contains(searchString) || list.SubjectName.Contains(searchString)
                               select new
                               {
                                   list.SubjectID,
                                   list.SubjectName,
                                   list.StudentClass,
                                   list.TeacherID
                               }
                             ).ToList();
            return searchPoint;
        }
    }
}
