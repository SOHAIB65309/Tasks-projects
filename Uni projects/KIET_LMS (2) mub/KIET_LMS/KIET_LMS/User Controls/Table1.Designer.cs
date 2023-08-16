namespace KIET_LMS.User_Controls
{
    partial class Table1
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
            this.Sno = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sno
            // 
            this.Sno.AutoSize = true;
            this.Sno.BackColor = System.Drawing.Color.Transparent;
            this.Sno.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.Sno.Location = new System.Drawing.Point(21, 14);
            this.Sno.Name = "Sno";
            this.Sno.Size = new System.Drawing.Size(27, 32);
            this.Sno.TabIndex = 0;
            this.Sno.Text = "1.";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.name.Location = new System.Drawing.Point(103, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Rida Shakeel";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.BackColor = System.Drawing.Color.Transparent;
            this.sid.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.sid.Location = new System.Drawing.Point(649, 14);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(71, 32);
            this.sid.TabIndex = 0;
            this.sid.Text = "65119";
            // 
            // Table1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.sid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Sno);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Table1";
            this.Size = new System.Drawing.Size(733, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label Sno;
        public Label name;
        public Label sid;
    }
}
