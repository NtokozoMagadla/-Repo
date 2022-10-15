using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessLayer
{
    public class Rental
    {
        public int RentalID { get; set; }
        public string PropertyTenantID { get; set; }
        public string TenantID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
 }