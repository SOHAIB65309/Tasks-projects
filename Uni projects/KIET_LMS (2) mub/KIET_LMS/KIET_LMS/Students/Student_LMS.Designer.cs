namespace KIET_LMS
{
    partial class Student_LMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_LMS));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classSchedule = new System.Windows.Forms.Button();
            this.selfRegistration = new System.Windows.Forms.Button();
            this.testResults = new System.Windows.Forms.Button();
            this.currentCourses = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showpanel = new System.Windows.Forms.Panel();
            this.show = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.classSchedule);
            this.panel1.Controls.Add(this.selfRegistration);
            this.panel1.Controls.Add(this.testResults);
            this.panel1.Controls.Add(this.currentCourses);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 746);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // classSchedule
            // 
            this.classSchedule.AutoSize = true;
            this.classSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.classSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.classSchedule.FlatAppearance.BorderSize = 0;
            this.classSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.classSchedule.Image = ((System.Drawing.Image)(resources.GetObject("classSchedule.Image")));
            this.classSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classSchedule.Location = new System.Drawing.Point(9, 383);
            this.classSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.classSchedule.Name = "classSchedule";
            this.classSchedule.Size = new System.Drawing.Size(279, 63);
            this.classSchedule.TabIndex = 4;
            this.classSchedule.Text = "    Class Schedule";
            this.classSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classSchedule.UseVisualStyleBackColor = false;
            this.classSchedule.Click += new System.EventHandler(this.classSchedule_Click);
            this.classSchedule.MouseHover += new System.EventHandler(this.selfRegistration_MouseHover);
            // 
            // selfRegistration
            // 
            this.selfRegistration.AutoSize = true;
            this.selfRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.selfRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selfRegistration.FlatAppearance.BorderSize = 0;
            this.selfRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selfRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.selfRegistration.Image = ((System.Drawing.Image)(resources.GetObject("selfRegistration.Image")));
            this.selfRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selfRegistration.Location = new System.Drawing.Point(9, 314);
            this.selfRegistration.Margin = new System.Windows.Forms.Padding(0);
            this.selfRegistration.Name = "selfRegistration";
            this.selfRegistration.Size = new System.Drawing.Size(279, 63);
            this.selfRegistration.TabIndex = 4;
            this.selfRegistration.Text = "    Self Registration";
            this.selfRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selfRegistration.UseVisualStyleBackColor = false;
            this.selfRegistration.Click += new System.EventHandler(this.selfRegistration_Click);
            this.selfRegistration.MouseHover += new System.EventHandler(this.selfRegistration_MouseHover);
            // 
            // testResults
            // 
            this.testResults.AutoSize = true;
            this.testResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.testResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testResults.FlatAppearance.BorderSize = 0;
            this.testResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.testResults.Image = ((System.Drawing.Image)(resources.GetObject("testResults.Image")));
            this.testResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testResults.Location = new System.Drawing.Point(22, 251);
            this.testResults.Margin = new System.Windows.Forms.Padding(0);
            this.testResults.Name = "testResults";
            this.testResults.Size = new System.Drawing.Size(279, 63);
            this.testResults.TabIndex = 4;
            this.testResults.Text = "    Test Results";
            this.testResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.testResults.UseVisualStyleBackColor = false;
            this.testResults.Click += new System.EventHandler(this.button2_Click);
            this.testResults.MouseHover += new System.EventHandler(this.selfRegistration_MouseHover);
            // 
            // currentCourses
            // 
            this.currentCourses.AutoSize = true;
            this.currentCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.currentCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.currentCourses.FlatAppearance.BorderSize = 0;
            this.currentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.currentCourses.Image = ((System.Drawing.Image)(resources.GetObject("currentCourses.Image")));
            this.currentCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentCourses.Location = new System.Drawing.Point(22, 182);
            this.currentCourses.Margin = new System.Windows.Forms.Padding(0);
            this.currentCourses.Name = "currentCourses";
            this.currentCourses.Size = new System.Drawing.Size(279, 63);
            this.currentCourses.TabIndex = 4;
            this.currentCourses.Text = "    Current Courses";
            this.currentCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.currentCourses.UseVisualStyleBackColor = false;
            this.currentCourses.Click += new System.EventHandler(this.currentCourses_Click);
            this.currentCourses.MouseHover += new System.EventHandler(this.selfRegistration_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(315, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Freehand", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "The redesigned Learning Platform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(0, -19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(166, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "KIET";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(134)))), ((int)(((byte)(56)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button4.Image = global::KIET_LMS.Properties.Resources.Icon_awesome_arrow_left;
            this.button4.Location = new System.Drawing.Point(792, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 33);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button5.Location = new System.Drawing.Point(834, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 33);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(134)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.showpanel);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 45);
            this.panel2.TabIndex = 8;
            // 
            // showpanel
            // 
            this.showpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.showpanel.Location = new System.Drawing.Point(3, 45);
            this.showpanel.Name = "showpanel";
            this.showpanel.Size = new System.Drawing.Size(879, 701);
            this.showpanel.TabIndex = 9;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show.Location = new System.Drawing.Point(315, 45);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(879, 701);
            this.show.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::KIET_LMS.Properties.Resources.Icon_metro_switch;
            this.button1.Location = new System.Drawing.Point(744, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 33);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 746);
            this.Controls.Add(this.show);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_LMS";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Student_LMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button classSchedule;
        private Button selfRegistration;
        private Button testResults;
        private Button currentCourses;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Panel showpanel;
        private Panel show;
        private Button button1;
    }
}