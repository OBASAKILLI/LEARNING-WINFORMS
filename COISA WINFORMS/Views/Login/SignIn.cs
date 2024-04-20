using COISA_WINFORMS.Views.DASHBOARD;
using COISALIBRARY.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COISA_WINFORMS.Views.Login
{
    public partial class SignIn : Form
    {
        private LoginPage _loginPage;
        private readonly IUnitOfWork _unitOfWork;

        public SignIn(LoginPage login,IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _loginPage=login;
            _unitOfWork = unitOfWork;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(_loginPage, _unitOfWork);
            _loginPage.OpenChildForm(signUp);
        }

        private void iconButtonSignIn_Click(object sender, EventArgs e)
        {

            Dashboard_Holder dashboard_Holder = new Dashboard_Holder(_unitOfWork);
            dashboard_Holder.Show();
            this.Hide();
           _loginPage.Hide();

        }
    }
}
