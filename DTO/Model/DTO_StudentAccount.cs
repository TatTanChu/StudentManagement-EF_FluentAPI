using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_StudentAccount
    {
        public DTO_StudentAccount()
        {

        }

        public DTO_StudentAccount(DataRow row)
        {
            this.StudentID = (int)row["StudentID"];
            this.Password = row["Password"].ToString();
        }

        public int StudentID { get; set; }

        public string Password { get; set; }

        //RELATIONSHIPS : 

        public virtual DTO_Student Student { get; set; }
    }

}
