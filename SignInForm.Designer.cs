namespace Inventory
{
    partial class SignInForm
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
            linkRegister = new LinkLabel();
            label5 = new Label();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(226, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 458);
            panel1.TabIndex = 1;
            panel1.Paint += this.panel1_Paint;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.ImeMode = ImeMode.NoControl;
            linkRegister.LinkColor = Color.SaddleBrown;
            linkRegister.Location = new Point(287, 379);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(66, 15);
            linkRegister.TabIndex = 8;
            linkRegister.TabStop = true;
            linkRegister.Text = "Create One";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(155, 379);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 7;
            label5.Text = "Don't Have an Account?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.SaddleBrown;
            btnSignIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.WhiteSmoke;
            btnSignIn.ImeMode = ImeMode.NoControl;
            btnSignIn.Location = new Point(187, 297);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(127, 42);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(115, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 33);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(115, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(277, 33);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(115, 216);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(115, 118);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(227, 47);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(65, 17);
            label1.Name = "label1";
            label1.Size = new Size(378, 30);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(932, 661);
            Controls.Add(panel1);
            Name = "SignInForm";
            Text = "SignIn";
            Load += SignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkRegister;
        private Label label5;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}