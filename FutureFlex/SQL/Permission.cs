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
    internal class Permission
    {
        public Permission()
        {
            con = server.con;
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb = new DataTable();
        SqlCommand cmd = new SqlCommand();
        string sql = "";
        public List<PermissionModel> GetPermissionByEmployeeId(string employeeId)
        {
            List<PermissionModel> list = new List<PermissionModel>();
            try
            {
                sql = $"SELECT * FROM tbPrivilage WHERE pri_employeeID = '{employeeId}'";
                da = new SqlDataAdapter(sql, con);
                tb = new DataTable();
                da.Fill(tb);
                foreach (DataRow dr in tb.Rows)
                {
                    PermissionModel model = new PermissionModel();
                    model.Menu = dr["pri_menu"].ToString();
                    model.Add = bool.Parse(dr["pri_add"].ToString());
                    model.Edit = bool.Parse(dr["pri_edit"].ToString());
                    model.Delete = bool.Parse(dr["pri_del"].ToString());
                    list.Add(model);
                }
            }
            catch (Exception ex)
            {
                string className = ex.TargetSite.DeclaringType.Name;
                string methodName = ex.TargetSite.Name;
                Log.Error($"!! CLASS {className} METHOD {methodName} : {ex.Message}");
                return null;
            }
            return list;
        }



    }
}
