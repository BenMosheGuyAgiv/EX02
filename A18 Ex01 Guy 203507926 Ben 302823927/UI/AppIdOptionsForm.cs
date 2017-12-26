using System;
using System.Windows.Forms;

namespace A18_Ex01_Guy_203507926_Ben_302823927
{
    public partial class AppIdOptionsForm : Form
    {
         public Authenticator Authenticator { get; set; }

        public AppIdOptionsForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Authenticator.Login(comboBoxAppId.Text);
            if (Authenticator.LoggedInUser == null)
            {
                AppIdOptionsForm_FormClosed(null, null);
            }
            else
            {
                Hide();
            }
        }

        private void AppIdOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
