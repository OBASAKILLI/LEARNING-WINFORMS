using COISA_WINFORMS.Views;
using COISA_WINFORMS.Views.Login;
using COISALIBRARY.Interfaces;
using System.Runtime.InteropServices;


namespace COISA_WINFORMS
{
    public partial class LoginPage : Form
    {
        public Panel panelSignIn_SignUpPanel;
        private readonly IUnitOfWork _unitOfWork;
        public LoginPage(IUnitOfWork unitOfWork)
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            _unitOfWork = unitOfWork;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            panelSignIn_SignUpPanel = panelSignIn_SignUp;
            
            SignIn signIn = new SignIn(this, _unitOfWork);
            OpenChildForm(signIn);
           
        }

        private void iconButtonminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonmaximixe_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.Height=this.MaximizedBounds.Height;
                this.Width=this.MaximizedBounds.Width;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            
      

        private void Form_Mouse_Down(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void OpenChildForm(Form ChildForm)
        {
            panelSignIn_SignUp.Controls.Clear();
            ChildForm.IsMdiContainer = false;
            ChildForm.MdiParent = this;
            ChildForm.Dock= DockStyle.Fill;
            panelSignIn_SignUp.Controls.Add(ChildForm);
            ChildForm.Show();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}