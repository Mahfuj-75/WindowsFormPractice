using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.Run(new Form1());


           //Register r=new Register();
           // r.Show();
           // //this.Hide();



        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();



    }
}
