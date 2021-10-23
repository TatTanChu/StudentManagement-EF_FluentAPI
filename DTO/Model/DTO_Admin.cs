using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class DTO_Admin
    {
        public DTO_Admin()
        {

        }

        public string AdminId { get; set; }

        public string AdminName { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        //RELATIONSHIPS : 
    }
}
