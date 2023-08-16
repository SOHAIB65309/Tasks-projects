namespace KIET_LMS.User_Controls
{
    partial class Course4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.abb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.course = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crHour = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.abb);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 186);
            this.panel3.TabIndex = 3;
            // 
            // abb
            // 
            this.abb.AutoSize = true;
            this.abb.Font = new System.Drawing.Font("Montserrat ExtraBold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.abb.Location = new System.Drawing.Point(80, 23);
            this.abb.Name = "abb";
            this.abb.Size = new System.Drawing.Size(140, 65);
            this.abb.TabIndex = 4;
            this.abb.Text = "DCN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.course);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 86);
            this.panel1.TabIndex = 3;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.course.Location = new System.Drawing.Point(8, 14);
            this.course.MaximumSize = new System.Drawing.Size(276, 0);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(262, 52);
            this.course.TabIndex = 0;
            this.course.Text = "DataCommunication and Networking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.panel2.Controls.Add(this.crHour);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 41);
            this.panel2.TabIndex = 5;
            // 
            // crHour
            // 
            this.crHour.AutoSize = true;
            this.crHour.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.crHour.Location = new System.Drawing.Point(15, 2);
            this.crHour.MaximumSize = new System.Drawing.Size(276, 0);
            this.crHour.Name = "crHour";
            this.crHour.Size = new System.Drawing.Size(30, 33);
            this.crHour.TabIndex = 1;
            this.crHour.Text = "3";
            // 
            // Course4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Course4";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(283, 196);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Label abb;
        private Panel panel1;
        public Label course;
        private Panel panel2;
        public Label crHour;
        public Panel panel3;
    }
}
