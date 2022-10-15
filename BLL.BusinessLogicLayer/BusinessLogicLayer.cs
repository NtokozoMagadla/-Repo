using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL.DataAccessLayer;

namespace BLL.BusinessLogicLayer
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public int AddProvince(Provinces p)
        {
            return dal.AddProvince(p);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();   
        }

        public int AddProperties(Property p)
        {
            return dal.AddProperties(p);
        }
        public int UpdateProperty(Property p)
        {
            return dal.UpdateProperty(p);
        }
        public DataTable GetProperties()
        {
            return dal.Property();
        }
        public int DeleteProperty(Property p)
        {
            return dal.DeleteProperty(p);
        }

        public int AddPropertyAgent(PropertyAgent pa)
        {
            return dal.AddPropertyAgent(pa);
        }
        public int UpdatePropertyAgent(PropertyAgent pa)
        {
            return dal.UpdatePropertyAgent(pa);
        }
        public DataTable GetPropertyAgent()
        {
            return dal.GetPropertyAgent();
        }

        public int AddRental(Rental r)
        {
            return dal.AddRental(r);
        }
        public int UpdateRental(Rental r)
        {
            return dal.UpdateRental(r);
        }
        public DataTable GetRental()
        {
            return dal.GetRental();
        }

        public int AddAgent(Agent a)
        {
            return dal.AddAgent(a);
        }
        public int UpdateAgent(Agent a)
        {
            return dal.UpdateAgent(a);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public int DeleteAgent(Agent a)
        {
            return dal.DeleteAgent(a);
        }

        public int AddCity(City c)
        {
            return dal.AddCity(c);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }

        public int AddPropertyType(PropertyType pt)
        {
            return dal.AddPropertyType(pt);
        }
        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();

        }

        public int AddSurbub(Surbub s)
        {
            return dal.AddSurbub(s);
        }
        public DataTable GetSurbub()
        {
            return dal.GetSurbub();

        }

        public int AddAgency(Agency a)
        {
            return dal.AddAgency(a);
        }
        public DataTable GetAgency()
        {
            return dal.GetAgency();

        }
        public int DeleteAgency(Agency a)
        {
            return dal.DeleteAgency(a);
        }
        public int AddTenant(Tenant t)
        {
            return dal.AddTenant(t);
        }
        public int UpdateAgency(Tenant t)
        {
            return dal.AddTenant(t);
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();

        }
        public int  UpdateTenant(Tenant t)
        {
            return dal.UpdateTenant(t);
        }
        public int DeleteTenant(Tenant t)
        {
            return dal.DeleteTenant(t);
        }

        public DataTable Login(string UserEmail,string UserPassword)
        {
            return dal.Login(UserEmail, UserPassword);
        }

       public DataTable GetUser()
       {
            return dal.GetUser();
       }
       public int SoftDelete(int UserrID)
       {
            return dal.SoftDelete(UserrID);
       }
       public int HardDelete(int UserrID)
       {
            return dal.HardtDelete(UserrID);
       }
    }
}
