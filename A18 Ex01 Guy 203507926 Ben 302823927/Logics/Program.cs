using System;
using System.Windows.Forms;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public static class Program
    {
        // $G$ RUL-006 (-80) Late submission (-2 days) 
        // $G$ THE-001 (-16) Your grade on diagrams document - 84. Please see comments inside the document.
        // $G$ SFN-001 (-15) The degree of investment in implementation of the application(facebook experience of your on, not like Guy's in class) was low.
        // $G$ SFN-003 (-10) The degree of investment in implementation of second feature was low.



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
