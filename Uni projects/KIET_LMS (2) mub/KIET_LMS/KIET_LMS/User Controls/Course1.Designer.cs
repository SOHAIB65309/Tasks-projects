namespace KIET_LMS.User_Controls
{
    partial class Course1
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
            this.course = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course
            // 
            this.course.AllowDrop = true;
            this.course.AutoSize = true;
            this.course.BackColor = System.Drawing.Color.Transparent;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.course.Location = new System.Drawing.Point(-7, 78);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(210, 98);
            this.course.TabIndex = 0;
            this.course.Text = "IICT";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Montserrat", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.id.Location = new System.Drawing.Point(166, 6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(110, 42);
            this.id.TabIndex = 1;
            this.id.Text = "110821";
            // 
            // Course1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.Controls.Add(this.id);
            this.Controls.Add(this.course);
            this.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Name = "Course1";
            this.Size = new System.Drawing.Size(279, 192);
            this.Load += new System.EventHandler(this.Course1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label course;
        public Label id;
    }
}
