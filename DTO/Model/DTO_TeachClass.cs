using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_TeachClass
    {
        public DTO_TeachClass()
        {

        }

        public DTO_TeachClass(DataRow row)
        {
            this.TeacherID = (int)row["TeacherID"];
            this.SubjectID = row["SubjectID"].ToString();
            this.StudentClass = row["StudentClass"].ToString();
        }

        public int TeacherID { get; set; }

        public string SubjectID { get; set; }

        public string StudentClass { get; set; }

        //RELATIONSHIPS : 

        public virtual DTO_Teacher Teacher { get; set; }

        public virtual DTO_Subject Subject { get; set; }

        public virtual DTO_Class Class { get; set; }
    }
}
