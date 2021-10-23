using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Teacher
    {
        public DTO_Teacher()
        {
            this.TeachClasses = new HashSet<DTO_TeachClass>();
        }

        public DTO_Teacher(DataRow row)
        {
            this.TeacherID = (int)row["TeacherID"];
            this.TeacherName = row["TeacherName"].ToString();
            this.DateOfBirth = (DateTime?)row["DateOfBirth"];
            this.Gender = row["Gender"].ToString();
            this.Address = row["Address"].ToString();
            this.Email = row["Email"].ToString();
            this.Phone = (int)row["Phone"];
        }

        public int TeacherID { get; set; }

        public string TeacherName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        //RELATIONSHIP : 

        public virtual DTO_TeacherAccount TeacherAccount { get; set; }

        public virtual ICollection<DTO_TeachClass> TeachClasses { get; set; }
    }
}
