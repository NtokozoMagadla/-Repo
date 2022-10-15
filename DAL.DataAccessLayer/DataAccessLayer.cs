using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL.DataAccessLayer
{
    public class DataAccessLayer
    {
        static string connString = "Data Source=DESKTOP-VVG68F9;Initial Catalog=PropertiesDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int AddProvince(Provinces p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", p.Description);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetProvince", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddProperties(Property p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddProperties", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", p.Desc);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@Image", p.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", p.Status);
            dbComm.Parameters.AddWithValue("@SurbubID", p.SurbubID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateProperty(Property p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateProperties", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@Status", p.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable Property()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetProperties", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
     
        public int DeleteProperty(Property p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int AddPropertyAgent(PropertyAgent pa)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddPropertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdatePropertyAgent(PropertyAgent pa)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdatePropertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyAgent", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddRental(Rental r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTenantID", r.PropertyTenantID);
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue(@"EndDate", r.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateRental(Rental r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue(@"EndDate", r.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetRental", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddAgent(Agent a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAgent",dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            
            dbComm.Parameters.AddWithValue("@Name", a.Name);
            dbComm.Parameters.AddWithValue("@Surname", a.Surname);
            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Phone", a.Phone);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", a.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAgent(Agent a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int DeleteAgent(Agent a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", a.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int AddCity(City c)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddCities", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CityDescription", c.CityDesc);
            dbComm.Parameters.AddWithValue("@ProvinceID", c.ProvinceID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetCity()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetCities", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddPropertyType(PropertyType pt)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", pt.PropertyTypeDesc);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyType", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddSurbub(Surbub s)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SurbubDescription", s.SurbubDesc);
            dbComm.Parameters.AddWithValue("@PostalCode", s.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", s.CityID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSurbub()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetSurbub", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int AddAgency(Agency a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAgencies", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyName", a.AgencyName);
            dbComm.Parameters.AddWithValue("@SurbubID", a.SurbubID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgency()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAgency", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int DeleteAgency(Agency a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyID", a.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int AddTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            
            dbComm.Parameters.AddWithValue("@Name", t.Name);
            dbComm.Parameters.AddWithValue("@Surname", t.Surname);
            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Password", t.Password);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetTenant()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetTenant", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int DeleteTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", t.TenantID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable Login(string UserEmail, string UserPassword)
        {
            dbConn.Open();

            string sql = "sp_Login";

            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserEmail", UserEmail);
            dbComm.Parameters.AddWithValue("@UserPassword", UserPassword);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;


        }

        public DataTable GetUser()
        {
            dbConn.Open();

            string sql = "sp_Userr";

            dbComm = new SqlCommand(sql, dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;


        }

        public int SoftDelete(int UserrID)
        {
            dbConn.Open();

            string sql = "sp_SoftDelete";

            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserrID", UserrID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int HardtDelete(int UserrID)
        {
            dbConn.Open();

            string sql = "sp_HardDelete";

            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserrID", UserrID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int AddAdmin(Admin a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", a.Name);
            dbComm.Parameters.AddWithValue("@Surname", a.Surname);
            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Phone", a.Phone);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
    }
}
