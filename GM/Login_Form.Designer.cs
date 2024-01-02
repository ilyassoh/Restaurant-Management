
namespace GM
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            textUser = new TextBox();
            textPass = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            username = new Label();
            password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.BorderStyle = BorderStyle.None;
            textUser.Location = new Point(85, 258);
            textUser.Margin = new Padding(2);
            textUser.Multiline = true;
            textUser.Name = "textUser";
            textUser.Size = new Size(252, 28);
            textUser.TabIndex = 0;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPass
            // 
            textPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textPass.BorderStyle = BorderStyle.None;
            textPass.Location = new Point(85, 348);
            textPass.Margin = new Padding(2);
            textPass.Multiline = true;
            textPass.Name = "textPass";
            textPass.Size = new Size(252, 28);
            textPass.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Gold;
            buttonLogin.Location = new Point(85, 466);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(99, 44);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Gold;
            buttonExit.Location = new Point(245, 466);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(92, 44);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(85, 226);
            username.Margin = new Padding(2, 0, 2, 0);
            username.Name = "username";
            username.Size = new Size(75, 20);
            username.TabIndex = 4;
            username.Text = "Username";
            username.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(85, 317);
            password.Margin = new Padding(2, 0, 2, 0);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 5;
            password.Text = "Password";
            password.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(117, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(431, 556);
            Controls.Add(pictureBox1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textPass);
            Controls.Add(textUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //# private void label1_Click(object sender, EventArgs e)
        //#{
        //# throw new NotImplementedException();
        //#   }

        #endregion

        private TextBox textUser;
        private TextBox textPass;
        private Button buttonLogin;
        private Button buttonExit;
        private Label username;
        private Label password;
        private PictureBox pictureBox1;
    }
}