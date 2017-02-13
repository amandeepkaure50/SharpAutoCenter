using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Auto_Center
{
   
    public static class Program
    {
        /// declared public static form -Application GLOBAL
        public static SplashForm MySplashForm ;

        /// declared public static form -Calculator Form
        public static SharpAutoCenterForm MySharpAutoCenterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///initilize SplashForm and SharpAutoCenterForm
            Program.MySplashForm = new SplashForm();
            Program.MySharpAutoCenterForm = new SharpAutoCenterForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
