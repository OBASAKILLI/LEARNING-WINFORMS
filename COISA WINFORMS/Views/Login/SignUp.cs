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
        public SignUp(LoginPage loginPage)
        {
            InitializeComponent();
            _loginPage = loginPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(_loginPage);

            _loginPage.OpenChildForm(signIn);
        }
    }
}
