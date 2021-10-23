using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Points
    {
        DAL_Points dal;

        public BLL_Points()
        {
            dal = new DAL_Points();
        }

        //BLOCK POINT OF STUDENT : 
        public void blockPoint(string subjectId, string studentClass)
        {
            dal.blockPoint(subjectId, studentClass);
        }

        //UPDATE POINT OF STUDENT : 
        public void updatePoint(string subjectId, int studentId, float Point)
        {
            dal.updatePoint(subjectId, studentId, Point);
        }

        //CHECK BLOCK POINT : 
        public bool checkPoint(string subjectId, string studentClass)
        {
            return dal.checkPoint(subjectId, studentClass);
        }

        //SHOW PONITS LIST OF ONE STUDENT : 
        public dynamic pointListOfOneStudent(int studentId)
        {
            return dal.pointListOfOneStudent(studentId);
        }

        //SHOW AVG POINT OF ONE STUDENT : 
        public float avgPoint(int studentId)
        {
            return dal.avgPoint(studentId);
        }


        //SHOW POINT LIST : 
        public dynamic pointList(string subjectId, string studentClass)
        {
            return dal.pointList(subjectId, studentClass);
        }

        //UNBLOCK POINT OF STUDENT : 
        public void unBlockPoint(string subjectId, string studentClass)
        {
            dal.unBlockPoint(subjectId, studentClass);
        }

        //POINT LIST BY TEACHER ID :
        public dynamic pointListByTeacherId()
        {
            return dal.pointListByTeacherId();
        }

        //POINT LIST BY TEACHER ID :
        public dynamic searchPointListByTeacherId(string searchString)
        {
            return dal.searchPointListByTeacherId(searchString);
        }
    }
}
