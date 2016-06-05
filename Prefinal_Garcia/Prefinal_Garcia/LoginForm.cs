using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prefinal_Garcia
{
    public partial class LoginForm : DBConnectionForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myConnn.userLogin(userTb.Text, passTb.Text) == true)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
