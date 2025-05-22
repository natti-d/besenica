namespace besenica
{
    partial class hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hangman));
            this.settingsToGame = new System.Windows.Forms.MenuStrip();
            this.restartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseInput = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadResult = new System.Windows.Forms.ToolStripMenuItem();
            this.wrongLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.keyboardInput = new System.Windows.Forms.Panel();
            this.charInput = new System.Windows.Forms.TextBox();
            this.charBtn = new System.Windows.Forms.Button();
            this.keyboardLbl = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Panel();
            this.ltr26 = new System.Windows.Forms.Button();
            this.ltr25 = new System.Windows.Forms.Button();
            this.ltr24 = new System.Windows.Forms.Button();
            this.ltr8 = new System.Windows.Forms.Button();
            this.ltr29 = new System.Windows.Forms.Button();
            this.ltr13 = new System.Windows.Forms.Button();
            this.ltr14 = new System.Windows.Forms.Button();
            this.ltr2 = new System.Windows.Forms.Button();
            this.ltr7 = new System.Windows.Forms.Button();
            this.ltr23 = new System.Windows.Forms.Button();
            this.ltr28 = new System.Windows.Forms.Button();
            this.ltr12 = new System.Windows.Forms.Button();
            this.ltr11 = new System.Windows.Forms.Button();
            this.ltr10 = new System.Windows.Forms.Button();
            this.ltr22 = new System.Windows.Forms.Button();
            this.ltr4 = new System.Windows.Forms.Button();
            this.ltr21 = new System.Windows.Forms.Button();
            this.ltr5 = new System.Windows.Forms.Button();
            this.ltr18 = new System.Windows.Forms.Button();
            this.ltr1 = new System.Windows.Forms.Button();
            this.ltr16 = new System.Windows.Forms.Button();
            this.ltr15 = new System.Windows.Forms.Button();
            this.ltr9 = new System.Windows.Forms.Button();
            this.ltr20 = new System.Windows.Forms.Button();
            this.ltr27 = new System.Windows.Forms.Button();
            this.ltr19 = new System.Windows.Forms.Button();
            this.ltr17 = new System.Windows.Forms.Button();
            this.ltr6 = new System.Windows.Forms.Button();
            this.ltr3 = new System.Windows.Forms.Button();
            this.ltr30 = new System.Windows.Forms.Button();
            this.buttonsLbl = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.TextBox();
            this.step9 = new System.Windows.Forms.TextBox();
            this.step8 = new System.Windows.Forms.TextBox();
            this.step7 = new System.Windows.Forms.TextBox();
            this.step6 = new System.Windows.Forms.TextBox();
            this.step5 = new System.Windows.Forms.TextBox();
            this.step4 = new System.Windows.Forms.TextBox();
            this.step3 = new System.Windows.Forms.TextBox();
            this.step2 = new System.Windows.Forms.TextBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.correctWord = new System.Windows.Forms.TextBox();
            this.correctLbl = new System.Windows.Forms.Label();
            this.winlbl = new System.Windows.Forms.Label();
            this.winCount = new System.Windows.Forms.TextBox();
            this.saveResults = new System.Windows.Forms.SaveFileDialog();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanging = new System.Windows.Forms.PictureBox();
            this.settingsToGame.SuspendLayout();
            this.keyboardInput.SuspendLayout();
            this.buttonInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanging)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsToGame
            // 
            this.settingsToGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsToGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settingsToGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGame,
            this.chooseInput,
            this.newMenu,
            this.downloadResult,
            this.howToPlayToolStripMenuItem});
            this.settingsToGame.Location = new System.Drawing.Point(0, 0);
            this.settingsToGame.Name = "settingsToGame";
            this.settingsToGame.Size = new System.Drawing.Size(957, 31);
            this.settingsToGame.TabIndex = 0;
            this.settingsToGame.Text = "Настройки на игра";
            // 
            // restartGame
            // 
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(105, 27);
            this.restartGame.Text = "Нова игра";
            this.restartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // chooseInput
            // 
            this.chooseInput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyboardMenu,
            this.buttonMenu});
            this.chooseInput.Name = "chooseInput";
            this.chooseInput.Size = new System.Drawing.Size(176, 27);
            this.chooseInput.Text = "Избери въвеждане";
            // 
            // keyboardMenu
            // 
            this.keyboardMenu.Name = "keyboardMenu";
            this.keyboardMenu.Size = new System.Drawing.Size(184, 28);
            this.keyboardMenu.Text = "Клавиатура";
            this.keyboardMenu.Click += new System.EventHandler(this.keyboardMenu_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(184, 28);
            this.buttonMenu.Text = "Бутони";
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(261, 27);
            this.newMenu.Text = "Запиши нови думи/категории";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // downloadResult
            // 
            this.downloadResult.Name = "downloadResult";
            this.downloadResult.Size = new System.Drawing.Size(159, 27);
            this.downloadResult.Text = "Изтегли резултат";
            this.downloadResult.Click += new System.EventHandler(this.downloadResult_Click);
            // 
            // wrongLbl
            // 
            this.wrongLbl.AutoSize = true;
            this.wrongLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongLbl.Location = new System.Drawing.Point(12, 495);
            this.wrongLbl.Name = "wrongLbl";
            this.wrongLbl.Size = new System.Drawing.Size(213, 29);
            this.wrongLbl.TabIndex = 2;
            this.wrongLbl.Text = "Непознати букви";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(411, 48);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(142, 29);
            this.categoryLbl.TabIndex = 12;
            this.categoryLbl.Text = "Категория:";
            // 
            // keyboardInput
            // 
            this.keyboardInput.Controls.Add(this.charInput);
            this.keyboardInput.Controls.Add(this.charBtn);
            this.keyboardInput.Controls.Add(this.keyboardLbl);
            this.keyboardInput.Location = new System.Drawing.Point(425, 103);
            this.keyboardInput.Name = "keyboardInput";
            this.keyboardInput.Size = new System.Drawing.Size(501, 300);
            this.keyboardInput.TabIndex = 14;
            // 
            // charInput
            // 
            this.charInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInput.Location = new System.Drawing.Point(144, 82);
            this.charInput.MaxLength = 1;
            this.charInput.Name = "charInput";
            this.charInput.Size = new System.Drawing.Size(217, 45);
            this.charInput.TabIndex = 1;
            this.charInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charBtn
            // 
            this.charBtn.BackColor = System.Drawing.Color.White;
            this.charBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charBtn.Location = new System.Drawing.Point(114, 138);
            this.charBtn.Name = "charBtn";
            this.charBtn.Size = new System.Drawing.Size(274, 41);
            this.charBtn.TabIndex = 1;
            this.charBtn.Text = "Въведи";
            this.charBtn.UseVisualStyleBackColor = false;
            this.charBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // keyboardLbl
            // 
            this.keyboardLbl.AutoSize = true;
            this.keyboardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardLbl.Location = new System.Drawing.Point(3, 0);
            this.keyboardLbl.Name = "keyboardLbl";
            this.keyboardLbl.Size = new System.Drawing.Size(227, 20);
            this.keyboardLbl.TabIndex = 0;
            this.keyboardLbl.Text = "Въвеждане с клавиатура:";
            // 
            // buttonInput
            // 
            this.buttonInput.Controls.Add(this.ltr26);
            this.buttonInput.Controls.Add(this.ltr25);
            this.buttonInput.Controls.Add(this.ltr24);
            this.buttonInput.Controls.Add(this.ltr8);
            this.buttonInput.Controls.Add(this.ltr29);
            this.buttonInput.Controls.Add(this.ltr13);
            this.buttonInput.Controls.Add(this.ltr14);
            this.buttonInput.Controls.Add(this.ltr2);
            this.buttonInput.Controls.Add(this.ltr7);
            this.buttonInput.Controls.Add(this.ltr23);
            this.buttonInput.Controls.Add(this.ltr28);
            this.buttonInput.Controls.Add(this.ltr12);
            this.buttonInput.Controls.Add(this.ltr11);
            this.buttonInput.Controls.Add(this.ltr10);
            this.buttonInput.Controls.Add(this.ltr22);
            this.buttonInput.Controls.Add(this.ltr4);
            this.buttonInput.Controls.Add(this.ltr21);
            this.buttonInput.Controls.Add(this.ltr5);
            this.buttonInput.Controls.Add(this.ltr18);
            this.buttonInput.Controls.Add(this.ltr1);
            this.buttonInput.Controls.Add(this.ltr16);
            this.buttonInput.Controls.Add(this.ltr15);
            this.buttonInput.Controls.Add(this.ltr9);
            this.buttonInput.Controls.Add(this.ltr20);
            this.buttonInput.Controls.Add(this.ltr27);
            this.buttonInput.Controls.Add(this.ltr19);
            this.buttonInput.Controls.Add(this.ltr17);
            this.buttonInput.Controls.Add(this.ltr6);
            this.buttonInput.Controls.Add(this.ltr3);
            this.buttonInput.Controls.Add(this.ltr30);
            this.buttonInput.Controls.Add(this.buttonsLbl);
            this.buttonInput.Location = new System.Drawing.Point(425, 103);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(501, 300);
            this.buttonInput.TabIndex = 15;
            this.buttonInput.Visible = false;
            // 
            // ltr26
            // 
            this.ltr26.BackColor = System.Drawing.Color.White;
            this.ltr26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr26.Location = new System.Drawing.Point(281, 212);
            this.ltr26.Name = "ltr26";
            this.ltr26.Size = new System.Drawing.Size(49, 44);
            this.ltr26.TabIndex = 31;
            this.ltr26.Tag = "buttonLetters";
            this.ltr26.Text = "Щ";
            this.ltr26.UseVisualStyleBackColor = false;
            this.ltr26.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr25
            // 
            this.ltr25.BackColor = System.Drawing.Color.White;
            this.ltr25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr25.Location = new System.Drawing.Point(226, 212);
            this.ltr25.Name = "ltr25";
            this.ltr25.Size = new System.Drawing.Size(49, 44);
            this.ltr25.TabIndex = 30;
            this.ltr25.Tag = "buttonLetters";
            this.ltr25.Text = "Ш";
            this.ltr25.UseVisualStyleBackColor = false;
            this.ltr25.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr24
            // 
            this.ltr24.BackColor = System.Drawing.Color.White;
            this.ltr24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr24.Location = new System.Drawing.Point(171, 212);
            this.ltr24.Name = "ltr24";
            this.ltr24.Size = new System.Drawing.Size(49, 44);
            this.ltr24.TabIndex = 29;
            this.ltr24.Tag = "buttonLetters";
            this.ltr24.Text = "Ч";
            this.ltr24.UseVisualStyleBackColor = false;
            this.ltr24.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr8
            // 
            this.ltr8.BackColor = System.Drawing.Color.White;
            this.ltr8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr8.Location = new System.Drawing.Point(7, 157);
            this.ltr8.Name = "ltr8";
            this.ltr8.Size = new System.Drawing.Size(49, 44);
            this.ltr8.TabIndex = 28;
            this.ltr8.Tag = "buttonLetters";
            this.ltr8.Text = "З";
            this.ltr8.UseVisualStyleBackColor = false;
            this.ltr8.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr29
            // 
            this.ltr29.BackColor = System.Drawing.Color.White;
            this.ltr29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr29.Location = new System.Drawing.Point(391, 157);
            this.ltr29.Name = "ltr29";
            this.ltr29.Size = new System.Drawing.Size(49, 44);
            this.ltr29.TabIndex = 27;
            this.ltr29.Tag = "buttonLetters";
            this.ltr29.Text = "Ю";
            this.ltr29.UseVisualStyleBackColor = false;
            this.ltr29.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr13
            // 
            this.ltr13.BackColor = System.Drawing.Color.White;
            this.ltr13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr13.Location = new System.Drawing.Point(336, 157);
            this.ltr13.Name = "ltr13";
            this.ltr13.Size = new System.Drawing.Size(49, 44);
            this.ltr13.TabIndex = 26;
            this.ltr13.Tag = "buttonLetters";
            this.ltr13.Text = "М";
            this.ltr13.UseVisualStyleBackColor = false;
            this.ltr13.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr14
            // 
            this.ltr14.BackColor = System.Drawing.Color.White;
            this.ltr14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr14.Location = new System.Drawing.Point(281, 157);
            this.ltr14.Name = "ltr14";
            this.ltr14.Size = new System.Drawing.Size(49, 44);
            this.ltr14.TabIndex = 25;
            this.ltr14.Tag = "buttonLetters";
            this.ltr14.Text = "Н";
            this.ltr14.UseVisualStyleBackColor = false;
            this.ltr14.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr2
            // 
            this.ltr2.BackColor = System.Drawing.Color.White;
            this.ltr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr2.Location = new System.Drawing.Point(226, 157);
            this.ltr2.Name = "ltr2";
            this.ltr2.Size = new System.Drawing.Size(49, 44);
            this.ltr2.TabIndex = 24;
            this.ltr2.Tag = "buttonLetters";
            this.ltr2.Text = "Б";
            this.ltr2.UseVisualStyleBackColor = false;
            this.ltr2.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr7
            // 
            this.ltr7.BackColor = System.Drawing.Color.White;
            this.ltr7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr7.Location = new System.Drawing.Point(171, 157);
            this.ltr7.Name = "ltr7";
            this.ltr7.Size = new System.Drawing.Size(49, 44);
            this.ltr7.TabIndex = 23;
            this.ltr7.Tag = "buttonLetters";
            this.ltr7.Text = "Ж";
            this.ltr7.UseVisualStyleBackColor = false;
            this.ltr7.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr23
            // 
            this.ltr23.BackColor = System.Drawing.Color.White;
            this.ltr23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr23.Location = new System.Drawing.Point(116, 157);
            this.ltr23.Name = "ltr23";
            this.ltr23.Size = new System.Drawing.Size(49, 44);
            this.ltr23.TabIndex = 22;
            this.ltr23.Tag = "buttonLetters";
            this.ltr23.Text = "Ц";
            this.ltr23.UseVisualStyleBackColor = false;
            this.ltr23.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr28
            // 
            this.ltr28.BackColor = System.Drawing.Color.White;
            this.ltr28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr28.Location = new System.Drawing.Point(61, 157);
            this.ltr28.Name = "ltr28";
            this.ltr28.Size = new System.Drawing.Size(49, 44);
            this.ltr28.TabIndex = 21;
            this.ltr28.Tag = "buttonLetters";
            this.ltr28.Text = "Ь";
            this.ltr28.UseVisualStyleBackColor = false;
            this.ltr28.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr12
            // 
            this.ltr12.BackColor = System.Drawing.Color.White;
            this.ltr12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr12.Location = new System.Drawing.Point(446, 97);
            this.ltr12.Name = "ltr12";
            this.ltr12.Size = new System.Drawing.Size(49, 44);
            this.ltr12.TabIndex = 20;
            this.ltr12.Tag = "buttonLetters";
            this.ltr12.Text = "Л";
            this.ltr12.UseVisualStyleBackColor = false;
            this.ltr12.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr11
            // 
            this.ltr11.BackColor = System.Drawing.Color.White;
            this.ltr11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr11.Location = new System.Drawing.Point(391, 97);
            this.ltr11.Name = "ltr11";
            this.ltr11.Size = new System.Drawing.Size(49, 44);
            this.ltr11.TabIndex = 19;
            this.ltr11.Tag = "buttonLetters";
            this.ltr11.Text = "К";
            this.ltr11.UseVisualStyleBackColor = false;
            this.ltr11.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr10
            // 
            this.ltr10.BackColor = System.Drawing.Color.White;
            this.ltr10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr10.Location = new System.Drawing.Point(336, 97);
            this.ltr10.Name = "ltr10";
            this.ltr10.Size = new System.Drawing.Size(49, 44);
            this.ltr10.TabIndex = 18;
            this.ltr10.Tag = "buttonLetters";
            this.ltr10.Text = "Й";
            this.ltr10.UseVisualStyleBackColor = false;
            this.ltr10.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr22
            // 
            this.ltr22.BackColor = System.Drawing.Color.White;
            this.ltr22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr22.Location = new System.Drawing.Point(281, 97);
            this.ltr22.Name = "ltr22";
            this.ltr22.Size = new System.Drawing.Size(49, 44);
            this.ltr22.TabIndex = 17;
            this.ltr22.Tag = "buttonLetters";
            this.ltr22.Text = "Х";
            this.ltr22.UseVisualStyleBackColor = false;
            this.ltr22.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr4
            // 
            this.ltr4.BackColor = System.Drawing.Color.White;
            this.ltr4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr4.Location = new System.Drawing.Point(226, 97);
            this.ltr4.Name = "ltr4";
            this.ltr4.Size = new System.Drawing.Size(49, 44);
            this.ltr4.TabIndex = 16;
            this.ltr4.Tag = "buttonLetters";
            this.ltr4.Text = "Г";
            this.ltr4.UseVisualStyleBackColor = false;
            this.ltr4.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr21
            // 
            this.ltr21.BackColor = System.Drawing.Color.White;
            this.ltr21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr21.Location = new System.Drawing.Point(171, 97);
            this.ltr21.Name = "ltr21";
            this.ltr21.Size = new System.Drawing.Size(49, 44);
            this.ltr21.TabIndex = 15;
            this.ltr21.Tag = "buttonLetters";
            this.ltr21.Text = "Ф";
            this.ltr21.UseVisualStyleBackColor = false;
            this.ltr21.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr5
            // 
            this.ltr5.BackColor = System.Drawing.Color.White;
            this.ltr5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr5.Location = new System.Drawing.Point(116, 97);
            this.ltr5.Name = "ltr5";
            this.ltr5.Size = new System.Drawing.Size(49, 44);
            this.ltr5.TabIndex = 14;
            this.ltr5.Tag = "buttonLetters";
            this.ltr5.Text = "Д";
            this.ltr5.UseVisualStyleBackColor = false;
            this.ltr5.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr18
            // 
            this.ltr18.BackColor = System.Drawing.Color.White;
            this.ltr18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr18.Location = new System.Drawing.Point(61, 97);
            this.ltr18.Name = "ltr18";
            this.ltr18.Size = new System.Drawing.Size(49, 44);
            this.ltr18.TabIndex = 13;
            this.ltr18.Tag = "buttonLetters";
            this.ltr18.Text = "С";
            this.ltr18.UseVisualStyleBackColor = false;
            this.ltr18.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr1
            // 
            this.ltr1.BackColor = System.Drawing.Color.White;
            this.ltr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr1.Location = new System.Drawing.Point(6, 97);
            this.ltr1.Name = "ltr1";
            this.ltr1.Size = new System.Drawing.Size(49, 44);
            this.ltr1.TabIndex = 12;
            this.ltr1.Tag = "buttonLetters";
            this.ltr1.Text = "А";
            this.ltr1.UseVisualStyleBackColor = false;
            this.ltr1.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr16
            // 
            this.ltr16.BackColor = System.Drawing.Color.White;
            this.ltr16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr16.Location = new System.Drawing.Point(446, 38);
            this.ltr16.Name = "ltr16";
            this.ltr16.Size = new System.Drawing.Size(49, 44);
            this.ltr16.TabIndex = 11;
            this.ltr16.Tag = "buttonLetters";
            this.ltr16.Text = "П";
            this.ltr16.UseVisualStyleBackColor = false;
            this.ltr16.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr15
            // 
            this.ltr15.BackColor = System.Drawing.Color.White;
            this.ltr15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr15.Location = new System.Drawing.Point(391, 38);
            this.ltr15.Name = "ltr15";
            this.ltr15.Size = new System.Drawing.Size(49, 44);
            this.ltr15.TabIndex = 10;
            this.ltr15.Tag = "buttonLetters";
            this.ltr15.Text = "О";
            this.ltr15.UseVisualStyleBackColor = false;
            this.ltr15.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr9
            // 
            this.ltr9.BackColor = System.Drawing.Color.White;
            this.ltr9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr9.Location = new System.Drawing.Point(336, 38);
            this.ltr9.Name = "ltr9";
            this.ltr9.Size = new System.Drawing.Size(49, 44);
            this.ltr9.TabIndex = 9;
            this.ltr9.Tag = "buttonLetters";
            this.ltr9.Text = "И";
            this.ltr9.UseVisualStyleBackColor = false;
            this.ltr9.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr20
            // 
            this.ltr20.BackColor = System.Drawing.Color.White;
            this.ltr20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr20.Location = new System.Drawing.Point(281, 38);
            this.ltr20.Name = "ltr20";
            this.ltr20.Size = new System.Drawing.Size(49, 44);
            this.ltr20.TabIndex = 8;
            this.ltr20.Tag = "buttonLetters";
            this.ltr20.Text = "У";
            this.ltr20.UseVisualStyleBackColor = false;
            this.ltr20.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr27
            // 
            this.ltr27.BackColor = System.Drawing.Color.White;
            this.ltr27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr27.Location = new System.Drawing.Point(226, 38);
            this.ltr27.Name = "ltr27";
            this.ltr27.Size = new System.Drawing.Size(49, 44);
            this.ltr27.TabIndex = 7;
            this.ltr27.Tag = "buttonLetters";
            this.ltr27.Text = "Ъ";
            this.ltr27.UseVisualStyleBackColor = false;
            this.ltr27.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr19
            // 
            this.ltr19.BackColor = System.Drawing.Color.White;
            this.ltr19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr19.Location = new System.Drawing.Point(171, 38);
            this.ltr19.Name = "ltr19";
            this.ltr19.Size = new System.Drawing.Size(49, 44);
            this.ltr19.TabIndex = 6;
            this.ltr19.Tag = "buttonLetters";
            this.ltr19.Text = "Т";
            this.ltr19.UseVisualStyleBackColor = false;
            this.ltr19.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr17
            // 
            this.ltr17.BackColor = System.Drawing.Color.White;
            this.ltr17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr17.Location = new System.Drawing.Point(116, 38);
            this.ltr17.Name = "ltr17";
            this.ltr17.Size = new System.Drawing.Size(49, 44);
            this.ltr17.TabIndex = 5;
            this.ltr17.Tag = "buttonLetters";
            this.ltr17.Text = "Р";
            this.ltr17.UseVisualStyleBackColor = false;
            this.ltr17.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr6
            // 
            this.ltr6.BackColor = System.Drawing.Color.White;
            this.ltr6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr6.Location = new System.Drawing.Point(61, 38);
            this.ltr6.Name = "ltr6";
            this.ltr6.Size = new System.Drawing.Size(49, 44);
            this.ltr6.TabIndex = 4;
            this.ltr6.Tag = "buttonLetters";
            this.ltr6.Text = "Е";
            this.ltr6.UseVisualStyleBackColor = false;
            this.ltr6.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr3
            // 
            this.ltr3.BackColor = System.Drawing.Color.White;
            this.ltr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr3.Location = new System.Drawing.Point(6, 38);
            this.ltr3.Name = "ltr3";
            this.ltr3.Size = new System.Drawing.Size(49, 44);
            this.ltr3.TabIndex = 3;
            this.ltr3.Tag = "buttonLetters";
            this.ltr3.Text = "В";
            this.ltr3.UseVisualStyleBackColor = false;
            this.ltr3.Click += new System.EventHandler(this.clickLetter);
            // 
            // ltr30
            // 
            this.ltr30.BackColor = System.Drawing.Color.White;
            this.ltr30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltr30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltr30.Location = new System.Drawing.Point(446, 157);
            this.ltr30.Name = "ltr30";
            this.ltr30.Size = new System.Drawing.Size(49, 44);
            this.ltr30.TabIndex = 2;
            this.ltr30.Tag = "buttonLetters";
            this.ltr30.Text = "Я";
            this.ltr30.UseVisualStyleBackColor = false;
            this.ltr30.Click += new System.EventHandler(this.clickLetter);
            // 
            // buttonsLbl
            // 
            this.buttonsLbl.AutoSize = true;
            this.buttonsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsLbl.Location = new System.Drawing.Point(3, 0);
            this.buttonsLbl.Name = "buttonsLbl";
            this.buttonsLbl.Size = new System.Drawing.Size(188, 20);
            this.buttonsLbl.TabIndex = 1;
            this.buttonsLbl.Text = "Въвеждане с бутони:";
            // 
            // step1
            // 
            this.step1.BackColor = System.Drawing.Color.White;
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1.ForeColor = System.Drawing.Color.Red;
            this.step1.Location = new System.Drawing.Point(12, 529);
            this.step1.Name = "step1";
            this.step1.ReadOnly = true;
            this.step1.Size = new System.Drawing.Size(43, 41);
            this.step1.TabIndex = 25;
            this.step1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step9
            // 
            this.step9.BackColor = System.Drawing.Color.White;
            this.step9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step9.ForeColor = System.Drawing.Color.Red;
            this.step9.Location = new System.Drawing.Point(404, 529);
            this.step9.Name = "step9";
            this.step9.ReadOnly = true;
            this.step9.Size = new System.Drawing.Size(43, 41);
            this.step9.TabIndex = 24;
            this.step9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step8
            // 
            this.step8.BackColor = System.Drawing.Color.White;
            this.step8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step8.ForeColor = System.Drawing.Color.Red;
            this.step8.Location = new System.Drawing.Point(355, 529);
            this.step8.Name = "step8";
            this.step8.ReadOnly = true;
            this.step8.Size = new System.Drawing.Size(43, 41);
            this.step8.TabIndex = 23;
            this.step8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step7
            // 
            this.step7.BackColor = System.Drawing.Color.White;
            this.step7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step7.ForeColor = System.Drawing.Color.Red;
            this.step7.Location = new System.Drawing.Point(306, 529);
            this.step7.Name = "step7";
            this.step7.ReadOnly = true;
            this.step7.Size = new System.Drawing.Size(43, 41);
            this.step7.TabIndex = 22;
            this.step7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step6
            // 
            this.step6.BackColor = System.Drawing.Color.White;
            this.step6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step6.ForeColor = System.Drawing.Color.Red;
            this.step6.Location = new System.Drawing.Point(257, 529);
            this.step6.Name = "step6";
            this.step6.ReadOnly = true;
            this.step6.Size = new System.Drawing.Size(43, 41);
            this.step6.TabIndex = 21;
            this.step6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step5
            // 
            this.step5.BackColor = System.Drawing.Color.White;
            this.step5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step5.ForeColor = System.Drawing.Color.Red;
            this.step5.Location = new System.Drawing.Point(208, 529);
            this.step5.Name = "step5";
            this.step5.ReadOnly = true;
            this.step5.Size = new System.Drawing.Size(43, 41);
            this.step5.TabIndex = 20;
            this.step5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step4
            // 
            this.step4.BackColor = System.Drawing.Color.White;
            this.step4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step4.ForeColor = System.Drawing.Color.Red;
            this.step4.Location = new System.Drawing.Point(159, 529);
            this.step4.Name = "step4";
            this.step4.ReadOnly = true;
            this.step4.Size = new System.Drawing.Size(43, 41);
            this.step4.TabIndex = 19;
            this.step4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step3
            // 
            this.step3.BackColor = System.Drawing.Color.White;
            this.step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step3.ForeColor = System.Drawing.Color.Red;
            this.step3.Location = new System.Drawing.Point(110, 529);
            this.step3.Name = "step3";
            this.step3.ReadOnly = true;
            this.step3.Size = new System.Drawing.Size(43, 41);
            this.step3.TabIndex = 18;
            this.step3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step2
            // 
            this.step2.BackColor = System.Drawing.Color.White;
            this.step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2.ForeColor = System.Drawing.Color.Red;
            this.step2.Location = new System.Drawing.Point(61, 529);
            this.step2.Name = "step2";
            this.step2.ReadOnly = true;
            this.step2.Size = new System.Drawing.Size(43, 41);
            this.step2.TabIndex = 17;
            this.step2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(559, 48);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(367, 34);
            this.categoryCombo.TabIndex = 27;
            this.categoryCombo.SelectedIndexChanged += new System.EventHandler(this.categoryCombo_SelectedIndexChanged);
            // 
            // correctWord
            // 
            this.correctWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctWord.Location = new System.Drawing.Point(515, 451);
            this.correctWord.Name = "correctWord";
            this.correctWord.ReadOnly = true;
            this.correctWord.Size = new System.Drawing.Size(298, 45);
            this.correctWord.TabIndex = 28;
            this.correctWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLbl.Location = new System.Drawing.Point(518, 420);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(216, 26);
            this.correctLbl.TabIndex = 29;
            this.correctLbl.Text = "Дума за познаване:";
            // 
            // winlbl
            // 
            this.winlbl.AutoSize = true;
            this.winlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlbl.Location = new System.Drawing.Point(625, 540);
            this.winlbl.Name = "winlbl";
            this.winlbl.Size = new System.Drawing.Size(161, 26);
            this.winlbl.TabIndex = 31;
            this.winlbl.Text = "Познати думи:";
            // 
            // winCount
            // 
            this.winCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winCount.Location = new System.Drawing.Point(792, 534);
            this.winCount.Name = "winCount";
            this.winCount.ReadOnly = true;
            this.winCount.Size = new System.Drawing.Size(157, 36);
            this.winCount.TabIndex = 30;
            this.winCount.Text = "0";
            this.winCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.howToPlayToolStripMenuItem.Text = "Как се играе?";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // hanging
            // 
            this.hanging.Image = global::besenica.Properties.Resources.step0;
            this.hanging.Location = new System.Drawing.Point(12, 45);
            this.hanging.Name = "hanging";
            this.hanging.Size = new System.Drawing.Size(393, 442);
            this.hanging.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hanging.TabIndex = 1;
            this.hanging.TabStop = false;
            // 
            // hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 579);
            this.Controls.Add(this.winlbl);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.correctWord);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.step9);
            this.Controls.Add(this.step8);
            this.Controls.Add(this.step7);
            this.Controls.Add(this.step6);
            this.Controls.Add(this.step5);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.keyboardInput);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.wrongLbl);
            this.Controls.Add(this.hanging);
            this.Controls.Add(this.settingsToGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.settingsToGame;
            this.Name = "hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бесеница";
            this.Load += new System.EventHandler(this.hangman_Load);
            this.settingsToGame.ResumeLayout(false);
            this.settingsToGame.PerformLayout();
            this.keyboardInput.ResumeLayout(false);
            this.keyboardInput.PerformLayout();
            this.buttonInput.ResumeLayout(false);
            this.buttonInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip settingsToGame;
        private System.Windows.Forms.ToolStripMenuItem restartGame;
        private System.Windows.Forms.ToolStripMenuItem chooseInput;
        private System.Windows.Forms.PictureBox hanging;
        private System.Windows.Forms.ToolStripMenuItem keyboardMenu;
        private System.Windows.Forms.ToolStripMenuItem buttonMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.Label wrongLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Panel keyboardInput;
        private System.Windows.Forms.TextBox charInput;
        private System.Windows.Forms.Button charBtn;
        private System.Windows.Forms.Label keyboardLbl;
        private System.Windows.Forms.Panel buttonInput;
        private System.Windows.Forms.Button ltr15;
        private System.Windows.Forms.Button ltr9;
        private System.Windows.Forms.Button ltr20;
        private System.Windows.Forms.Button ltr27;
        private System.Windows.Forms.Button ltr19;
        private System.Windows.Forms.Button ltr17;
        private System.Windows.Forms.Button ltr6;
        private System.Windows.Forms.Button ltr3;
        private System.Windows.Forms.Button ltr30;
        private System.Windows.Forms.Label buttonsLbl;
        private System.Windows.Forms.Button ltr26;
        private System.Windows.Forms.Button ltr25;
        private System.Windows.Forms.Button ltr24;
        private System.Windows.Forms.Button ltr8;
        private System.Windows.Forms.Button ltr29;
        private System.Windows.Forms.Button ltr13;
        private System.Windows.Forms.Button ltr14;
        private System.Windows.Forms.Button ltr2;
        private System.Windows.Forms.Button ltr7;
        private System.Windows.Forms.Button ltr23;
        private System.Windows.Forms.Button ltr28;
        private System.Windows.Forms.Button ltr12;
        private System.Windows.Forms.Button ltr11;
        private System.Windows.Forms.Button ltr10;
        private System.Windows.Forms.Button ltr22;
        private System.Windows.Forms.Button ltr4;
        private System.Windows.Forms.Button ltr21;
        private System.Windows.Forms.Button ltr5;
        private System.Windows.Forms.Button ltr18;
        private System.Windows.Forms.Button ltr1;
        private System.Windows.Forms.Button ltr16;
        private System.Windows.Forms.TextBox step1;
        private System.Windows.Forms.TextBox step9;
        private System.Windows.Forms.TextBox step8;
        private System.Windows.Forms.TextBox step7;
        private System.Windows.Forms.TextBox step6;
        private System.Windows.Forms.TextBox step5;
        private System.Windows.Forms.TextBox step4;
        private System.Windows.Forms.TextBox step3;
        private System.Windows.Forms.TextBox step2;
        private System.Windows.Forms.ToolStripMenuItem downloadResult;
        private System.Windows.Forms.TextBox correctWord;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Label winlbl;
        private System.Windows.Forms.TextBox winCount;
        public System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.SaveFileDialog saveResults;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}

