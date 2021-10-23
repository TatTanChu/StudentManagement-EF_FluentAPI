using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Point
    {
        public DTO_Point()
        {

        }

        public DTO_Point(DataRow row)
        {
            this.StudentID = (int)row["StudentID"];
            this.SubjectID = row["SubjectID"].ToString();
            this.Point = (float)Convert.ToDouble(row["Point"].ToString());
            this.Block = (int)row["Block"];
        }

        public int StudentID { get; set; }

        public string SubjectID { get; set; }

        public float Point { get; set; }

        public int Block { get; set; }

        //RELATIONSHIPS : 

        public virtual DTO_Student Student { get; set; }

        public virtual DTO_Subject Subject { get; set; }

    }

}
