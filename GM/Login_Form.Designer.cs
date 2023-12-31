
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
            textUser = new TextBox();
            textPass = new TextBox();
            buttonLogin = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Location = new Point(235, 199);
            textUser.Name = "textUser";
            textUser.Size = new Size(200, 39);
            textUser.TabIndex = 0;
            // 
            // textPass
            // 
            textPass.Location = new Point(235, 373);
            textPass.Name = "textPass";
            textPass.Size = new Size(200, 39);
            textPass.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(259, 561);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 46);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 640);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 161);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 333);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 890);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(buttonLogin);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Margin = new Padding(5);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Form_Load;
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
        private Button button2;
        private Label label1;
        private Label label2;
    }
}