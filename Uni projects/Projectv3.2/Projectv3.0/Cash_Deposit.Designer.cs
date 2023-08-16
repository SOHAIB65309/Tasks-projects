namespace Projectv3._0
{
    partial class Cash_Deposit
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
            this.Cash_Deposit_bx = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(99, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // Cash_Deposit_bx
            // 
            this.Cash_Deposit_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cash_Deposit_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash_Deposit_bx.ForeColor = System.Drawing.SystemColors.Info;
            this.Cash_Deposit_bx.Location = new System.Drawing.Point(131, 219);
            this.Cash_Deposit_bx.Name = "Cash_Deposit_bx";
            this.Cash_Deposit_bx.Size = new System.Drawing.Size(116, 31);
            this.Cash_Deposit_bx.TabIndex = 1;
            this.Cash_Deposit_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cash_Deposit_bx_KeyPress);
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(105, 277);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(188, 38);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "Confirm Deposit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Cash_Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectv3._0.Properties.Resources.ASRA_Banking__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Cash_Deposit_bx);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Cash_Deposit";
            this.Text = "Cash_Deposit";
            this.Load += new System.EventHandler(this.Cash_Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cash_Deposit_bx;
        private System.Windows.Forms.Button Submit_btn;
    }
}