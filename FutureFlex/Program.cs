using System;
using System.Windows.Forms;

namespace FutureFlex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show("Unhandled Exception: " + ex.Message);
                // log ลงไฟล์ได้ที่นี่
            };
            Application.ThreadException += (s, e) =>
            {
                MessageBox.Show("Thread Exception: " + e.Exception.Message);
                // log ลงไฟล์ได้ที่นี่
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}