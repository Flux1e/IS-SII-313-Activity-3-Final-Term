using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();

            btnSignIn.Click += btnSignIn_Click_1;

            linkRegister.LinkClicked += linkRegister_LinkClicked;

            txtPassword.UseSystemPasswordChar = true;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkRegister_Click(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            string usermame = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if( usermame == ""|| password=="")
            {
                MessageBox.Show("Please enter your Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT * FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", usermame);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                           if(!reader.Read())
                            {
                                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                           string storedHash = reader["PasswordHash"].ToString();
                           string fullName = reader["FullName"].ToString();
                            string role = reader["UserRole"].ToString();
                            bool isActive = Convert.ToBoolean(reader["IsActive"]);
                            int userId = Convert.ToInt32(reader["UserID"]);

                            if(!PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if(!isActive)
                            {
                                MessageBox.Show("Your Account is inactive. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show($"Welcome, {fullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            reader.Close();

                            Dashboard dashboard = new Dashboard(this);
                            dashboard.Show();
                            this.Hide();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred while signing you in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
