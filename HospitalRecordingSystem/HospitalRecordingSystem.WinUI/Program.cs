using HospitalRecordingSystem.WinUI.Forms;
using System;
using System.Windows.Forms;

namespace HospitalRecordingSystem.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSignInAndSignUp());
           // Application.Run(new DoctorMainForm());
        }
    }
}
