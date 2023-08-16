namespace KIET_LMS.User_Controls
{
    partial class Id_Creation
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
            this.cid = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.cid.Location = new System.Drawing.Point(24, 17);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(75, 26);
            this.cid.TabIndex = 0;
            this.cid.Text = "110877";
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.faculty.Location = new System.Drawing.Point(120, 17);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(103, 26);
            this.faculty.TabIndex = 0;
            this.faculty.Text = "Sir Saeed";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.time.Location = new System.Drawing.Point(368, 17);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(89, 26);
            this.time.TabIndex = 0;
            this.time.Text = "Sun(1st)";
            // 
            // Id_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.time);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.cid);
            this.Name = "Id_Creation";
            this.Size = new System.Drawing.Size(477, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label cid;
        public Label faculty;
        public Label time;
    }
}
