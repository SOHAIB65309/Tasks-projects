namespace Projectv3._0
{
    partial class Online_Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Payment_bx = new System.Windows.Forms.TextBox();
            this.Payment_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_Payment_bx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(158, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Online Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Amount";
            // 
            // Payment_bx
            // 
            this.Payment_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Payment_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_bx.Location = new System.Drawing.Point(221, 221);
            this.Payment_bx.Name = "Payment_bx";
            this.Payment_bx.Size = new System.Drawing.Size(118, 22);
            this.Payment_bx.TabIndex = 3;
            this.Payment_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payment_bx_KeyPress);
            // 
            // Payment_btn
            // 
            this.Payment_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Payment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_btn.ForeColor = System.Drawing.Color.LawnGreen;
            this.Payment_btn.Location = new System.Drawing.Point(232, 259);
            this.Payment_btn.Name = "Payment_btn";
            this.Payment_btn.Size = new System.Drawing.Size(94, 32);
            this.Payment_btn.TabIndex = 4;
            this.Payment_btn.Text = "Pay Now";
            this.Payment_btn.UseVisualStyleBackColor = false;
            this.Payment_btn.Click += new System.EventHandler(this.Payment_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Name Of Payment";
            // 
            // Name_Payment_bx
            // 
            this.Name_Payment_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name_Payment_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Payment_bx.Location = new System.Drawing.Point(220, 187);
            this.Name_Payment_bx.Name = "Name_Payment_bx";
            this.Name_Payment_bx.Size = new System.Drawing.Size(118, 22);
            this.Name_Payment_bx.TabIndex = 6;
            this.Name_Payment_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Payment_bx_KeyPress);
            // 
            // Online_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectv3._0.Properties.Resources.ASRA_Banking__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 407);
            this.Controls.Add(this.Name_Payment_bx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Payment_btn);
            this.Controls.Add(this.Payment_bx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Online_Payment";
            this.Text = "Online_Payment";
            this.Load += new System.EventHandler(this.Online_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Payment_bx;
        private System.Windows.Forms.Button Payment_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_Payment_bx;
    }
}