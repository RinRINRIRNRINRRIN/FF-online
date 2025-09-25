using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFlex.Models
{
    internal class VersionModel
    {


        private Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;


        public int GetMajor()
        {
            return version.Major;
        }


        public int GetMinor()
        {
            return version.Minor;
        }

        public int GetBuild()
        {
            return version.Build;
        }

        public string GetFullVersion()
        {
            Console.WriteLine($"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}");
            return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }


        public int GetRevision()
        {
            return version.Revision;
        }

        public string GetBuildDate()
        {
            // 🟢 ใช้ Build สำหรับคำนวณวันที่
            var buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);

            // 🟢 บังคับใช้ Calendar แบบ Gregorian (ค.ศ.)
            var culture = new System.Globalization.CultureInfo("en-US");
            culture.DateTimeFormat.Calendar = new System.Globalization.GregorianCalendar();

            string dateBuile = buildDate.ToString("yyyy-MM-dd HH:mm:ss", culture);
            Console.WriteLine(dateBuile);
            return dateBuile;
        }




    }
}
