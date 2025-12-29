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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.LoginSuccess += OnLoginSuccess;
            login.ShowDialog();


        }

        private void OnLoginSuccess(object sender, Form1.LoginEventArgs e)
        {
            MessageBox.Show($"Welcome, {e.Username} !", "Event Triggered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Welcomelbe.Text = $"Welcome, {e.Username}";
        }
    }
}
