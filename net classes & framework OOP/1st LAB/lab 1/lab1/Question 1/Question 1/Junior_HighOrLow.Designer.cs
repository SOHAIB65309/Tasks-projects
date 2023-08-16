namespace Question_1
{
    partial class Junior_HighOrLow
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
            this.Low_level = new System.Windows.Forms.Button();
            this.High_Level = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Low_level
            // 
            this.Low_level.BackColor = System.Drawing.Color.Transparent;
            this.Low_level.ForeColor = System.Drawing.Color.Green;
            this.Low_level.Image = global::Question_1.Properties.Resources.studnt;
            this.Low_level.Location = new System.Drawing.Point(249, 169);
            this.Low_level.Name = "Low_level";
            this.Low_level.Size = new System.Drawing.Size(100, 23);
            this.Low_level.TabIndex = 6;
            this.Low_level.Text = "Low Level";
            this.Low_level.UseVisualStyleBackColor = false;
            this.Low_level.Click += new System.EventHandler(this.Low_level_Click);
            // 
            // High_Level
            // 
            this.High_Level.BackColor = System.Drawing.Color.Transparent;
            this.High_Level.ForeColor = System.Drawing.Color.Green;
            this.High_Level.Image = global::Question_1.Properties.Resources.studnt;
            this.High_Level.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.High_Level.Location = new System.Drawing.Point(99, 169);
            this.High_Level.Name = "High_Level";
            this.High_Level.Size = new System.Drawing.Size(100, 23);
            this.High_Level.TabIndex = 5;
            this.High_Level.Text = "High Level";
            this.High_Level.UseVisualStyleBackColor = false;
            this.High_Level.Click += new System.EventHandler(this.High_Level_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(83, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seniour Or Jounior";
            // 
            // Junior_HighOrLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Question_1.Properties.Resources.theme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Low_level);
            this.Controls.Add(this.High_Level);
            this.DoubleBuffered = true;
            this.Name = "Junior_HighOrLow";
            this.Text = "Junior_HighOrLow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Low_level;
        private System.Windows.Forms.Button High_Level;
        private System.Windows.Forms.Label label1;
    }
}