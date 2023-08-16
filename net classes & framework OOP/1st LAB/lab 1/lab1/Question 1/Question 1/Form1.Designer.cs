namespace Question_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSenior = new System.Windows.Forms.Button();
            this.btnjunior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seniour Or Jounior";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSenior
            // 
            this.BtnSenior.BackColor = System.Drawing.Color.Transparent;
            this.BtnSenior.ForeColor = System.Drawing.Color.Green;
            this.BtnSenior.Image = global::Question_1.Properties.Resources.studnt;
            this.BtnSenior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSenior.Location = new System.Drawing.Point(85, 169);
            this.BtnSenior.Name = "BtnSenior";
            this.BtnSenior.Size = new System.Drawing.Size(100, 23);
            this.BtnSenior.TabIndex = 1;
            this.BtnSenior.Text = "Senior Student";
            this.BtnSenior.UseVisualStyleBackColor = false;
            this.BtnSenior.Click += new System.EventHandler(this.BtnSenior_Click);
            // 
            // btnjunior
            // 
            this.btnjunior.BackColor = System.Drawing.Color.Transparent;
            this.btnjunior.ForeColor = System.Drawing.Color.Green;
            this.btnjunior.Image = global::Question_1.Properties.Resources.studnt;
            this.btnjunior.Location = new System.Drawing.Point(228, 169);
            this.btnjunior.Name = "btnjunior";
            this.btnjunior.Size = new System.Drawing.Size(100, 23);
            this.btnjunior.TabIndex = 2;
            this.btnjunior.Text = "Junior Student";
            this.btnjunior.UseVisualStyleBackColor = false;
            this.btnjunior.Click += new System.EventHandler(this.btnjunior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Question_1.Properties.Resources.theme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 273);
            this.Controls.Add(this.btnjunior);
            this.Controls.Add(this.BtnSenior);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSenior;
        private System.Windows.Forms.Button btnjunior;
    }
}

