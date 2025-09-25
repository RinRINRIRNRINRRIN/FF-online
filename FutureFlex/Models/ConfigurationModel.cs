using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFlex.Models
{
    public class ConfigurationModel
    {
        public string GetDocumentPO()
        {
            return ConfigurationManager.AppSettings["DocNumPO"];
        }


        public string GetDocumentJIT()
        {
            return ConfigurationManager.AppSettings["DocNumJIT"];
        }

        public string GetDocumentOdoo()
        {
            return ConfigurationManager.AppSettings["DocNumOdoo"];
        }


        public string GetDocumentHistory()
        {
            return ConfigurationManager.AppSettings["DocNumHistory"];
        }


        public string GetComportName()
        {
            return ConfigurationManager.AppSettings["WGH_COM"];
        }

        public string GetBaudrate()
        {
            return ConfigurationManager.AppSettings["WGH_BAUDRATE"];
        }

        public string GetIpServer()
        {
            return ConfigurationManager.AppSettings["IP_SERVER"];

        }

        public string GetHostServer()
        {
            return ConfigurationManager.AppSettings["SERVER_LOCAL"];
        }

        public int GetPortServer()
        {
            return int.Parse(ConfigurationManager.AppSettings["PORT_LOCAL"].ToString());
        }

        public string GetDbServer()
        {
            return ConfigurationManager.AppSettings["DB_LOCAL"];
        }

        public string GetUserServer()
        {
            return ConfigurationManager.AppSettings["USER_LOCAL"];
        }

        public string GetPasswordServer()
        {
            return ConfigurationManager.AppSettings["PASS_LOCAL"];
        }




    }
}
