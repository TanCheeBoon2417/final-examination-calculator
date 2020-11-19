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
    public partial class cgpa : Form
    {
        #region
        /// <summary>
        /// Variables
        /// </summary>
        String lettergrd;
        double credit;
        double caltimes = 0;
        double totalcal = 0;
        double totalcredit = 0;
        double finalgpa = 0;
        double APLUS = 4.0000;
        double A = 4.0000;
        double AMINUS = 3.6700;
        double BPLUS = 3.3300;
        double B = 3.000;
        double BMINUS = 2.6700;
        double CPLUS = 2.3300;
        double C = 2.0000;
        double F = 0.0000;
        double points = 0;
        string crc;
        string tc;
        double tp = 0;
        double tcre = 0;
        double finalcgpa = 0;
        //declaring combobox object
        ComboBox defaultcombo = new ComboBox();
        //declaring NumericUpDown object
        NumericUpDown defaultnumeric = new NumericUpDown();
        //declaring TextBox Object
        TextBox crrcgpa = new TextBox();
        TextBox tchr = new TextBox();
        #endregion

        public cgpa()
        {
            InitializeComponent();
        }

        private void cgpa_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e) // Exit Button
        {
            this.Hide();
            main MainPage = new main();
            MainPage.ShowDialog();
        }

        /// <summary>
        /// Reset Button - Reset All Inputs in the textbox or combo-box or numeric list
        /// </summary>
        private void resetAll() {
            txt_cgpa.Text = "";
            txt_gpa.Text = "";
            txt_currrentGPA.Text = "";
            txt_CreditHour.Text = "";
            cmb_course1.Text = "";
            cmb_course2.Text = "";
            cmb_course3.Text = "";
            cmb_course4.Text = "";
            cmb_course5.Text = "";
            cmb_course6.Text = "";
            cmb_course7.Text = "";
            cmb_course8.Text = "";
            cmb_course9.Text = "";
            numUp_course1.Value = 0;
            numUp_course2.Value = 0;
            numUp_course3.Value = 0;
            numUp_course4.Value = 0;
            numUp_course5.Value = 0;
            numUp_course6.Value = 0;
            numUp_course7.Value = 0;
            numUp_course8.Value = 0;
            numUp_course9.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetAll();
            txt_currrentGPA.Focus();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //sound a beep
                Console.Beep(650, 700);
                lettergrd = "";
                credit = 0;
                caltimes = 0;
                totalcal = 0;
                totalcredit = 0;
                finalgpa = 0;
                defaultcombo = new ComboBox();
                defaultnumeric = new NumericUpDown();
                points = 0;
                crrcgpa = new TextBox();
                tchr = new TextBox();
                for (int i = 0; i < 10; i++)
                {

                    switch (i)
                    {
                        case 1:
                            defaultcombo = cmb_course1;
                            defaultnumeric = numUp_course1;
                            break;
                        case 2:
                            defaultcombo = cmb_course2;
                            defaultnumeric = numUp_course2;
                            break;
                        case 3:
                            defaultcombo = cmb_course3;
                            defaultnumeric = numUp_course3;
                            break;
                        case 4:
                            defaultcombo = cmb_course4;
                            defaultnumeric = numUp_course4;
                            break;
                        case 5:
                            defaultcombo = cmb_course5;
                            defaultnumeric = numUp_course5;
                            break;
                        case 6:
                            defaultcombo = cmb_course6;
                            defaultnumeric = numUp_course6;
                            break;
                        case 7:
                            defaultcombo = cmb_course7;
                            defaultnumeric = numUp_course7;
                            break;
                        case 8:
                            defaultcombo = cmb_course8;
                            defaultnumeric = numUp_course8;
                            break;
                        case 9:
                            defaultcombo = cmb_course9;
                            defaultnumeric = numUp_course9;
                            break;
                        
                    }

                    lettergrd = defaultcombo.Text;
                    credit = Double.Parse(defaultnumeric.Value.ToString());


                    if (lettergrd != String.Empty && credit != 0)
                    {

                        switch (lettergrd)
                        {
                            case "A+":
                                caltimes = credit * APLUS;
                                break;
                            case "A":
                                caltimes = credit * A;
                                break;
                            case "A-":
                                caltimes = credit * AMINUS;
                                break;
                            case "B+":
                                caltimes = credit * BPLUS;
                                break;
                            case "B":
                                caltimes = credit * B;
                                break;
                            case "B-":
                                caltimes = credit * BMINUS;
                                break;
                            case "C+":
                                caltimes = credit * CPLUS;
                                break;
                            case "C":
                                caltimes = credit * C;
                                break;
                            case "F":
                                caltimes = credit * F;
                                break;

                        }

                        totalcredit = totalcredit + credit;
                        totalcal = totalcal + caltimes;
                    }

                }
                // calcuylating gpa
                finalgpa = totalcal / totalcredit;
                txt_gpa.Text = finalgpa.ToString("#.0000");

                crc = txt_currrentGPA.Text;
                tc = txt_CreditHour.Text;
                double crcg = Convert.ToDouble(crc);
                double tcr = Convert.ToDouble(tc);
                points = crcg * tcr;
                tp = points + totalcal;
                tcre = tcr + totalcredit;
                finalcgpa = tp / tcre;
                txt_cgpa.Text = finalcgpa.ToString("#.0000");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No data to process the calculation. Please Try Again");
            }
        }
    }
}
