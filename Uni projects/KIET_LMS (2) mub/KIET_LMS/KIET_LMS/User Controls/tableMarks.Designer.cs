namespace KIET_LMS.User_Controls
{
    partial class tableMarks
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
            this.sid = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Sno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.marks = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.BackColor = System.Drawing.Color.Transparent;
            this.sid.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.sid.Location = new System.Drawing.Point(570, 15);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(71, 32);
            this.sid.TabIndex = 1;
            this.sid.Text = "65119";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.name.Location = new System.Drawing.Point(100, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 32);
            this.name.TabIndex = 2;
            this.name.Text = "Rida Shakeel";
            // 
            // Sno
            // 
            this.Sno.AutoSize = true;
            this.Sno.BackColor = System.Drawing.Color.Transparent;
            this.Sno.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.Sno.Location = new System.Drawing.Point(18, 16);
            this.Sno.Name = "Sno";
            this.Sno.Size = new System.Drawing.Size(27, 32);
            this.Sno.TabIndex = 3;
            this.Sno.Text = "1.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.marks);
            this.panel3.Location = new System.Drawing.Point(657, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 46);
            this.panel3.TabIndex = 6;
            // 
            // marks
            // 
            this.marks.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.marks.Location = new System.Drawing.Point(15, 11);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(66, 32);
            this.marks.TabIndex = 4;
            // 
            // tableMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Sno);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name = "tableMarks";
            this.Size = new System.Drawing.Size(754, 63);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel3;
        public Label name;
        public Label sid;
        public Label Sno;
        public TextBox marks;
    }
}
