namespace besenica
{
    partial class addNewThings
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
            this.newWord = new System.Windows.Forms.Panel();
            this.nwlbl = new System.Windows.Forms.Label();
            this.nwWord = new System.Windows.Forms.Label();
            this.newWordIn = new System.Windows.Forms.TextBox();
            this.nwCat = new System.Windows.Forms.Label();
            this.nwCombo = new System.Windows.Forms.ComboBox();
            this.nwBtn = new System.Windows.Forms.Button();
            this.newCategory = new System.Windows.Forms.Panel();
            this.ncBtn = new System.Windows.Forms.Button();
            this.ncWord = new System.Windows.Forms.Label();
            this.ncCatIn = new System.Windows.Forms.TextBox();
            this.ncCat = new System.Windows.Forms.Label();
            this.nclbl = new System.Windows.Forms.Label();
            this.ncWordIn = new System.Windows.Forms.TextBox();
            this.backToGame = new System.Windows.Forms.Button();
            this.catDelete = new System.Windows.Forms.ListBox();
            this.deleteCat = new System.Windows.Forms.Button();
            this.dwCat = new System.Windows.Forms.ComboBox();
            this.dwCatlbl = new System.Windows.Forms.Label();
            this.dwlblList = new System.Windows.Forms.Label();
            this.wordDelete = new System.Windows.Forms.ListBox();
            this.dw = new System.Windows.Forms.Panel();
            this.dcLbl = new System.Windows.Forms.Label();
            this.wDelete = new System.Windows.Forms.Button();
            this.dc = new System.Windows.Forms.Panel();
            this.newWord.SuspendLayout();
            this.newCategory.SuspendLayout();
            this.dw.SuspendLayout();
            this.dc.SuspendLayout();
            this.SuspendLayout();
            // 
            // newWord
            // 
            this.newWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newWord.Controls.Add(this.nwBtn);
            this.newWord.Controls.Add(this.nwCombo);
            this.newWord.Controls.Add(this.nwCat);
            this.newWord.Controls.Add(this.newWordIn);
            this.newWord.Controls.Add(this.nwWord);
            this.newWord.Controls.Add(this.nwlbl);
            this.newWord.Location = new System.Drawing.Point(20, 38);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(436, 233);
            this.newWord.TabIndex = 0;
            // 
            // nwlbl
            // 
            this.nwlbl.AutoSize = true;
            this.nwlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwlbl.Location = new System.Drawing.Point(3, 0);
            this.nwlbl.Name = "nwlbl";
            this.nwlbl.Size = new System.Drawing.Size(170, 20);
            this.nwlbl.TabIndex = 0;
            this.nwlbl.Text = "Въведи Нова Дума";
            // 
            // nwWord
            // 
            this.nwWord.AutoSize = true;
            this.nwWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwWord.Location = new System.Drawing.Point(12, 39);
            this.nwWord.Name = "nwWord";
            this.nwWord.Size = new System.Drawing.Size(57, 20);
            this.nwWord.TabIndex = 1;
            this.nwWord.Text = "Дума:";
            // 
            // newWordIn
            // 
            this.newWordIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWordIn.Location = new System.Drawing.Point(7, 62);
            this.newWordIn.Name = "newWordIn";
            this.newWordIn.Size = new System.Drawing.Size(418, 36);
            this.newWordIn.TabIndex = 2;
            // 
            // nwCat
            // 
            this.nwCat.AutoSize = true;
            this.nwCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwCat.Location = new System.Drawing.Point(12, 116);
            this.nwCat.Name = "nwCat";
            this.nwCat.Size = new System.Drawing.Size(103, 20);
            this.nwCat.TabIndex = 3;
            this.nwCat.Text = "Категория:";
            // 
            // nwCombo
            // 
            this.nwCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwCombo.FormattingEnabled = true;
            this.nwCombo.Location = new System.Drawing.Point(6, 139);
            this.nwCombo.Name = "nwCombo";
            this.nwCombo.Size = new System.Drawing.Size(417, 37);
            this.nwCombo.TabIndex = 4;
            // 
            // nwBtn
            // 
            this.nwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwBtn.Location = new System.Drawing.Point(135, 186);
            this.nwBtn.Name = "nwBtn";
            this.nwBtn.Size = new System.Drawing.Size(172, 43);
            this.nwBtn.TabIndex = 5;
            this.nwBtn.Text = "Въведи дума";
            this.nwBtn.UseVisualStyleBackColor = true;
            this.nwBtn.Click += new System.EventHandler(this.nwBtn_Click);
            // 
            // newCategory
            // 
            this.newCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCategory.Controls.Add(this.ncWordIn);
            this.newCategory.Controls.Add(this.ncBtn);
            this.newCategory.Controls.Add(this.ncWord);
            this.newCategory.Controls.Add(this.ncCatIn);
            this.newCategory.Controls.Add(this.ncCat);
            this.newCategory.Controls.Add(this.nclbl);
            this.newCategory.Location = new System.Drawing.Point(20, 290);
            this.newCategory.Name = "newCategory";
            this.newCategory.Size = new System.Drawing.Size(436, 263);
            this.newCategory.TabIndex = 6;
            // 
            // ncBtn
            // 
            this.ncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncBtn.Location = new System.Drawing.Point(112, 208);
            this.ncBtn.Name = "ncBtn";
            this.ncBtn.Size = new System.Drawing.Size(218, 43);
            this.ncBtn.TabIndex = 5;
            this.ncBtn.Text = "Въведи категория";
            this.ncBtn.UseVisualStyleBackColor = true;
            this.ncBtn.Click += new System.EventHandler(this.ncBtn_Click);
            // 
            // ncWord
            // 
            this.ncWord.AutoSize = true;
            this.ncWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncWord.Location = new System.Drawing.Point(12, 117);
            this.ncWord.Name = "ncWord";
            this.ncWord.Size = new System.Drawing.Size(251, 20);
            this.ncWord.TabIndex = 3;
            this.ncWord.Text = "Дума към новата категория:";
            // 
            // ncCatIn
            // 
            this.ncCatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncCatIn.Location = new System.Drawing.Point(7, 61);
            this.ncCatIn.Name = "ncCatIn";
            this.ncCatIn.Size = new System.Drawing.Size(420, 36);
            this.ncCatIn.TabIndex = 2;
            // 
            // ncCat
            // 
            this.ncCat.AutoSize = true;
            this.ncCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncCat.Location = new System.Drawing.Point(12, 38);
            this.ncCat.Name = "ncCat";
            this.ncCat.Size = new System.Drawing.Size(103, 20);
            this.ncCat.TabIndex = 1;
            this.ncCat.Text = "Категория:";
            // 
            // nclbl
            // 
            this.nclbl.AutoSize = true;
            this.nclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nclbl.Location = new System.Drawing.Point(3, 0);
            this.nclbl.Name = "nclbl";
            this.nclbl.Size = new System.Drawing.Size(216, 20);
            this.nclbl.TabIndex = 0;
            this.nclbl.Text = "Въведи Нова Категория";
            // 
            // ncWordIn
            // 
            this.ncWordIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncWordIn.Location = new System.Drawing.Point(7, 140);
            this.ncWordIn.Name = "ncWordIn";
            this.ncWordIn.Size = new System.Drawing.Size(418, 36);
            this.ncWordIn.TabIndex = 6;
            // 
            // backToGame
            // 
            this.backToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToGame.Location = new System.Drawing.Point(56, 570);
            this.backToGame.Name = "backToGame";
            this.backToGame.Size = new System.Drawing.Size(388, 49);
            this.backToGame.TabIndex = 7;
            this.backToGame.Text = "Върни се към играта";
            this.backToGame.UseVisualStyleBackColor = true;
            this.backToGame.Click += new System.EventHandler(this.backToGame_Click);
            // 
            // catDelete
            // 
            this.catDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDelete.FormattingEnabled = true;
            this.catDelete.ItemHeight = 20;
            this.catDelete.Location = new System.Drawing.Point(16, 60);
            this.catDelete.Name = "catDelete";
            this.catDelete.ScrollAlwaysVisible = true;
            this.catDelete.Size = new System.Drawing.Size(429, 164);
            this.catDelete.TabIndex = 8;
            // 
            // deleteCat
            // 
            this.deleteCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCat.Location = new System.Drawing.Point(120, 230);
            this.deleteCat.Name = "deleteCat";
            this.deleteCat.Size = new System.Drawing.Size(218, 43);
            this.deleteCat.TabIndex = 9;
            this.deleteCat.Text = "Изтрий категория";
            this.deleteCat.UseVisualStyleBackColor = true;
            this.deleteCat.Click += new System.EventHandler(this.deleteCat_Click);
            // 
            // dwCat
            // 
            this.dwCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwCat.FormattingEnabled = true;
            this.dwCat.Location = new System.Drawing.Point(21, 33);
            this.dwCat.Name = "dwCat";
            this.dwCat.Size = new System.Drawing.Size(429, 37);
            this.dwCat.TabIndex = 6;
            this.dwCat.SelectedIndexChanged += new System.EventHandler(this.dwCat_SelectedIndexChanged);
            // 
            // dwCatlbl
            // 
            this.dwCatlbl.AutoSize = true;
            this.dwCatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwCatlbl.Location = new System.Drawing.Point(17, 10);
            this.dwCatlbl.Name = "dwCatlbl";
            this.dwCatlbl.Size = new System.Drawing.Size(103, 20);
            this.dwCatlbl.TabIndex = 6;
            this.dwCatlbl.Text = "Категория:";
            // 
            // dwlblList
            // 
            this.dwlblList.AutoSize = true;
            this.dwlblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwlblList.Location = new System.Drawing.Point(17, 87);
            this.dwlblList.Name = "dwlblList";
            this.dwlblList.Size = new System.Drawing.Size(239, 20);
            this.dwlblList.TabIndex = 10;
            this.dwlblList.Text = "Избери дума за изтриване:";
            // 
            // wordDelete
            // 
            this.wordDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDelete.FormattingEnabled = true;
            this.wordDelete.ItemHeight = 20;
            this.wordDelete.Location = new System.Drawing.Point(22, 110);
            this.wordDelete.Name = "wordDelete";
            this.wordDelete.ScrollAlwaysVisible = true;
            this.wordDelete.Size = new System.Drawing.Size(428, 124);
            this.wordDelete.TabIndex = 11;
            // 
            // dw
            // 
            this.dw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dw.Controls.Add(this.wDelete);
            this.dw.Controls.Add(this.wordDelete);
            this.dw.Controls.Add(this.dwlblList);
            this.dw.Controls.Add(this.dwCatlbl);
            this.dw.Controls.Add(this.dwCat);
            this.dw.Location = new System.Drawing.Point(483, 15);
            this.dw.Name = "dw";
            this.dw.Size = new System.Drawing.Size(480, 299);
            this.dw.TabIndex = 12;
            // 
            // dcLbl
            // 
            this.dcLbl.AutoSize = true;
            this.dcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcLbl.Location = new System.Drawing.Point(14, 34);
            this.dcLbl.Name = "dcLbl";
            this.dcLbl.Size = new System.Drawing.Size(284, 20);
            this.dcLbl.TabIndex = 13;
            this.dcLbl.Text = "Избери категория за изтриване:";
            // 
            // wDelete
            // 
            this.wDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wDelete.Location = new System.Drawing.Point(126, 248);
            this.wDelete.Name = "wDelete";
            this.wDelete.Size = new System.Drawing.Size(218, 43);
            this.wDelete.TabIndex = 14;
            this.wDelete.Text = "Изтрий дума";
            this.wDelete.UseVisualStyleBackColor = true;
            this.wDelete.Click += new System.EventHandler(this.wDelete_Click);
            // 
            // dc
            // 
            this.dc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dc.Controls.Add(this.dcLbl);
            this.dc.Controls.Add(this.deleteCat);
            this.dc.Controls.Add(this.catDelete);
            this.dc.Location = new System.Drawing.Point(483, 329);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(479, 289);
            this.dc.TabIndex = 14;
            // 
            // addNewThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 626);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dw);
            this.Controls.Add(this.backToGame);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.newWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addNewThings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addNewThings";
            this.Load += new System.EventHandler(this.addNewThings_Load);
            this.newWord.ResumeLayout(false);
            this.newWord.PerformLayout();
            this.newCategory.ResumeLayout(false);
            this.newCategory.PerformLayout();
            this.dw.ResumeLayout(false);
            this.dw.PerformLayout();
            this.dc.ResumeLayout(false);
            this.dc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newWord;
        private System.Windows.Forms.Label nwlbl;
        private System.Windows.Forms.Button nwBtn;
        private System.Windows.Forms.ComboBox nwCombo;
        private System.Windows.Forms.Label nwCat;
        private System.Windows.Forms.TextBox newWordIn;
        private System.Windows.Forms.Label nwWord;
        private System.Windows.Forms.Panel newCategory;
        private System.Windows.Forms.TextBox ncWordIn;
        private System.Windows.Forms.Button ncBtn;
        private System.Windows.Forms.Label ncWord;
        private System.Windows.Forms.TextBox ncCatIn;
        private System.Windows.Forms.Label ncCat;
        private System.Windows.Forms.Label nclbl;
        private System.Windows.Forms.Button backToGame;
        private System.Windows.Forms.ListBox catDelete;
        private System.Windows.Forms.Button deleteCat;
        private System.Windows.Forms.ComboBox dwCat;
        private System.Windows.Forms.Label dwCatlbl;
        private System.Windows.Forms.Label dwlblList;
        private System.Windows.Forms.ListBox wordDelete;
        private System.Windows.Forms.Panel dw;
        private System.Windows.Forms.Label dcLbl;
        private System.Windows.Forms.Button wDelete;
        private System.Windows.Forms.Panel dc;
    }
}