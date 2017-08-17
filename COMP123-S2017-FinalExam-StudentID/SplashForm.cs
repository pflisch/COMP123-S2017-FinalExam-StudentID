using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:
 * Date:
 * StudentID:
 * Description:
 * Version:
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the SplashFormTimer's "Tick" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            this.Hide();
            Program.pickHighestCardForm.Show();
        }
    }
}
