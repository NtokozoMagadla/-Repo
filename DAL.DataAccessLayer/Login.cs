using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessLayer
{
    public class Login
    {
        public int UserrID { get; set; }
        public string UserName {  get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserStaus { get; set; }
    }
}
