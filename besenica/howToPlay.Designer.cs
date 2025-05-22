namespace besenica
{
    partial class howToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(howToPlay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rulesLbl = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::besenica.Properties.Resources.step9;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rulesLbl
            // 
            this.rulesLbl.AutoSize = true;
            this.rulesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLbl.Location = new System.Drawing.Point(441, 9);
            this.rulesLbl.Name = "rulesLbl";
            this.rulesLbl.Size = new System.Drawing.Size(333, 39);
            this.rulesLbl.TabIndex = 1;
            this.rulesLbl.Text = "Правила на играта";
            // 
            // rules
            // 
            this.rules.Location = new System.Drawing.Point(428, 66);
            this.rules.Multiline = true;
            this.rules.Name = "rules";
            this.rules.ReadOnly = true;
            this.rules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rules.Size = new System.Drawing.Size(359, 381);
            this.rules.TabIndex = 2;
            this.rules.Text = resources.GetString("rules.Text");
            // 
            // howToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 465);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.rulesLbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "howToPlay";
            this.Text = "Как се играе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label rulesLbl;
        private System.Windows.Forms.TextBox rules;
    }
}