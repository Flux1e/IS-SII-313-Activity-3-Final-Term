using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Dashboard : Form
    {
        private SignInForm signInForm;

        public Dashboard(SignInForm login)
        {
            InitializeComponent();

            signInForm = login;

            btnLogOut.Click += btnLogOut_Click;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                signInForm.Show();
                this.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
