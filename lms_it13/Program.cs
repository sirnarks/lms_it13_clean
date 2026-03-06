using System;
using System.Windows.Forms;

namespace lms_it13
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            ApplicationConfiguration.Initialize();
=======
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
>>>>>>> @{-1}
            Application.Run(new LoginForm());
        }
    }
}