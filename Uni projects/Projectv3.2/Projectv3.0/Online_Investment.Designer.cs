namespace Projectv3._0
{
    partial class Online_Investment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_bx = new System.Windows.Forms.TextBox();
            this.Amount_bx = new System.Windows.Forms.TextBox();
            this.invest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(110, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Investment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Of investment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount to invest";
            // 
            // Name_bx
            // 
            this.Name_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_bx.Location = new System.Drawing.Point(223, 183);
            this.Name_bx.Name = "Name_bx";
            this.Name_bx.Size = new System.Drawing.Size(120, 22);
            this.Name_bx.TabIndex = 3;
            this.Name_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_bx_KeyPress);
            // 
            // Amount_bx
            // 
            this.Amount_bx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Amount_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_bx.Location = new System.Drawing.Point(223, 232);
            this.Amount_bx.Name = "Amount_bx";
            this.Amount_bx.Size = new System.Drawing.Size(120, 22);
            this.Amount_bx.TabIndex = 4;
            this.Amount_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_bx_KeyPress);
            // 
            // invest_btn
            // 
            this.invest_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.invest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invest_btn.ForeColor = System.Drawing.Color.Lime;
            this.invest_btn.Location = new System.Drawing.Point(218, 280);
            this.invest_btn.Name = "invest_btn";
            this.invest_btn.Size = new System.Drawing.Size(125, 32);
            this.invest_btn.TabIndex = 5;
            this.invest_btn.Text = "Invest Now";
            this.invest_btn.UseVisualStyleBackColor = false;
            this.invest_btn.Click += new System.EventHandler(this.invest_btn_Click);
            // 
            // Online_Investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectv3._0.Properties.Resources.ASRA_Banking__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 393);
            this.Controls.Add(this.invest_btn);
            this.Controls.Add(this.Amount_bx);
            this.Controls.Add(this.Name_bx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Online_Investment";
            this.Text = "Online_Investment";
            this.Load += new System.EventHandler(this.Online_Investment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_bx;
        private System.Windows.Forms.TextBox Amount_bx;
        private System.Windows.Forms.Button invest_btn;
    }
}