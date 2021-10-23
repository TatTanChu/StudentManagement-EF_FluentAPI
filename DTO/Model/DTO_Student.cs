using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Student
    {

        public DTO_Student()
        {
            this.Points = new HashSet<DTO_Point>();
        }

        public DTO_Student(int studentId, string studentName, DateTime dateOfBirth, string gender, string address, string email, string studentClass)
        {
            this.StudentID = studentId;
            this.StudentName = studentName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Email = email;
            this.Class = studentClass;
        }

        public DTO_Student(DataRow row)
        {
            this.StudentID = (int)row["StudentID"];
            this.StudentName = row["Student Name"].ToString();
            this.DateOfBirth = (DateTime?)row["DateOfBirth"];
            this.Gender = row["Gender"].ToString();
            this.Address = row["Address"].ToString();
            this.Email = row["EmaiL"].ToString();
            this.Class = row["Class"].ToString();
        }

        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Class { get; set; }

        //RELATIONSHIPS : 

        public virtual DTO_Class _Class { get; set; }

        public virtual ICollection<DTO_Point> Points { get; set; }

        public virtual DTO_StudentAccount StudentAccount { get; set; }
    }

    
}
