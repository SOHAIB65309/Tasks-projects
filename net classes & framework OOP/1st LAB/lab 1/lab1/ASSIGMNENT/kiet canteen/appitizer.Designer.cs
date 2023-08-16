namespace kiet_canteen
{
    partial class appitizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appitizer));
            this.dishtxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterdish = new System.Windows.Forms.Label();
            this.enterquantity = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dishtxt
            // 
            this.dishtxt.Location = new System.Drawing.Point(240, 229);
            this.dishtxt.Name = "dishtxt";
            this.dishtxt.Size = new System.Drawing.Size(150, 20);
            this.dishtxt.TabIndex = 0;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(240, 273);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(150, 20);
            this.quantitytxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "APPETIZER";
            // 
            // enterdish
            // 
            this.enterdish.AutoSize = true;
            this.enterdish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterdish.Location = new System.Drawing.Point(110, 220);
            this.enterdish.Name = "enterdish";
            this.enterdish.Size = new System.Drawing.Size(124, 29);
            this.enterdish.TabIndex = 3;
            this.enterdish.Text = "Enter Dish";
            // 
            // enterquantity
            // 
            this.enterquantity.AutoSize = true;
            this.enterquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterquantity.Location = new System.Drawing.Point(156, 269);
            this.enterquantity.Name = "enterquantity";
            this.enterquantity.Size = new System.Drawing.Size(78, 24);
            this.enterquantity.TabIndex = 4;
            this.enterquantity.Text = "Quantity";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Olive;
            this.submitbtn.Location = new System.Drawing.Point(133, 319);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(111, 48);
            this.submitbtn.TabIndex = 5;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.BackColor = System.Drawing.Color.Red;
            this.Returnbtn.Location = new System.Drawing.Point(303, 319);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(111, 48);
            this.Returnbtn.TabIndex = 6;
            this.Returnbtn.Text = "BACK";
            this.Returnbtn.UseVisualStyleBackColor = false;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(119, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "1.FRIES 150rs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(284, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. SOUP  400rs";
            // 
            // appitizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.enterquantity);
            this.Controls.Add(this.enterdish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.dishtxt);
            this.Name = "appitizer";
            this.Text = "appitizer";
            this.Load += new System.EventHandler(this.appitizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dishtxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterdish;
        private System.Windows.Forms.Label enterquantity;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}