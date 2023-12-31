namespace GM
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (test.IsValide(textUser.Text, textPass.Text) == false)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                MessageBox.Show("Welcome");
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}