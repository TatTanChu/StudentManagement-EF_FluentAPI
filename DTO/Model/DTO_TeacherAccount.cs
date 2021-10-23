using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_TeacherAccount
    {
        public DTO_TeacherAccount()
        {

        }

        public DTO_TeacherAccount(DataRow row)
        {
            this.TeacherID = (int)row["TeacherID"];
            this.Password = row["Password"].ToString(); 
        }

        public int TeacherID { get; set; }

        public string Password { get; set; }

        //RELATIONSHIP : 

        public virtual DTO_Teacher Teacher { get; set; }

    }
}
