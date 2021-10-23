using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Subjects
    {
        DAL_DbContext db;
        public DAL_Subjects()
        {
            db = new DAL_DbContext();
        }

        //CHECK ESXIT OF SUBJECT : 
        public bool checkExistOfSubject(string subjectId)
        {
            var check = (from list in db.Subjects
                         where list.SubjectID == subjectId
                         select list.SubjectID
                        ).ToList();

            return check.Count > 0;
        }

        //UPDATE SUBJECT INFORMATION : 
        public void updateSubjectInfomation(string subjectId, string subjectName)
        {
            var subject = db.Subjects.Single(s => s.SubjectID == subjectId);
            subject.SubjectID = subjectId;
            subject.SubjectName = subjectName;
            db.SaveChanges(); 
        }

        //DELETE SUBJECT : 
        public void deleteSubject(string subjectId)
        {
            var thisSubject_teach_Class = from subject_1 in db.TeachClasses
                                         where subject_1.SubjectID == subjectId
                                         select subject_1;
            foreach (var detail in thisSubject_teach_Class)
            {
                db.TeachClasses.Remove(detail);
            }
            db.SaveChanges();

            var thisSubject_student_Points = from subject_2 in db.Points
                                             where subject_2.SubjectID == subjectId
                                             select subject_2;

            foreach (var detail in thisSubject_student_Points)
            {
                db.Points.Remove(detail);
            }
            db.SaveChanges();

            var subject = db.Subjects.Single(s => s.SubjectID == subjectId);
            db.Subjects.Remove(subject);
            db.SaveChanges();
        }

        //INSERT SUBJECT : 
        public void insertSubject(string subjectId, string subjectName)
        {
            DTO_Subject subject = new DTO_Subject();
            subject.SubjectID = subjectId;
            subject.SubjectName = subjectName;
            db.Subjects.Add(subject);
            db.SaveChanges();
        }

        //SUBJECT LIST : 
        public dynamic showListOfSubject()
        {
            var list = (
                        from subject in db.Subjects
                        select new
                        {
                            subject.SubjectID,
                            subject.SubjectName
                        }
                       ).ToList();
            return list;
        }

        //SEARCH SUBJECT : 
        public dynamic searchSubject(string searchString)
        {
            var searchSubject = (from list in db.Subjects
                               where list.SubjectID.Contains(searchString) || list.SubjectName.Contains(searchString)
                               select new
                               {
                                   list.SubjectID,
                                   list.SubjectName
                               }
                               ).ToList();
            return searchSubject;
        }

        //SHOW ID OF SUBJECT LIST : 
        public dynamic showIdOfSubjectList()
        {
            var list = (from subject in db.Subjects
                        select new { Subject = subject.SubjectID }
                       ).ToList();
            return list;
        }

        //SHOW NAME OF SUBJECT BY ID :
        public string showNameOfSubjectById(string subjectId)
        {
            var subjectName = (from subject in db.Subjects
                               where subject.SubjectID == subjectId
                               select subject.SubjectName
                              ).FirstOrDefault();
            return subjectName;
        }
    }
}
