namespace COISA_WINFORMS.Views.Login
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButtonSignIn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButtonSignIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 328);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(253, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Already have an Account?";
            // 
            // iconButtonSignIn
            // 
            this.iconButtonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.iconButtonSignIn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonSignIn.IconColor = System.Drawing.Color.White;
            this.iconButtonSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSignIn.IconSize = 32;
            this.iconButtonSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSignIn.Location = new System.Drawing.Point(30, 224);
            this.iconButtonSignIn.Name = "iconButtonSignIn";
            this.iconButtonSignIn.Size = new System.Drawing.Size(341, 34);
            this.iconButtonSignIn.TabIndex = 11;
            this.iconButtonSignIn.Text = "Sign Up";
            this.iconButtonSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSignIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register new Account";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Password";
            this.textBox2.Size = new System.Drawing.Size(341, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Full name";
            this.textBox3.Size = new System.Drawing.Size(341, 31);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Username";
            this.textBox1.Size = new System.Drawing.Size(341, 31);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 328);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonSignIn;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
    }
}