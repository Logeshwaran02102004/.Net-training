using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


  
    public partial class Form1 : Form
    {
        public delegate void LoginSuccessEventHandler(object sender, LoginEventArgs e);
        public event LoginSuccessEventHandler LoginSuccess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username= textBox1.Text;
            string password= textBox2.Text;
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("login successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginSuccess?.Invoke(this, new LoginEventArgs(username));
                this.Close();
            }
            else
            {
                MessageBox.Show("Login unsuccessfull", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class LoginEventArgs : EventArgs
        {
            public string Username { get; set; }
            public LoginEventArgs(string Username)
            {
                Username = this.Username;
            }
        }
    }
}
