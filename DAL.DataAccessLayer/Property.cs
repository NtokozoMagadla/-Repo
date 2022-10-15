using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessLayer
{
    public class Property
    {
        public int PropertyID { get; set; }
        public string Desc { get; set; }    
        public double Price { get; set; }
        public string Image { get; set; }
        public string PropertyTypeID { get; set; }
        public string Status  { get; set; }
        public string SurbubID { get; set; }

    }
}
