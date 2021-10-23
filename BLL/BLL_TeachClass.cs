using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TeachClass
    {
        DAL_TeachClass dal; 

        public BLL_TeachClass()
        {
            dal = new DAL_TeachClass();
        }

        //CREATE TEACHER CLASS :
        public void createTeachClass(string subjectId, int teacherId, string studentClass)
        {
            dal.createTeachClass(subjectId, teacherId, studentClass);
        }
    }
}
