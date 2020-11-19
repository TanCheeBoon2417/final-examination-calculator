namespace Final_Examination_Calculator
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.final_group = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proceed_final = new System.Windows.Forms.Button();
            this.cgpa_group = new System.Windows.Forms.GroupBox();
            this.decs_cgpa = new System.Windows.Forms.Label();
            this.btn_cgpa_proceed = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.final_group.SuspendLayout();
            this.cgpa_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(683, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 39);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.final_group);
            this.panel3.Controls.Add(this.cgpa_group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(368, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 402);
            this.panel3.TabIndex = 2;
            // 
            // final_group
            // 
            this.final_group.AutoSize = true;
            this.final_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.final_group.Controls.Add(this.label1);
            this.final_group.Controls.Add(this.btn_proceed_final);
            this.final_group.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_group.Location = new System.Drawing.Point(12, 200);
            this.final_group.Name = "final_group";
            this.final_group.Size = new System.Drawing.Size(408, 196);
            this.final_group.TabIndex = 1;
            this.final_group.TabStop = false;
            this.final_group.Text = "Final Examination Mark Prediction Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "- To estimate the marks obtained by students to get PASS or MORE \r\n   HIGHER\r\n- G" +
    "rading system preview \r\n";
            // 
            // btn_proceed_final
            // 
            this.btn_proceed_final.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_proceed_final.BackgroundImage")));
            this.btn_proceed_final.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed_final.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_proceed_final.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_proceed_final.FlatAppearance.BorderSize = 3;
            this.btn_proceed_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceed_final.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed_final.Location = new System.Drawing.Point(3, 161);
            this.btn_proceed_final.Name = "btn_proceed_final";
            this.btn_proceed_final.Size = new System.Drawing.Size(402, 32);
            this.btn_proceed_final.TabIndex = 1;
            this.btn_proceed_final.Text = "Proceed";
            this.btn_proceed_final.UseVisualStyleBackColor = true;
            this.btn_proceed_final.Click += new System.EventHandler(this.button3_Click);
            // 
            // cgpa_group
            // 
            this.cgpa_group.AutoSize = true;
            this.cgpa_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cgpa_group.Controls.Add(this.decs_cgpa);
            this.cgpa_group.Controls.Add(this.btn_cgpa_proceed);
            this.cgpa_group.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_group.Location = new System.Drawing.Point(12, 10);
            this.cgpa_group.Name = "cgpa_group";
            this.cgpa_group.Size = new System.Drawing.Size(402, 175);
            this.cgpa_group.TabIndex = 0;
            this.cgpa_group.TabStop = false;
            this.cgpa_group.Text = "CGPA Calculator";
            // 
            // decs_cgpa
            // 
            this.decs_cgpa.AutoSize = true;
            this.decs_cgpa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decs_cgpa.Location = new System.Drawing.Point(16, 62);
            this.decs_cgpa.Name = "decs_cgpa";
            this.decs_cgpa.Size = new System.Drawing.Size(364, 32);
            this.decs_cgpa.TabIndex = 1;
            this.decs_cgpa.Text = "- CGPA is the average grade points obtained by students\r\n- To calculate the cumul" +
    "ative grade point average of student \r\n";
            // 
            // btn_cgpa_proceed
            // 
            this.btn_cgpa_proceed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cgpa_proceed.BackgroundImage")));
            this.btn_cgpa_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cgpa_proceed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cgpa_proceed.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_cgpa_proceed.FlatAppearance.BorderSize = 3;
            this.btn_cgpa_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cgpa_proceed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cgpa_proceed.Location = new System.Drawing.Point(3, 140);
            this.btn_cgpa_proceed.Name = "btn_cgpa_proceed";
            this.btn_cgpa_proceed.Size = new System.Drawing.Size(396, 32);
            this.btn_cgpa_proceed.TabIndex = 0;
            this.btn_cgpa_proceed.Text = "Proceed";
            this.btn_cgpa_proceed.UseVisualStyleBackColor = true;
            this.btn_cgpa_proceed.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_logo.BackgroundImage")));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(12, 61);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(338, 286);
            this.pic_logo.TabIndex = 3;
            this.pic_logo.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Examination Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.final_group.ResumeLayout(false);
            this.final_group.PerformLayout();
            this.cgpa_group.ResumeLayout(false);
            this.cgpa_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cgpa_proceed;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.GroupBox final_group;
        private System.Windows.Forms.GroupBox cgpa_group;
        private System.Windows.Forms.Button btn_proceed_final;
        private System.Windows.Forms.Label decs_cgpa;
        private System.Windows.Forms.Label label1;
    }
}