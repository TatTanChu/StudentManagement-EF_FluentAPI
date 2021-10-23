using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Classes
    {
        DAL_Classes dal;

        public BLL_Classes()
        {
            dal = new DAL_Classes();
        }

        //SHOW LIST CLASS FOR TEACHER: 
        public dynamic showClassListForTeacher(int teacherId)
        {
            return dal.showClassListForTeacher(teacherId);
        }

        //SEARCH INFORMATION OF CLASS FOR TEACHER: 
        public dynamic searchClassForTeacher(int teacherId, string searchString)
        {
            return dal.searchClassForTeacher(teacherId, searchString);
        }

        //SHOW CLASS LIST : 
        public dynamic showClassList()
        {
            return dal.showClassList();
        }

        //SEARCH CLASS : 
        public dynamic searchClass(string searchString)
        {
            return dal.searchClass(searchString);
        }

        //DELETE CLASS : 
        public void deleteClass(string studentClass)
        {
            dal.deleteClass(studentClass);
        }

        //UPDATE CLASS INFOMATION :
        public void updateClassInfomation(string studentClass, int quantity)
        {
            dal.updateClassInfomation(studentClass, quantity);
        }

        //INSERT CLASS : 
        public void insertClass(string studentClass, int quantity)
        {
            dal.insertClass(studentClass, quantity);
        }

        //SHOW NAME OF CLASS LIST :
        public dynamic showNameOfClassList()
        {
            return dal.showNameOfClassList();
        }

        //CHECK EXIST OF CLASS : 
        public bool checkExistOfClass(string studentClass)
        {
            return dal.checkExistOfClass(studentClass);
        }
    }
}
