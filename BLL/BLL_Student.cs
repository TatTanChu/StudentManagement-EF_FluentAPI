using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO.Model;

namespace BLL
{
    public class BLL_Student
    {
        DAL_Student dal;

        public BLL_Student()
        {
            dal = new DAL_Student();
        }

        //CHECK STUDENT LOGIN : 
        public bool studentCheckLogin(int studentId, string password)
        {
            return dal.checkStudentLogin(studentId, password);
        }

        //GET INFORMATION OF ONE STUDENT : 
        public DTO_Student showStudentInfomation(int studentId)
        {
            return dal.showStudentInfomation(studentId);
        }

        //UPDATE INFOMATION OF ONE STUDENT : 

        public void updateStudentInfomation(int studentId, string gender, string address, DateTime dateOfBirth)
        {
            dal.updateStudentInfomation(studentId, gender, address, dateOfBirth);
        }

        //SHOW STUDENT LIST :
        public dynamic showStudentList(string studentClass, string subjectId)
        {
            return dal.showStudentList(studentClass, subjectId);
        }

        //INSERT STUDENT : 
        public void insertStudent(DTO_Student student)
        {
            dal.insertStudent(student);
        }

        //UPDATE STUDENT INFOMATION BY ADMIN : 
        public void updateStudentInfomationByAdmin(int studentId, string studentName, DateTime dateOfBirth, string gender, string address, string Class, string email)
        {
            dal.updateStudentInfomationByAdmin(studentId, studentName, dateOfBirth, gender, address, Class, email);
        }

        //DELETE STUDENT : 
        public void deleteStudent(int studentId)
        {
            dal.deleteStudent(studentId);
        }

        //CHECK EXIT STUDENT ID IN SYSTEM : 
        public bool checkStudentIdInSystem(int studentId)
        {
            return dal.checkStudentIdInSystem(studentId);
        }
    }
}
