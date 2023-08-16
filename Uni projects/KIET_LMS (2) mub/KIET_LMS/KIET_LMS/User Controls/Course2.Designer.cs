namespace KIET_LMS.User_Controls
{
    partial class Course2
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
            this.id = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Montserrat", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.id.Location = new System.Drawing.Point(171, 1);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(110, 42);
            this.id.TabIndex = 3;
            this.id.Text = "110821";
            // 
            // course
            // 
            this.course.AllowDrop = true;
            this.course.AutoSize = true;
            this.course.BackColor = System.Drawing.Color.Transparent;
            this.course.Font = new System.Drawing.Font("Montserrat ExtraBold", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.course.Location = new System.Drawing.Point(-2, 73);
            this.course.Margin = new System.Windows.Forms.Padding(30);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(226, 119);
            this.course.TabIndex = 2;
            this.course.Text = "IICT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KIET_LMS.Properties.Resources.Group_188;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Course2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(113)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.course);
            this.Name = "Course2";
            this.Size = new System.Drawing.Size(279, 192);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        public Label id;
        public Label course;
    }
}
