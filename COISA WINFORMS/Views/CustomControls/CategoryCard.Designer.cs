namespace COISA_WINFORMS.Views.CustomControls
{
    partial class CategoryCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescriotion = new System.Windows.Forms.Label();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonRemove = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(117, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 55);
            this.panel1.TabIndex = 1;
            // 
            // labelDescriotion
            // 
            this.labelDescriotion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDescriotion.AutoSize = true;
            this.labelDescriotion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescriotion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDescriotion.Location = new System.Drawing.Point(117, 45);
            this.labelDescriotion.Name = "labelDescriotion";
            this.labelDescriotion.Size = new System.Drawing.Size(93, 22);
            this.labelDescriotion.TabIndex = 0;
            this.labelDescriotion.Text = "Description";
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(51)))));
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.ForeColor = System.Drawing.Color.White;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButtonEdit.IconColor = System.Drawing.Color.White;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 34;
            this.iconButtonEdit.Location = new System.Drawing.Point(728, 12);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(112, 45);
            this.iconButtonEdit.TabIndex = 2;
            this.iconButtonEdit.Text = "Edit";
            this.iconButtonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdit.UseVisualStyleBackColor = false;
            // 
            // iconButtonRemove
            // 
            this.iconButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButtonRemove.FlatAppearance.BorderSize = 0;
            this.iconButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRemove.ForeColor = System.Drawing.Color.White;
            this.iconButtonRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonRemove.IconColor = System.Drawing.Color.White;
            this.iconButtonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRemove.IconSize = 28;
            this.iconButtonRemove.Location = new System.Drawing.Point(871, 12);
            this.iconButtonRemove.Name = "iconButtonRemove";
            this.iconButtonRemove.Size = new System.Drawing.Size(123, 45);
            this.iconButtonRemove.TabIndex = 2;
            this.iconButtonRemove.Text = "Remove";
            this.iconButtonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRemove.UseVisualStyleBackColor = false;
            // 
            // CategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.iconButtonRemove);
            this.Controls.Add(this.iconButtonEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDescriotion);
            this.Controls.Add(this.labelTitle);
            this.Name = "CategoryCard";
            this.Size = new System.Drawing.Size(1011, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Label labelDescriotion;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonRemove;
    }
}
