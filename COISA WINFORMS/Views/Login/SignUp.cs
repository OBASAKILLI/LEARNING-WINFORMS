using COISALIBRARY.Interfaces;
using Microsoft.VisualBasic.Logging;
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
    public partial class SignUp : Form
    {
        private LoginPage _loginPage;
        private readonly IUnitOfWork _unitOfWork;

        public SignUp(LoginPage loginPage,IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _loginPage = loginPage;
            _unitOfWork = unitOfWork;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(_loginPage, _unitOfWork);

            _loginPage.OpenChildForm(signIn);
        }
    }
}
