using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Class
    {
        public DTO_Class()
        {
            this.Students = new HashSet<DTO_Student>();
            this.TeachClasses = new HashSet<DTO_TeachClass>();
        }

        public DTO_Class(DataRow row)
        {
            this.StudentClass = row["StudentClass"].ToString();
            this.Quantity = (int)row["Quantity"];
        }

        public string StudentClass { get; set; }

        public int Quantity { get; set; }

        //RELATIONSHIPS : 

        public virtual ICollection<DTO_Student> Students { get; set; }

        public virtual ICollection<DTO_TeachClass> TeachClasses { get; set; }
    }
}
