using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Examination_Calculator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.ExitThread();
        }

        /// <summary>
        /// Go to CGPA Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cgpa Go_cgpa = new cgpa();
            Go_cgpa.ShowDialog();
        }

        /// <summary>
        /// Go to FINAL CALCULATOR Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fe_calculator final = new fe_calculator();
            final.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Do You Want To Exit Final Calculator Application?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
            else System.Windows.Forms.Application.ExitThread();

        }
    }
}
