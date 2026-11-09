namespace Inventory
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            linkSignIn = new LinkLabel();
            label5 = new Label();
            btnRegister = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkSignIn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(196, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 484);
            panel1.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(316, 262);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(210, 33);
            txtConfirmPassword.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(62, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 33);
            txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(316, 152);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 33);
            txtUsername.TabIndex = 15;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(62, 152);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(210, 33);
            txtFullName.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(316, 234);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(62, 234);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 12;
            label6.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(316, 124);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 11;
            label4.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(62, 124);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 10;
            label3.Text = "Full Name:";
            // 
            // linkSignIn
            // 
            linkSignIn.AutoSize = true;
            linkSignIn.ImeMode = ImeMode.NoControl;
            linkSignIn.LinkColor = Color.SaddleBrown;
            linkSignIn.Location = new Point(346, 419);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(43, 15);
            linkSignIn.TabIndex = 9;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "Sign In";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(208, 419);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 8;
            label5.Text = "Already Have an Account?";
            label5.Click += label5_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SaddleBrown;
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.ImeMode = ImeMode.NoControl;
            btnRegister.Location = new Point(227, 360);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(127, 42);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(249, 45);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(96, 15);
            label1.Name = "label1";
            label1.Size = new Size(378, 30);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(945, 633);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnRegister;
        private Label label5;
        private LinkLabel linkSignIn;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
    }
}