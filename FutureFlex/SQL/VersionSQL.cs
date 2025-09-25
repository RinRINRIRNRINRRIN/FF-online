using FutureFlex.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFlex.SQL
{
    public class VersionSQL
    {

        public string ERR;


        /// <summary>
        /// Check the version program
        /// </summary>
        /// <returns></returns>
        public bool CheckVersoin()
        {
            try
            {
                SqlConnection con = server.con;
                string query = "SELECT * FROM tbSystem";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                VersionModel versionModel = new VersionModel();
                foreach (DataRow dr in tb.Rows)
                {
                    string version = versionModel.GetFullVersion();
                    if (version != dr["version"].ToString())
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                ERR = ex.Message;
                string className = ex.TargetSite.DeclaringType.Name;
                string methodName = ex.TargetSite.Name;
                Log.Error($"!! CLASS {className} METHOD {methodName} : {ex.Message}");
                return false;
            }
            return true;
        }

    }
}