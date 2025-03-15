using BLL;

namespace PresentationLayer
{
    public partial class SignForm : Form
    {
        UserService US = new UserService();
        AdminDashBoard DBAd = new AdminDashBoard();
        public SignForm()
        {
            InitializeComponent();
            btn_login.Enabled = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            string? role = US.AuthenticateUser(username, password);

            if (role != null)
            {
                AdminDashBoard adminDashBoard = new AdminDashBoard();
                this.Hide();
                adminDashBoard.SetUserTabs(role);
                adminDashBoard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The Username or Password is Incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
