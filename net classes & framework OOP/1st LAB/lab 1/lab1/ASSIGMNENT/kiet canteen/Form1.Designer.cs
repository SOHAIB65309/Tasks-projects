namespace kiet_canteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.apptizerbtn = new System.Windows.Forms.Button();
            this.maincoursebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.desertbtn = new System.Windows.Forms.Button();
            this.makereceiptbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIET CANTEEN ME KHUSHAMDEED";
            // 
            // apptizerbtn
            // 
            this.apptizerbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.apptizerbtn.Location = new System.Drawing.Point(146, 90);
            this.apptizerbtn.Name = "apptizerbtn";
            this.apptizerbtn.Size = new System.Drawing.Size(163, 46);
            this.apptizerbtn.TabIndex = 1;
            this.apptizerbtn.Text = "APPETIZER";
            this.apptizerbtn.UseVisualStyleBackColor = false;
            this.apptizerbtn.Click += new System.EventHandler(this.apptizerbtn_Click);
            // 
            // maincoursebtn
            // 
            this.maincoursebtn.BackColor = System.Drawing.Color.Yellow;
            this.maincoursebtn.Location = new System.Drawing.Point(146, 178);
            this.maincoursebtn.Name = "maincoursebtn";
            this.maincoursebtn.Size = new System.Drawing.Size(163, 46);
            this.maincoursebtn.TabIndex = 2;
            this.maincoursebtn.Text = "MAIN COURSE";
            this.maincoursebtn.UseVisualStyleBackColor = false;
            this.maincoursebtn.Click += new System.EventHandler(this.maincoursebtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(146, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "APPETIZER";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // desertbtn
            // 
            this.desertbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.desertbtn.Location = new System.Drawing.Point(146, 257);
            this.desertbtn.Name = "desertbtn";
            this.desertbtn.Size = new System.Drawing.Size(163, 46);
            this.desertbtn.TabIndex = 3;
            this.desertbtn.Text = "DESERT";
            this.desertbtn.UseVisualStyleBackColor = false;
            this.desertbtn.Click += new System.EventHandler(this.desertbtn_Click);
            // 
            // makereceiptbtn
            // 
            this.makereceiptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.makereceiptbtn.Location = new System.Drawing.Point(381, 178);
            this.makereceiptbtn.Name = "makereceiptbtn";
            this.makereceiptbtn.Size = new System.Drawing.Size(226, 61);
            this.makereceiptbtn.TabIndex = 4;
            this.makereceiptbtn.Text = "MAKE RECEIPT";
            this.makereceiptbtn.UseVisualStyleBackColor = false;
            this.makereceiptbtn.Click += new System.EventHandler(this.makereceiptbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 420);
            this.Controls.Add(this.makereceiptbtn);
            this.Controls.Add(this.desertbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maincoursebtn);
            this.Controls.Add(this.apptizerbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apptizerbtn;
        private System.Windows.Forms.Button maincoursebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button desertbtn;
        private System.Windows.Forms.Button makereceiptbtn;
    }
}

