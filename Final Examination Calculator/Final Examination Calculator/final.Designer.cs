namespace Final_Examination_Calculator
{
    partial class fe_calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fe_calculator));
            this.pic_grading = new System.Windows.Forms.PictureBox();
            this.lbl_grading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear_fcw = new System.Windows.Forms.Button();
            this.cmb_fcw = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear1 = new System.Windows.Forms.Button();
            this.txt_cw = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear2 = new System.Windows.Forms.Button();
            this.txt_expM = new System.Windows.Forms.TextBox();
            this.lbl_commentPass = new System.Windows.Forms.Label();
            this.lbl_commentExp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_grading)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_grading
            // 
            this.pic_grading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_grading.BackgroundImage")));
            this.pic_grading.Location = new System.Drawing.Point(12, 67);
            this.pic_grading.Name = "pic_grading";
            this.pic_grading.Size = new System.Drawing.Size(357, 329);
            this.pic_grading.TabIndex = 0;
            this.pic_grading.TabStop = false;
            // 
            // lbl_grading
            // 
            this.lbl_grading.AutoSize = true;
            this.lbl_grading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_grading.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grading.Location = new System.Drawing.Point(68, 9);
            this.lbl_grading.Name = "lbl_grading";
            this.lbl_grading.Size = new System.Drawing.Size(250, 47);
            this.lbl_grading.TabIndex = 1;
            this.lbl_grading.Text = "Grading System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 48);
            this.panel1.TabIndex = 2;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Yellow;
            this.btn_calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calculate.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_calculate.FlatAppearance.BorderSize = 3;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(773, 6);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(108, 39);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_back.FlatAppearance.BorderSize = 3;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(3, 6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_clear_fcw);
            this.groupBox1.Controls.Add(this.cmb_fcw);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(389, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Full Coursework In Percent (50% / 40%)";
            // 
            // btn_clear_fcw
            // 
            this.btn_clear_fcw.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear_fcw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_fcw.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_clear_fcw.FlatAppearance.BorderSize = 3;
            this.btn_clear_fcw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear_fcw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_fcw.Location = new System.Drawing.Point(369, 45);
            this.btn_clear_fcw.Name = "btn_clear_fcw";
            this.btn_clear_fcw.Size = new System.Drawing.Size(85, 27);
            this.btn_clear_fcw.TabIndex = 3;
            this.btn_clear_fcw.Text = "Clear";
            this.btn_clear_fcw.UseVisualStyleBackColor = false;
            this.btn_clear_fcw.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_fcw
            // 
            this.cmb_fcw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fcw.FormattingEnabled = true;
            this.cmb_fcw.Items.AddRange(new object[] {
            "50",
            "40"});
            this.cmb_fcw.Location = new System.Drawing.Point(23, 47);
            this.cmb_fcw.Name = "cmb_fcw";
            this.cmb_fcw.Size = new System.Drawing.Size(340, 27);
            this.cmb_fcw.TabIndex = 0;
            this.cmb_fcw.Text = "50";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_clear1);
            this.groupBox2.Controls.Add(this.txt_cw);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(389, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coursework Mark Obtained in Percent (%)";
            // 
            // btn_clear1
            // 
            this.btn_clear1.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_clear1.FlatAppearance.BorderSize = 3;
            this.btn_clear1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear1.Location = new System.Drawing.Point(369, 41);
            this.btn_clear1.Name = "btn_clear1";
            this.btn_clear1.Size = new System.Drawing.Size(85, 27);
            this.btn_clear1.TabIndex = 2;
            this.btn_clear1.Text = "Clear";
            this.btn_clear1.UseVisualStyleBackColor = false;
            this.btn_clear1.Click += new System.EventHandler(this.btn_clear1_Click);
            // 
            // txt_cw
            // 
            this.txt_cw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cw.Location = new System.Drawing.Point(23, 41);
            this.txt_cw.Name = "txt_cw";
            this.txt_cw.Size = new System.Drawing.Size(340, 27);
            this.txt_cw.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_clear2);
            this.groupBox3.Controls.Add(this.txt_expM);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(389, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 91);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expected Mark in Percent (Refer Grading System)";
            // 
            // btn_clear2
            // 
            this.btn_clear2.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_clear2.FlatAppearance.BorderSize = 3;
            this.btn_clear2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear2.Location = new System.Drawing.Point(369, 38);
            this.btn_clear2.Name = "btn_clear2";
            this.btn_clear2.Size = new System.Drawing.Size(85, 27);
            this.btn_clear2.TabIndex = 4;
            this.btn_clear2.Text = "Clear";
            this.btn_clear2.UseVisualStyleBackColor = false;
            this.btn_clear2.Click += new System.EventHandler(this.btn_clear2_Click);
            // 
            // txt_expM
            // 
            this.txt_expM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expM.Location = new System.Drawing.Point(23, 38);
            this.txt_expM.Name = "txt_expM";
            this.txt_expM.Size = new System.Drawing.Size(340, 27);
            this.txt_expM.TabIndex = 3;
            // 
            // lbl_commentPass
            // 
            this.lbl_commentPass.AutoSize = true;
            this.lbl_commentPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_commentPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_commentPass.Location = new System.Drawing.Point(386, 326);
            this.lbl_commentPass.Name = "lbl_commentPass";
            this.lbl_commentPass.Size = new System.Drawing.Size(12, 16);
            this.lbl_commentPass.TabIndex = 6;
            this.lbl_commentPass.Text = " ";
            // 
            // lbl_commentExp
            // 
            this.lbl_commentExp.AutoSize = true;
            this.lbl_commentExp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_commentExp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_commentExp.Location = new System.Drawing.Point(386, 360);
            this.lbl_commentExp.Name = "lbl_commentExp";
            this.lbl_commentExp.Size = new System.Drawing.Size(12, 16);
            this.lbl_commentExp.TabIndex = 7;
            this.lbl_commentExp.Text = " ";
            // 
            // fe_calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.lbl_commentExp);
            this.Controls.Add(this.lbl_commentPass);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_grading);
            this.Controls.Add(this.pic_grading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fe_calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Exam Calculator ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fe_calculator_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_grading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_grading;
        private System.Windows.Forms.Label lbl_grading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear1;
        private System.Windows.Forms.TextBox txt_cw;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_clear2;
        private System.Windows.Forms.TextBox txt_expM;
        private System.Windows.Forms.Label lbl_commentPass;
        private System.Windows.Forms.Button btn_clear_fcw;
        private System.Windows.Forms.ComboBox cmb_fcw;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_commentExp;
    }
}

