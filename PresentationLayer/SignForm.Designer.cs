namespace PresentationLayer
{
    partial class SignForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pnl_signup = new Panel();
            btn_reset = new CustomControls.RoundedButton();
            btn_signup = new CustomControls.RoundedButton();
            lbl_signUperrorMsg = new Label();
            panel4 = new Panel();
            txt_confirmPass = new TextBox();
            lbl_confirmError = new Label();
            pictureBox5 = new PictureBox();
            panel_pass = new Panel();
            txt_pass = new TextBox();
            lbl_passError = new Label();
            pictureBox_Key = new PictureBox();
            label2 = new Label();
            panel_userName = new Panel();
            lbl_userError = new Label();
            txt_userName = new TextBox();
            pictureBox_user = new PictureBox();
            label1 = new Label();
            lbl_signup = new Label();
            lbl_signin = new Label();
            pnl_slide = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txt_signinPass = new TextBox();
            lbl_signInPassError = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            lbl_signInUserError = new Label();
            txt_signinName = new TextBox();
            pictureBox4 = new PictureBox();
            lbl_signInerrorMsg = new Label();
            btn_signInReset = new CustomControls.RoundedButton();
            btn_login = new CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            pnl_signup.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Key).BeginInit();
            panel_userName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 76, 245);
            panel1.Controls.Add(pnl_signup);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_signup);
            panel1.Controls.Add(lbl_signin);
            panel1.Controls.Add(pnl_slide);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbl_signInerrorMsg);
            panel1.Controls.Add(btn_signInReset);
            panel1.Controls.Add(btn_login);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(419, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 490);
            panel1.TabIndex = 0;
            // 
            // pnl_signup
            // 
            pnl_signup.Controls.Add(btn_reset);
            pnl_signup.Controls.Add(btn_signup);
            pnl_signup.Controls.Add(lbl_signUperrorMsg);
            pnl_signup.Controls.Add(panel4);
            pnl_signup.Controls.Add(panel_pass);
            pnl_signup.Controls.Add(label2);
            pnl_signup.Controls.Add(panel_userName);
            pnl_signup.Dock = DockStyle.Bottom;
            pnl_signup.Location = new Point(0, 104);
            pnl_signup.Name = "pnl_signup";
            pnl_signup.Size = new Size(421, 386);
            pnl_signup.TabIndex = 0;
            pnl_signup.Visible = false;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.FromArgb(254, 112, 98);
            btn_reset.BorderColor = Color.Transparent;
            btn_reset.BorderRadius = 17;
            btn_reset.BorderSize = 0;
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(215, 248);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(159, 42);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            btn_reset.MouseEnter += btn_reset_MouseEnter;
            btn_reset.MouseLeave += btn_reset_MouseLeave;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(254, 112, 98);
            btn_signup.BorderColor = Color.Transparent;
            btn_signup.BorderRadius = 17;
            btn_signup.BorderSize = 0;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(33, 247);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(159, 42);
            btn_signup.TabIndex = 3;
            btn_signup.Text = "SIGN UP";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            btn_signup.MouseEnter += btn_signup_MouseEnter;
            btn_signup.MouseLeave += btn_signup_MouseLeave;
            // 
            // lbl_signUperrorMsg
            // 
            lbl_signUperrorMsg.AutoSize = true;
            lbl_signUperrorMsg.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signUperrorMsg.ForeColor = Color.DarkRed;
            lbl_signUperrorMsg.Location = new Point(82, 8);
            lbl_signUperrorMsg.Name = "lbl_signUperrorMsg";
            lbl_signUperrorMsg.Size = new Size(19, 25);
            lbl_signUperrorMsg.TabIndex = 0;
            lbl_signUperrorMsg.Text = " ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txt_confirmPass);
            panel4.Controls.Add(lbl_confirmError);
            panel4.Controls.Add(pictureBox5);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(0, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(421, 45);
            panel4.TabIndex = 2;
            // 
            // txt_confirmPass
            // 
            txt_confirmPass.BackColor = Color.White;
            txt_confirmPass.BorderStyle = BorderStyle.None;
            txt_confirmPass.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirmPass.ForeColor = Color.FromArgb(39, 59, 122);
            txt_confirmPass.Location = new Point(62, 12);
            txt_confirmPass.Name = "txt_confirmPass";
            txt_confirmPass.PlaceholderText = "Confirm Password";
            txt_confirmPass.Size = new Size(316, 21);
            txt_confirmPass.TabIndex = 0;
            txt_confirmPass.UseSystemPasswordChar = true;
            txt_confirmPass.Click += txt_confirmPass_Click;
            txt_confirmPass.TextChanged += txt_confirmPass_TextChanged;
            // 
            // lbl_confirmError
            // 
            lbl_confirmError.AutoSize = true;
            lbl_confirmError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_confirmError.ForeColor = Color.Red;
            lbl_confirmError.Location = new Point(393, 8);
            lbl_confirmError.Name = "lbl_confirmError";
            lbl_confirmError.Size = new Size(21, 28);
            lbl_confirmError.TabIndex = 0;
            lbl_confirmError.Text = "!";
            toolTip1.SetToolTip(lbl_confirmError, "Passwords do not match");
            lbl_confirmError.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = InventoryManagmentSystem.PL.Properties.Resources.password_73094821;
            pictureBox5.Location = new Point(15, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += pictureBox5_MouseDown;
            pictureBox5.MouseUp += pictureBox5_MouseUp;
            // 
            // panel_pass
            // 
            panel_pass.BackColor = Color.White;
            panel_pass.Controls.Add(txt_pass);
            panel_pass.Controls.Add(lbl_passError);
            panel_pass.Controls.Add(pictureBox_Key);
            panel_pass.ForeColor = Color.Black;
            panel_pass.Location = new Point(0, 111);
            panel_pass.Name = "panel_pass";
            panel_pass.Size = new Size(421, 45);
            panel_pass.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.White;
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.ForeColor = Color.FromArgb(39, 59, 122);
            txt_pass.Location = new Point(62, 12);
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = "Enter your password\n";
            txt_pass.Size = new Size(316, 21);
            txt_pass.TabIndex = 0;
            txt_pass.UseSystemPasswordChar = true;
            txt_pass.Click += txt_pass_Click;
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // lbl_passError
            // 
            lbl_passError.AutoSize = true;
            lbl_passError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_passError.ForeColor = Color.Red;
            lbl_passError.Location = new Point(393, 8);
            lbl_passError.Name = "lbl_passError";
            lbl_passError.Size = new Size(21, 28);
            lbl_passError.TabIndex = 0;
            lbl_passError.Text = "!";
            toolTip1.SetToolTip(lbl_passError, "Enter your password.");
            lbl_passError.Visible = false;
            // 
            // pictureBox_Key
            // 
            pictureBox_Key.Image = InventoryManagmentSystem.PL.Properties.Resources.password_7309482;
            pictureBox_Key.Location = new Point(15, 11);
            pictureBox_Key.Name = "pictureBox_Key";
            pictureBox_Key.Size = new Size(24, 24);
            pictureBox_Key.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Key.TabIndex = 5;
            pictureBox_Key.TabStop = false;
            pictureBox_Key.MouseDown += pictureBox_Key_MouseDown;
            pictureBox_Key.MouseUp += pictureBox_Key_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 312);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 0;
            label2.Text = "Already have an account?";
            label2.Click += lbl_signin_Click;
            // 
            // panel_userName
            // 
            panel_userName.BackColor = Color.White;
            panel_userName.Controls.Add(lbl_userError);
            panel_userName.Controls.Add(txt_userName);
            panel_userName.Controls.Add(pictureBox_user);
            panel_userName.ForeColor = Color.Black;
            panel_userName.Location = new Point(0, 43);
            panel_userName.Name = "panel_userName";
            panel_userName.Size = new Size(421, 45);
            panel_userName.TabIndex = 0;
            // 
            // lbl_userError
            // 
            lbl_userError.AutoSize = true;
            lbl_userError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_userError.ForeColor = Color.Red;
            lbl_userError.Location = new Point(393, 8);
            lbl_userError.Name = "lbl_userError";
            lbl_userError.Size = new Size(21, 28);
            lbl_userError.TabIndex = 1;
            lbl_userError.Text = "!";
            toolTip1.SetToolTip(lbl_userError, "Enter your username");
            lbl_userError.Visible = false;
            // 
            // txt_userName
            // 
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_userName.ForeColor = Color.FromArgb(39, 59, 122);
            txt_userName.Location = new Point(62, 10);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "Username";
            txt_userName.Size = new Size(316, 25);
            txt_userName.TabIndex = 1;
            txt_userName.Click += txt_userName_Click;
            txt_userName.TextChanged += txt_userName_TextChanged;
            txt_userName.Leave += txt_userName_Leave;
            // 
            // pictureBox_user
            // 
            pictureBox_user.Image = InventoryManagmentSystem.PL.Properties.Resources.person_12047661;
            pictureBox_user.Location = new Point(15, 11);
            pictureBox_user.Name = "pictureBox_user";
            pictureBox_user.Size = new Size(24, 24);
            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_user.TabIndex = 4;
            pictureBox_user.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 401);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Forget Your Password?";
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.Cursor = Cursors.Hand;
            lbl_signup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signup.Location = new Point(216, 65);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(90, 28);
            lbl_signup.TabIndex = 0;
            lbl_signup.Text = "SIGN UP";
            lbl_signup.Click += lbl_signup_Click;
            // 
            // lbl_signin
            // 
            lbl_signin.AutoSize = true;
            lbl_signin.Cursor = Cursors.Hand;
            lbl_signin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signin.Location = new Point(114, 65);
            lbl_signin.Name = "lbl_signin";
            lbl_signin.Size = new Size(85, 28);
            lbl_signin.TabIndex = 0;
            lbl_signin.Text = "SIGN IN";
            lbl_signin.Click += lbl_signin_Click;
            // 
            // pnl_slide
            // 
            pnl_slide.BackColor = Color.White;
            pnl_slide.ForeColor = Color.White;
            pnl_slide.Location = new Point(115, 96);
            pnl_slide.Name = "pnl_slide";
            pnl_slide.Size = new Size(78, 2);
            pnl_slide.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = InventoryManagmentSystem.PL.Properties.Resources.cross;
            pictureBox2.Location = new Point(384, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_signinPass);
            panel2.Controls.Add(lbl_signInPassError);
            panel2.Controls.Add(pictureBox3);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 45);
            panel2.TabIndex = 1;
            // 
            // txt_signinPass
            // 
            txt_signinPass.BackColor = Color.White;
            txt_signinPass.BorderStyle = BorderStyle.None;
            txt_signinPass.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signinPass.ForeColor = Color.FromArgb(39, 59, 122);
            txt_signinPass.Location = new Point(62, 12);
            txt_signinPass.Name = "txt_signinPass";
            txt_signinPass.PlaceholderText = "Enter your password\n";
            txt_signinPass.Size = new Size(316, 21);
            txt_signinPass.TabIndex = 1;
            txt_signinPass.UseSystemPasswordChar = true;
            txt_signinPass.Click += txt_signinPass_Click;
            txt_signinPass.TextChanged += txt_signinPass_TextChanged;
            // 
            // lbl_signInPassError
            // 
            lbl_signInPassError.AutoSize = true;
            lbl_signInPassError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInPassError.ForeColor = Color.Red;
            lbl_signInPassError.Location = new Point(393, 8);
            lbl_signInPassError.Name = "lbl_signInPassError";
            lbl_signInPassError.Size = new Size(21, 28);
            lbl_signInPassError.TabIndex = 0;
            lbl_signInPassError.Text = "!";
            toolTip1.SetToolTip(lbl_signInPassError, "Enter your password.");
            lbl_signInPassError.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = InventoryManagmentSystem.PL.Properties.Resources.password_7309482;
            pictureBox3.Location = new Point(15, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbl_signInUserError);
            panel3.Controls.Add(txt_signinName);
            panel3.Controls.Add(pictureBox4);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(0, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 45);
            panel3.TabIndex = 0;
            // 
            // lbl_signInUserError
            // 
            lbl_signInUserError.AutoSize = true;
            lbl_signInUserError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInUserError.ForeColor = Color.Red;
            lbl_signInUserError.Location = new Point(393, 8);
            lbl_signInUserError.Name = "lbl_signInUserError";
            lbl_signInUserError.Size = new Size(21, 28);
            lbl_signInUserError.TabIndex = 1;
            lbl_signInUserError.Text = "!";
            toolTip1.SetToolTip(lbl_signInUserError, "Enter your username");
            lbl_signInUserError.Visible = false;
            // 
            // txt_signinName
            // 
            txt_signinName.BorderStyle = BorderStyle.None;
            txt_signinName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signinName.ForeColor = Color.FromArgb(39, 59, 122);
            txt_signinName.Location = new Point(62, 11);
            txt_signinName.Name = "txt_signinName";
            txt_signinName.PlaceholderText = "Username";
            txt_signinName.Size = new Size(316, 25);
            txt_signinName.TabIndex = 1;
            toolTip1.SetToolTip(txt_signinName, "Enter your username.");
            txt_signinName.Click += txt_signinName_Click;
            txt_signinName.TextChanged += txt_signinName_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = InventoryManagmentSystem.PL.Properties.Resources.person_12047661;
            pictureBox4.Location = new Point(15, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lbl_signInerrorMsg
            // 
            lbl_signInerrorMsg.AutoSize = true;
            lbl_signInerrorMsg.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInerrorMsg.ForeColor = Color.DarkRed;
            lbl_signInerrorMsg.Location = new Point(82, 127);
            lbl_signInerrorMsg.Name = "lbl_signInerrorMsg";
            lbl_signInerrorMsg.Size = new Size(19, 25);
            lbl_signInerrorMsg.TabIndex = 0;
            lbl_signInerrorMsg.Text = " ";
            lbl_signInerrorMsg.Visible = false;
            // 
            // btn_signInReset
            // 
            btn_signInReset.BackColor = Color.FromArgb(254, 112, 98);
            btn_signInReset.BorderColor = Color.Transparent;
            btn_signInReset.BorderRadius = 17;
            btn_signInReset.BorderSize = 0;
            btn_signInReset.FlatAppearance.BorderSize = 0;
            btn_signInReset.FlatStyle = FlatStyle.Flat;
            btn_signInReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_signInReset.ForeColor = Color.White;
            btn_signInReset.Location = new Point(215, 337);
            btn_signInReset.Name = "btn_signInReset";
            btn_signInReset.Size = new Size(159, 42);
            btn_signInReset.TabIndex = 6;
            btn_signInReset.Text = "RESET";
            btn_signInReset.UseVisualStyleBackColor = false;
            btn_signInReset.Click += btn_signInReset_Click;
            btn_signInReset.MouseEnter += btn_signInReset_MouseEnter;
            btn_signInReset.MouseLeave += btn_signInReset_MouseLeave;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(254, 112, 98);
            btn_login.BorderColor = Color.Transparent;
            btn_login.BorderRadius = 17;
            btn_login.BorderSize = 0;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(33, 336);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(159, 42);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOG IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseEnter += btn_login_MouseEnter;
            btn_login.MouseLeave += btn_login_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = InventoryManagmentSystem.PL.Properties.Resources._12085707_20944201;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 490);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(840, 490);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_signup.ResumeLayout(false);
            pnl_signup.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel_pass.ResumeLayout(false);
            panel_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Key).EndInit();
            panel_userName.ResumeLayout(false);
            panel_userName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_signin;
        private Panel pnl_slide;
        private Label lbl_signup;
        private Label label1;
        private Panel pnl_signup;
        private Panel panel_pass;
        private TextBox txt_pass;
        private Label lbl_passError;
        private PictureBox pictureBox_Key;
        private Label label2;
        private Panel panel_userName;
        private Label lbl_userError;
        private TextBox txt_userName;
        private PictureBox pictureBox_user;
        private Panel panel2;
        private TextBox txt_signinPass;
        private Label lbl_signInPassError;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label lbl_signInUserError;
        private TextBox txt_signinName;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox txt_confirmPass;
        private Label lbl_confirmError;
        private PictureBox pictureBox5;
        private Label lbl_signUperrorMsg;
        private Label lbl_signInerrorMsg;
        private ToolTip toolTip1;
        private CustomControls.RoundedButton btn_signup;
        private CustomControls.RoundedButton btn_reset;
        private CustomControls.RoundedButton btn_signInReset;
        private CustomControls.RoundedButton btn_login;
    }
}