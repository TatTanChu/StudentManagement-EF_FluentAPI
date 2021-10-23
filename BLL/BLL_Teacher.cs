using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO.Model;

namespace BLL
{
    public class BLL_Teacher
    {
        DAL_Teacher dal;

        public BLL_Teacher()
        {
            dal = new DAL_Teacher();
        }

        //CHECK LOGIN OF A TEACHER : 
        public bool checkLoginOfTeacher(int teacherId, string password)
        {
            return dal.checkLoginOfTeacher(teacherId, password);
        }

        //SHOW INFORMATION OF TEACHER : 
        public DTO_Teacher showInformationOfTeacher(int teacherId)
        {
            return dal.showTeacherInfomation(teacherId);
        }

        //UPDATE INFORMATION OF A TEACHER : 
        public void updateTeacherInformation(int teacherId, DateTime dateOfBirth, string address, string gender, string email, int phone)
        {
            dal.updateTeacherInfomation(teacherId, dateOfBirth, address, gender, email, phone);
        }

        //UPDATE TEACHER INFORMATION BY ADMIN: 
        public void updateTeacherInfomationByAdmin(int teacherId, DateTime dateOfBirth, string address, string gender, string email, int phone, string teacherName)
        {
            dal.updateTeacherInfomationByAdmin(teacherId, dateOfBirth, address, gender, email, phone, teacherName);
        }

        //CHECK EXIST OF TEACHER 
        public bool checkExistOfTeacher(int teacherId)
        {
            return dal.checkExistOfTeacher(teacherId);
        }

        //DELETE TEACHER : 
        public void deleteTeacher(int teacherId)
        {
            dal.deleteTeacher(teacherId);
        }

        //INSERT TEACHER : 
        public void insertTeacher(DTO_Teacher teacher)
        {
            dal.insertTeacher(teacher);
        }

        //SHOW NAME OF TEACHER LIST : 
        public dynamic showIdOfTeacherList()
        {
            return dal.showIdOfTeacherList();
        }

        //SHOW NAME OF TEACHER BY ID :
        public string showNameOfTeacherById(int teacherId)
        {
            return dal.showNameOfTeacherById(teacherId);
        }
    }
}
