namespace COISA_WINFORMS.Views.DASHBOARD
{
    partial class Dashboard_Holder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Holder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDashboardButtons = new System.Windows.Forms.Panel();
            this.iconButtonSugesBox = new FontAwesome.Sharp.IconButton();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonUsers = new FontAwesome.Sharp.IconButton();
            this.iconButtonProducts = new FontAwesome.Sharp.IconButton();
            this.iconButtonCategories = new FontAwesome.Sharp.IconButton();
            this.iconButtonOders = new FontAwesome.Sharp.IconButton();
            this.panelLabeler = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eK_AvaterImage1 = new COISA_WINFORMS.wwwroot.Custom_Controls.EK_AvaterImage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonminimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonmaximixe = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUserContolsHolder = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelDashboardButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eK_AvaterImage1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.panelDashboardButtons);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 665);
            this.panel1.TabIndex = 0;
            // 
            // panelDashboardButtons
            // 
            this.panelDashboardButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.panelDashboardButtons.Controls.Add(this.iconButtonSugesBox);
            this.panelDashboardButtons.Controls.Add(this.iconButtonSettings);
            this.panelDashboardButtons.Controls.Add(this.iconButtonUsers);
            this.panelDashboardButtons.Controls.Add(this.iconButtonProducts);
            this.panelDashboardButtons.Controls.Add(this.iconButtonCategories);
            this.panelDashboardButtons.Controls.Add(this.iconButtonOders);
            this.panelDashboardButtons.Controls.Add(this.panelLabeler);
            this.panelDashboardButtons.Controls.Add(this.iconButton1);
            this.panelDashboardButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboardButtons.Location = new System.Drawing.Point(0, 193);
            this.panelDashboardButtons.Name = "panelDashboardButtons";
            this.panelDashboardButtons.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.panelDashboardButtons.Size = new System.Drawing.Size(250, 472);
            this.panelDashboardButtons.TabIndex = 1;
            // 
            // iconButtonSugesBox
            // 
            this.iconButtonSugesBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSugesBox.FlatAppearance.BorderSize = 0;
            this.iconButtonSugesBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSugesBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonSugesBox.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonSugesBox.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButtonSugesBox.IconColor = System.Drawing.Color.Silver;
            this.iconButtonSugesBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSugesBox.IconSize = 34;
            this.iconButtonSugesBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSugesBox.Location = new System.Drawing.Point(0, 410);
            this.iconButtonSugesBox.Name = "iconButtonSugesBox";
            this.iconButtonSugesBox.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonSugesBox.Size = new System.Drawing.Size(250, 62);
            this.iconButtonSugesBox.TabIndex = 7;
            this.iconButtonSugesBox.Text = "Suggestion Box";
            this.iconButtonSugesBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSugesBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSugesBox.UseVisualStyleBackColor = true;
            this.iconButtonSugesBox.Click += new System.EventHandler(this.iconButtonSugesBox_Click);
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButtonSettings.IconColor = System.Drawing.Color.Silver;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 34;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 334);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonSettings.Size = new System.Drawing.Size(250, 62);
            this.iconButtonSettings.TabIndex = 6;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            this.iconButtonSettings.Click += new System.EventHandler(this.iconButtonSettings_Click);
            // 
            // iconButtonUsers
            // 
            this.iconButtonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonUsers.FlatAppearance.BorderSize = 0;
            this.iconButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsers.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonUsers.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonUsers.IconColor = System.Drawing.Color.Silver;
            this.iconButtonUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUsers.IconSize = 34;
            this.iconButtonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUsers.Location = new System.Drawing.Point(0, 272);
            this.iconButtonUsers.Name = "iconButtonUsers";
            this.iconButtonUsers.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonUsers.Size = new System.Drawing.Size(250, 62);
            this.iconButtonUsers.TabIndex = 5;
            this.iconButtonUsers.Text = "Users";
            this.iconButtonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsers.UseVisualStyleBackColor = true;
            this.iconButtonUsers.Click += new System.EventHandler(this.iconButtonUsers_Click);
            // 
            // iconButtonProducts
            // 
            this.iconButtonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProducts.FlatAppearance.BorderSize = 0;
            this.iconButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProducts.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonProducts.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iconButtonProducts.IconColor = System.Drawing.Color.Silver;
            this.iconButtonProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProducts.IconSize = 34;
            this.iconButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.Location = new System.Drawing.Point(0, 210);
            this.iconButtonProducts.Name = "iconButtonProducts";
            this.iconButtonProducts.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonProducts.Size = new System.Drawing.Size(250, 62);
            this.iconButtonProducts.TabIndex = 4;
            this.iconButtonProducts.Text = "Products";
            this.iconButtonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProducts.UseVisualStyleBackColor = true;
            this.iconButtonProducts.Click += new System.EventHandler(this.iconButtonProducts_Click);
            // 
            // iconButtonCategories
            // 
            this.iconButtonCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCategories.FlatAppearance.BorderSize = 0;
            this.iconButtonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCategories.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonCategories.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonCategories.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButtonCategories.IconColor = System.Drawing.Color.Silver;
            this.iconButtonCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCategories.IconSize = 34;
            this.iconButtonCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCategories.Location = new System.Drawing.Point(0, 148);
            this.iconButtonCategories.Name = "iconButtonCategories";
            this.iconButtonCategories.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonCategories.Size = new System.Drawing.Size(250, 62);
            this.iconButtonCategories.TabIndex = 3;
            this.iconButtonCategories.Text = "Categories";
            this.iconButtonCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCategories.UseVisualStyleBackColor = true;
            this.iconButtonCategories.Click += new System.EventHandler(this.iconButtonCategories_Click);
            // 
            // iconButtonOders
            // 
            this.iconButtonOders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOders.FlatAppearance.BorderSize = 0;
            this.iconButtonOders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOders.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonOders.ForeColor = System.Drawing.Color.Silver;
            this.iconButtonOders.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButtonOders.IconColor = System.Drawing.Color.Silver;
            this.iconButtonOders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOders.IconSize = 34;
            this.iconButtonOders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOders.Location = new System.Drawing.Point(0, 86);
            this.iconButtonOders.Name = "iconButtonOders";
            this.iconButtonOders.Padding = new System.Windows.Forms.Padding(10);
            this.iconButtonOders.Size = new System.Drawing.Size(250, 62);
            this.iconButtonOders.TabIndex = 2;
            this.iconButtonOders.Text = "Oders";
            this.iconButtonOders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonOders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOders.UseVisualStyleBackColor = true;
            this.iconButtonOders.Click += new System.EventHandler(this.iconButtonOders_Click);
            // 
            // panelLabeler
            // 
            this.panelLabeler.BackColor = System.Drawing.Color.White;
            this.panelLabeler.Location = new System.Drawing.Point(0, 24);
            this.panelLabeler.Name = "panelLabeler";
            this.panelLabeler.Size = new System.Drawing.Size(8, 62);
            this.panelLabeler.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.Silver;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton1.IconColor = System.Drawing.Color.Silver;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 34;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 24);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton1.Size = new System.Drawing.Size(250, 62);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.eK_AvaterImage1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 193);
            this.panel3.TabIndex = 0;
            // 
            // eK_AvaterImage1
            // 
            this.eK_AvaterImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eK_AvaterImage1.Image = ((System.Drawing.Image)(resources.GetObject("eK_AvaterImage1.Image")));
            this.eK_AvaterImage1.Location = new System.Drawing.Point(62, 12);
            this.eK_AvaterImage1.Name = "eK_AvaterImage1";
            this.eK_AvaterImage1.Size = new System.Drawing.Size(90, 90);
            this.eK_AvaterImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eK_AvaterImage1.TabIndex = 0;
            this.eK_AvaterImage1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "+254 799 092727";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "emmanukiptoo98@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kili Emmanuel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iconButtonminimize);
            this.panel2.Controls.Add(this.iconButtonmaximixe);
            this.panel2.Controls.Add(this.iconButtonClose);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 62);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Mouse_Down);
            // 
            // iconButtonminimize
            // 
            this.iconButtonminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonminimize.FlatAppearance.BorderSize = 0;
            this.iconButtonminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonminimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonminimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconButtonminimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonminimize.IconSize = 22;
            this.iconButtonminimize.Location = new System.Drawing.Point(749, 12);
            this.iconButtonminimize.Name = "iconButtonminimize";
            this.iconButtonminimize.Size = new System.Drawing.Size(29, 30);
            this.iconButtonminimize.TabIndex = 5;
            this.iconButtonminimize.UseVisualStyleBackColor = true;
            this.iconButtonminimize.Click += new System.EventHandler(this.iconButtonminimize_Click);
            // 
            // iconButtonmaximixe
            // 
            this.iconButtonmaximixe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonmaximixe.FlatAppearance.BorderSize = 0;
            this.iconButtonmaximixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonmaximixe.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonmaximixe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconButtonmaximixe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonmaximixe.IconSize = 22;
            this.iconButtonmaximixe.Location = new System.Drawing.Point(783, 12);
            this.iconButtonmaximixe.Name = "iconButtonmaximixe";
            this.iconButtonmaximixe.Size = new System.Drawing.Size(29, 30);
            this.iconButtonmaximixe.TabIndex = 6;
            this.iconButtonmaximixe.UseVisualStyleBackColor = true;
            this.iconButtonmaximixe.Click += new System.EventHandler(this.iconButtonmaximixe_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButtonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 22;
            this.iconButtonClose.Location = new System.Drawing.Point(817, 12);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(29, 30);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(51)))));
            this.labelTitle.Location = new System.Drawing.Point(14, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 39);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(250, 608);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 57);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(169, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "@ Kili Emmanuel - 0799092727\r\n";
            // 
            // panelUserContolsHolder
            // 
            this.panelUserContolsHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panelUserContolsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserContolsHolder.Location = new System.Drawing.Point(250, 62);
            this.panelUserContolsHolder.Name = "panelUserContolsHolder";
            this.panelUserContolsHolder.Size = new System.Drawing.Size(860, 546);
            this.panelUserContolsHolder.TabIndex = 3;
            // 
            // Dashboard_Holder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 665);
            this.Controls.Add(this.panelUserContolsHolder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_Holder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Holder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Mouse_Down);
            this.panel1.ResumeLayout(false);
            this.panelDashboardButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eK_AvaterImage1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonminimize;
        private FontAwesome.Sharp.IconButton iconButtonmaximixe;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Label labelTitle;
        private Panel panel4;
        private Label label3;
        private Panel panelUserContolsHolder;
        private wwwroot.Custom_Controls.EK_AvaterImage eK_AvaterImage1;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelDashboardButtons;
        private Panel panelLabeler;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonUsers;
        private FontAwesome.Sharp.IconButton iconButtonProducts;
        private FontAwesome.Sharp.IconButton iconButtonCategories;
        private FontAwesome.Sharp.IconButton iconButtonOders;
        private FontAwesome.Sharp.IconButton iconButtonSugesBox;
    }
}