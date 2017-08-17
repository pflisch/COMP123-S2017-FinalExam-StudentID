using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        //Public Properties
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();

            Timer.Enabled = false; // turn timer off
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
