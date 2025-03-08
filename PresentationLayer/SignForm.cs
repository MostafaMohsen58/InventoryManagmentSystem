using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PresentationLayer
{
    //User user
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
            btn_login.Enabled = false;
            btn_signup.Enabled = false;
            //user(connectionString)
        }

        //SignIn Tap
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_signin_Click(object sender, EventArgs e)
        {
            pnl_slide.Location = new Point(115, 96);
            pnl_signup.Visible = false;
        }
        private void btn_login_MouseEnter(object sender, EventArgs e) => btn_login.BackColor = ColorTranslator.FromHtml("#CB594E");
        private void btn_login_MouseLeave(object sender, EventArgs e) => btn_login.BackColor = ColorTranslator.FromHtml("#FE7062");

        private void btn_signInReset_MouseEnter(object sender, EventArgs e) => btn_signInReset.BackColor = ColorTranslator.FromHtml("#CB594E");
        private void btn_signInReset_MouseLeave(object sender, EventArgs e) => btn_signInReset.BackColor = ColorTranslator.FromHtml("#FE7062");

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e) => txt_signinPass.UseSystemPasswordChar = false;
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e) => txt_signinPass.UseSystemPasswordChar = true;


        private void txt_signinName_Click(object sender, EventArgs e)
        {
            lbl_signInUserError.Visible = false;
            if (txt_signinPass.Text == "")
            {
                lbl_signInPassError.Visible = true;
            }
        }
        private void txt_signinPass_Click(object sender, EventArgs e)
        {
            lbl_signInPassError.Visible = false;
            if (txt_signinName.Text == "")
            {
                lbl_signInUserError.Visible = true;
            }
        }
        private void txt_signinName_TextChanged(object sender, EventArgs e)
        {
            lbl_signInUserError.Visible = string.IsNullOrWhiteSpace(txt_signinName.Text);
            btn_login.Enabled = !string.IsNullOrWhiteSpace(txt_signinName.Text) && !string.IsNullOrWhiteSpace(txt_signinPass.Text);
        }
        private void txt_signinPass_TextChanged(object sender, EventArgs e)
        {
            lbl_signInPassError.Visible = string.IsNullOrWhiteSpace(txt_signinPass.Text);
            btn_login.Enabled = !string.IsNullOrWhiteSpace(txt_signinName.Text) && !string.IsNullOrWhiteSpace(txt_signinPass.Text);
        }
        private void btn_signInReset_Click(object sender, EventArgs e)
        {
            txt_signinName.Clear();
            txt_signinPass.Clear();
            lbl_signInPassError.Visible = false;
            lbl_signInUserError.Visible = false;
            lbl_signInerrorMsg.Visible = false;
            btn_login.Enabled = false;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_signinName.Text.Trim();
            string password = txt_signinPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lbl_signInUserError.Visible = true;
                lbl_signInPassError.Visible = true;
                lbl_signInerrorMsg.Text = "Please fill the Form";
                lbl_signInerrorMsg.Visible = true;
                return;
            }

            //bool isAuthenticated = user.AuthenticateUser(usernameOrEmail, password);
            //string role = user.GetUserByRole(usernameOrEmail);
            //if (isAuthenticated)
            //{
            //    int userId = user.GetUserIdByUsername(usernameOrEmail);
            //    if (role == "Admin" || role == "Manager")
            //    {
            //        this.Hide();
            //        Open Dashboard
            //        dashBoard.ShowDialog();
            //        this.Close();
            //    }
            //    else if (role == "staff")
            //    {
            //        this.Hide();
            //        Open form
            //        form.ShowDialog();
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //SignUp Tap

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            pnl_slide.Location = new Point(221, 96);
            pnl_signup.Visible = true;
        }

        private void btn_signup_MouseEnter(object sender, EventArgs e) => btn_signup.BackColor = ColorTranslator.FromHtml("#CB594E");
        private void btn_signup_MouseLeave(object sender, EventArgs e) => btn_signup.BackColor = ColorTranslator.FromHtml("#FE7062");

        private void btn_reset_MouseEnter(object sender, EventArgs e) => btn_reset.BackColor = ColorTranslator.FromHtml("#CB594E");
        private void btn_reset_MouseLeave(object sender, EventArgs e) => btn_reset.BackColor = ColorTranslator.FromHtml("#FE7062");

        private void txt_userName_Click(object sender, EventArgs e)
        {
            lbl_userError.Visible = false;
            if (txt_pass.Text == "")
            {
                lbl_passError.Visible = true;

            }
            else if (txt_confirmPass.Text == "")
            {
                lbl_confirmError.Visible = true;
            }

        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            lbl_passError.Visible = false;
            if (txt_userName.Text == "")
            {
                lbl_userError.Visible = true;

            }
            else if (txt_confirmPass.Text == "")
            {
                lbl_confirmError.Visible = true;
            }
        }



        private void txt_userName_TextChanged(object sender, EventArgs e)
        {
            lbl_userError.Visible = string.IsNullOrWhiteSpace(txt_userName.Text);
            CheckSignUpButtonState();
        }
        private void txt_userName_Leave(object sender, EventArgs e)
        {
            lbl_userError.Visible = string.IsNullOrWhiteSpace(txt_userName.Text);
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            lbl_passError.Visible = false;
            CheckSignUpButtonState();
        }
        private void txt_confirmPass_TextChanged(object sender, EventArgs e)
        {
            lbl_confirmError.Visible = txt_pass.Text != txt_confirmPass.Text;
            CheckSignUpButtonState();
        }
        private void CheckSignUpButtonState()
        {
            bool isUserNameValid = !string.IsNullOrWhiteSpace(txt_userName.Text);
            bool isPasswordValid = !string.IsNullOrWhiteSpace(txt_pass.Text);
            bool isConfirmPasswordValid = !string.IsNullOrWhiteSpace(txt_confirmPass.Text);
            bool isPasswordMatched = txt_pass.Text == txt_confirmPass.Text;

            lbl_confirmError.Visible = !isPasswordMatched && isConfirmPasswordValid;

            btn_signup.Enabled = isUserNameValid && isPasswordValid && isConfirmPasswordValid && isPasswordMatched;
        }
        private void txt_confirmPass_Click(object sender, EventArgs e)
        {
            lbl_confirmError.Visible = false;
            if (txt_userName.Text == "")
            {
                lbl_userError.Visible = true;

            }
            else if (txt_pass.Text == "")
            {
                lbl_passError.Visible = true;
            }
        }
        private void pictureBox_Key_MouseDown(object sender, MouseEventArgs e) => txt_pass.UseSystemPasswordChar = false;
        private void pictureBox_Key_MouseUp(object sender, MouseEventArgs e) => txt_pass.UseSystemPasswordChar = true;

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e) => txt_confirmPass.UseSystemPasswordChar = false;
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e) => txt_confirmPass.UseSystemPasswordChar = true;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_userName.Clear();
            txt_pass.Clear();
            txt_confirmPass.Clear();
            btn_signup.Enabled = false;
            lbl_userError.Visible = false;
            lbl_passError.Visible = false;
            lbl_confirmError.Visible = false;
            lbl_signUperrorMsg.Visible = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            ////lbl_signUperrorMsg.Text = "Please fill the Form!";
            //try
            //{
            //    string userName = txt_userName.Text.Trim();
            //    string password = txt_pass.Text.Trim();

            //    //int result = user.AddUser(userName, password);

            //    if (result > 0)
            //    {
            //        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        btn_reset_Click(sender, e);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private void txt_confirmPass_Leave(object sender, EventArgs e)
        //{
        //    if (txt_pass.Text != txt_confirmPass.Text)
        //    {
        //        MessageBox.Show("Passwords do not match! Please make sure you enter the same password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txt_confirmPass.Focus();
        //    }
        //}
    }
}
