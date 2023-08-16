namespace KIET_LMS.User_Controls
{
    partial class Student1
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
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Montserrat", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.name.Location = new System.Drawing.Point(3, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Mubashir Ahmed";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.id.Location = new System.Drawing.Point(165, 11);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(72, 27);
            this.id.TabIndex = 0;
            this.id.Text = "65097";
            // 
            // Student1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(139)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Student1";
            this.Size = new System.Drawing.Size(240, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label name;
        public Label id;
    }
}
