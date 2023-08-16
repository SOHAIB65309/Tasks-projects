namespace Projectv3._0
{
    partial class Fund_Transfer
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
            this.Account_idtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Account_id_bx = new System.Windows.Forms.TextBox();
            this.Amount_bx = new System.Windows.Forms.TextBox();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Account_idtxt
            // 
            this.Account_idtxt.AutoSize = true;
            this.Account_idtxt.BackColor = System.Drawing.Color.Transparent;
            this.Account_idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_idtxt.ForeColor = System.Drawing.Color.Gold;
            this.Account_idtxt.Location = new System.Drawing.Point(58, 155);
            this.Account_idtxt.Name = "Account_idtxt";
            this.Account_idtxt.Size = new System.Drawing.Size(133, 20);
            this.Account_idtxt.TabIndex = 0;
            this.Account_idtxt.Text = "Reciver Acc  ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(58, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount";
            // 
            // Account_id_bx
            // 
            this.Account_id_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Account_id_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_id_bx.Location = new System.Drawing.Point(215, 155);
            this.Account_id_bx.Name = "Account_id_bx";
            this.Account_id_bx.Size = new System.Drawing.Size(135, 22);
            this.Account_id_bx.TabIndex = 2;
            this.Account_id_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Account_id_bx_KeyPress);
            // 
            // Amount_bx
            // 
            this.Amount_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Amount_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_bx.Location = new System.Drawing.Point(215, 207);
            this.Amount_bx.Name = "Amount_bx";
            this.Amount_bx.Size = new System.Drawing.Size(135, 22);
            this.Amount_bx.TabIndex = 3;
            this.Amount_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_bx_KeyPress);
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Transfer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer_btn.ForeColor = System.Drawing.Color.Red;
            this.Transfer_btn.Location = new System.Drawing.Point(234, 280);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(102, 32);
            this.Transfer_btn.TabIndex = 4;
            this.Transfer_btn.Text = "Transfer";
            this.Transfer_btn.UseVisualStyleBackColor = false;
            this.Transfer_btn.Click += new System.EventHandler(this.Transfer_btn_Click);
            // 
            // Fund_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectv3._0.Properties.Resources.ASRA_Banking__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 409);
            this.Controls.Add(this.Transfer_btn);
            this.Controls.Add(this.Amount_bx);
            this.Controls.Add(this.Account_id_bx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Account_idtxt);
            this.DoubleBuffered = true;
            this.Name = "Fund_Transfer";
            this.Text = "Fund_Transfer";
            this.Load += new System.EventHandler(this.Fund_Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account_idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Account_id_bx;
        private System.Windows.Forms.TextBox Amount_bx;
        private System.Windows.Forms.Button Transfer_btn;
    }
}