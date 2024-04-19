using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COISA_WINFORMS.Views.DASHBOARD
{
    public partial class Dashboard_Holder : Form
    {
        IconButton _activeButton;

        Oders Oders = new Oders();
        ProductCategories ProductCategories = new ProductCategories();
        Products Products= new Products();
        Users Users = new Users();
        Settings Settings = new Settings();
        SuggestionBox SuggestionBox = new SuggestionBox();
        public Dashboard_Holder()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = string.Empty;
            this.ControlBox = false;
            panelLabeler.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void Form_Mouse_Down(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonmaximixe_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Height = this.MaximizedBounds.Height;
                this.Width = this.MaximizedBounds.Width;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        void ActiveButton(object sender, string Title)
        {
            
            if (sender != null)
            {
                deactivateButton();
                _activeButton = (IconButton)sender;

                _activeButton.ForeColor = Color.White;
                _activeButton.IconColor = Color.White;
                _activeButton.BackColor = Color.FromArgb(93, 107, 153);
                panelLabeler.Height = _activeButton.Height;
                panelLabeler.Location= new Point(0, _activeButton.Location.Y);
                panelLabeler.Visible = true;
                panelLabeler.BringToFront();
                labelTitle.Text = Title;
            }

         
            
        }

        void DisplayUserControl(UserControl userControl)
        {
            panelUserContolsHolder.Controls.Clear();
            panelUserContolsHolder.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        void deactivateButton()
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.FromArgb(64, 80, 141);
                _activeButton.IconColor = Color.Silver;
                _activeButton.ForeColor = Color.Silver;
                
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelUserContolsHolder.Controls.Clear();
            ActiveButton(sender,"Dashboard");
        }

        private void iconButtonOders_Click(object sender, EventArgs e)
        {

            DisplayUserControl(Oders);
            ActiveButton(sender, "Oders");
        }

        private void iconButtonCategories_Click(object sender, EventArgs e)
        {
            DisplayUserControl(ProductCategories);
            ActiveButton(sender, "Product Categories");
        }

        private void iconButtonProducts_Click(object sender, EventArgs e)
        {
            DisplayUserControl(Products);
            ActiveButton(sender, "Products");
        }

        private void iconButtonUsers_Click(object sender, EventArgs e)
        {
            DisplayUserControl(Users);
            ActiveButton(sender, "Users");
        }

        private void iconButtonSettings_Click(object sender, EventArgs e)
        {
            DisplayUserControl(Settings);
            ActiveButton(sender, "Settings");
        }

        private void iconButtonSugesBox_Click(object sender, EventArgs e)
        {
            DisplayUserControl(SuggestionBox);
            ActiveButton(sender, "Suggestion Box");
        }
    }
}
