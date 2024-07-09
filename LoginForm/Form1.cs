namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username= textBox1.Text;
            String password= textBox2.Text;
            MessageBox.Show("Username entered: " + username + "\n" + "Password entered: " + password);

            
        }
    }
}
