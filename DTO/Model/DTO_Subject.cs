using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Subject
    {
        public DTO_Subject()
        {
            this.Points = new HashSet<DTO_Point>();
            this.TeachClasses = new HashSet<DTO_TeachClass>();
        }

        public DTO_Subject(DataRow row)
        {
            this.SubjectID = row["SubjectID"].ToString();
            this.SubjectName = row["SubjectName"].ToString();
        }

        public string SubjectID { get; set; }

        public string SubjectName { get; set; }

        //RELATIONSHIPS : 

        public virtual ICollection<DTO_Point> Points { get; set; }
        
        public virtual ICollection<DTO_TeachClass> TeachClasses { get; set; }
    }
}
