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
    public partial class fe_calculator : Form
    {
        #region
        /// <summary>
        /// Variables
        /// </summary>
        public static double total_final = 100;// final exam total mark
        public static double pass_mark = 50; // pass grade mark
        public static double cw = 0; // coursework mark user obtained
        public static double fw_fourty = 40; // 40 percent type coursework
        public static double fw_fifty = 50; // 50 percent type coursework
        public static double expect_mark = 0; // expectation mark from user input
        public static double predict_mark = 0; // prediction for expectation mark
        public static double predict_PassMark = 0; // prediction for the mark need to be pass
        public static double result_pass = 0; // the mark that will be used to PASS
        public static double result_em = 0; // the mark that will be useed to approach to the expectation marks
        #endregion

        public fe_calculator()
        {
            InitializeComponent();
        }

        private void fe_calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        /// <summary>
        /// Reset function
        /// </summary>
        private void resetAll() {
            cmb_fcw.Text = "";
            txt_cw.Text = "";
            txt_expM.Text = "";
        }

        /// <summary>
        /// Calculate Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (txt_cw.Text == "" || txt_expM.Text == "" || cmb_fcw.Text == "")
            {
                MessageBox.Show("No input found in the textbox. Please Try Again.");
                resetAll();
                cmb_fcw.Focus();
            }
            else 
            {
                cw = Convert.ToDouble(txt_cw.Text);
                expect_mark = Convert.ToInt32(txt_expM.Text);
                result_pass = pass_mark - cw;
                result_em = expect_mark - cw;
                //Validation
                if (expect_mark > 100 || expect_mark <= 0)
                {
                    MessageBox.Show("Your Expected Marks is Out of Range. Please Try Again.");
                    resetAll();
                    cmb_fcw.Focus();
                }
                else
                {
                    if (fw_fourty == Convert.ToDouble(cmb_fcw.Text))
                    {
                        if (cw > 40 || cw <= 0)
                        {
                            MessageBox.Show("Error Input Coursework Mark Obtained. Please Try Again.");
                            resetAll();
                            cmb_fcw.Focus();
                        }
                        else
                        {
                            // Calculation for the 40% of Coursework marks SUBJECT
                            fw_fourty = 60; //Change Value into 60 
                            predict_mark = (result_em / fw_fourty) * total_final;
                            predict_PassMark = (result_pass / fw_fourty) * total_final;
                        }
                    }
                    else if (fw_fifty == Convert.ToDouble(cmb_fcw.Text))
                    {

                        if (cw > 50 || cw <= 0)
                        {
                            MessageBox.Show("Error Input Coursework Mark Obtained. Please Try Again.");
                            resetAll();
                            cmb_fcw.Focus();
                        }
                        else
                        {
                            // Calculation for the 50% of Coursework marks SUBJECT
                            predict_mark = (result_em / fw_fifty) * total_final;
                            predict_PassMark = (result_pass / fw_fifty) * total_final;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Input in the Full Coursework. Please Try Again.");
                        //Reset Function
                    }

                    //Validation for the Comment
                    if (predict_mark > 100 || predict_PassMark > 100)
                    {
                        MessageBox.Show("You have exceed 100 marks to obtained " + expect_mark + " %. Please lower down the value.");
                        resetAll();
                        cmb_fcw.Focus();
                    }
                    else {
                        //Calculation Performance for prediction AND Change Label Text
                        lbl_commentPass.Text = "Pass Mark : " + predict_PassMark + " marks to get PASS. ";
                        lbl_commentExp.Text = "You have to obtained " + predict_mark.ToString("#0.00") + " mark to obtain " + expect_mark + "%";
                    }
                }
            }

            
        }

        /// <summary>
        /// Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main MainMenu = new main();
            MainMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_fcw.Text = "";
            cmb_fcw.Focus();
        }

        private void btn_clear1_Click(object sender, EventArgs e)
        {
            txt_cw.Text = "";
            txt_cw.Focus();
        }

        private void btn_clear2_Click(object sender, EventArgs e)
        {
            txt_expM.Text = "";
            txt_expM.Focus();
        }
    }
}
