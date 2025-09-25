using FutureFlex.Models;
using Serilog;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FutureFlex.SQL
{
    public class tbOdoo
    {

        /// <summary>
        /// ดึงข้อมูลจากฐาน เพื่อเรียกใช้ odoo
        /// </summary>
        public static void defineServerOdoo()
        {
            try
            {
                Log.Information($"==== GET CONFIG ODOO API");
                SqlConnection con = SQL.server.con;
                string odooStatus = ConfigurationManager.AppSettings["ODOO_STATUS"];

                string sql = $"SELECT * FROM tbOdoo WHERE od_status = '{odooStatus}'";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                foreach (DataRow rw in tb.Rows)
                {
                    OdooModel.Key = rw["od_key"].ToString();
                    OdooModel.Server = rw["od_server"].ToString();
                    OdooModel.Database = rw["od_database"].ToString();
                    OdooModel.Status = rw["od_status"].ToString();
                    Log.Information($"-- key : {OdooModel.Key}");
                    Log.Information($"-- server : {OdooModel.Server}");
                    Log.Information($"-- db : {OdooModel.Database}");
                    break;
                }
            }
            catch (System.Exception ex)
            {
                string className = ex.TargetSite.DeclaringType.Name;
                string methodName = ex.TargetSite.Name;
                Log.Error($"!! CLASS {className} METHOD {methodName} : {ex.Message}");
            }
        }
    }
}

