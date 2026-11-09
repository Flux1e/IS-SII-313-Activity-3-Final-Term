using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            linkSignIn.LinkClicked += linkSignIn_LinkClicked;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signIn = new SignInForm();
            signIn.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;


            if (fullName == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";

                    using (OleDbCommand checkUserCmd = new OleDbCommand(checkUserQuery, con))
                    {
                        checkUserCmd.Parameters.AddWithValue("@Username", username);
                        int userCount = (int)checkUserCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                string query = @"INSERT INTO Users (Username, PasswordHash, FullName, UserRole, isActive) VALUES (?, ?, ?, ?, ?)";

                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        string passwordHash = PasswordHelper.HashPassword(password);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@UserRole", "User");
                        cmd.Parameters.AddWithValue("@isActive", true);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful! You can now sign in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtFullName.Clear();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtConfirmPassword.Clear();

                            SignInForm login = new SignInForm();
                            login.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {   
                 MessageBox.Show("An error occurred while registering the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
