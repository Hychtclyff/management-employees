
namespace EmployeeManagementSystem.Ui
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
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_loginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reg_username = new System.Windows.Forms.TextBox();
            this.txt_reg_password = new System.Windows.Forms.TextBox();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(276, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.EMPLYE;
            this.pictureBox1.Location = new System.Drawing.Point(104, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management System";
            // 
            // signup_loginBtn
            // 
            this.signup_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.signup_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginBtn.FlatAppearance.BorderSize = 0;
            this.signup_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.signup_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.signup_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_loginBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginBtn.ForeColor = System.Drawing.Color.Black;
            this.signup_loginBtn.Location = new System.Drawing.Point(47, 347);
            this.signup_loginBtn.Name = "signup_loginBtn";
            this.signup_loginBtn.Size = new System.Drawing.Size(226, 31);
            this.signup_loginBtn.TabIndex = 1;
            this.signup_loginBtn.Text = "SIGN IN";
            this.signup_loginBtn.UseVisualStyleBackColor = false;
            this.signup_loginBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(101, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Register Account";
            // 
            // txt_reg_username
            // 
            this.txt_reg_username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reg_username.Location = new System.Drawing.Point(32, 189);
            this.txt_reg_username.Multiline = true;
            this.txt_reg_username.Name = "txt_reg_username";
            this.txt_reg_username.Size = new System.Drawing.Size(261, 30);
            this.txt_reg_username.TabIndex = 20;
            this.txt_reg_username.Text = "Username..";
            // 
            // txt_reg_password
            // 
            this.txt_reg_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reg_password.Location = new System.Drawing.Point(32, 225);
            this.txt_reg_password.Multiline = true;
            this.txt_reg_password.Name = "txt_reg_password";
            this.txt_reg_password.PasswordChar = '*';
            this.txt_reg_password.Size = new System.Drawing.Size(261, 30);
            this.txt_reg_password.TabIndex = 22;
            this.txt_reg_password.Text = "Password";
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showPass.ForeColor = System.Drawing.Color.Black;
            this.signup_showPass.Location = new System.Drawing.Point(181, 261);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(112, 18);
            this.signup_showPass.TabIndex = 23;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.SystemColors.Control;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.Black;
            this.signup_btn.Location = new System.Drawing.Point(32, 261);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(93, 34);
            this.signup_btn.TabIndex = 24;
            this.signup_btn.Text = "SIGNUP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click_1);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(314, 400);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_reg_password);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.signup_loginBtn);
            this.Controls.Add(this.txt_reg_username);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_loginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reg_username;
        private System.Windows.Forms.TextBox txt_reg_password;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Button signup_btn;
    }
}