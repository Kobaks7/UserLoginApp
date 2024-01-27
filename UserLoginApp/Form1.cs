using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (numberTb.Text=="2012503099" && passwordTb.Text=="123456")
            {
                MessageBox.Show("Login Succesful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
