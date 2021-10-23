using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO.Model;

namespace BLL
{
    public class BLL_Subjects
    {
        DAL_Subjects dal;
        public BLL_Subjects()
        {
            dal = new DAL_Subjects();
        }

        //CHECK ESXIT OF SUBJECT : 
        public bool checkExistOfSubject(string subjectId)
        {
            return dal.checkExistOfSubject(subjectId);
        }

        //UPDATE SUBJECT INFORMATION : 
        public void updateSubjectInfomation(string subjectId, string subjectName)
        {
            dal.updateSubjectInfomation(subjectId, subjectName);
        }

        //DELETE SUBJECT : 
        public void deleteSubject(string subjectId)
        {
            dal.deleteSubject(subjectId);
        }

        //INSERT SUBJECT : 
        public void insertSubject(string subjectId, string subjectName)
        {
            dal.insertSubject(subjectId, subjectName);
        }

        //SUBJECT LIST : 
        public dynamic showListOfSubject()
        {
            return dal.showListOfSubject();
        }

        //SEARCH SUBJECT : 
        public dynamic searchSubject(string searchString)
        {
            return dal.searchSubject(searchString);
        }

        //SHOW NAME OF SUBJECT LIST : 
        public dynamic showIdOfSubjectList()
        {
            return dal.showIdOfSubjectList();
        }

        //SHOW NAME OF SUBJECT BY ID :
        public string showNameOfSubjectById(string subjectId)
        {
            return dal.showNameOfSubjectById(subjectId);
        }
    }
}
