using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Priscylla Flisch
 * Date: 17th Aug   
 * StudentID: 300931589
 * Description: Pick the Highest Card
 * Version: 0.01 - Final Exam
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        public static PickHighestCardForm pickHighestCardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
