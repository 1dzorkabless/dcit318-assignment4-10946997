using System.Windows.Forms;

namespace SimpleAddressBook
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phonenumber = textBox3.Text;

            // Create a string to save
            string information = $"Name: {name}, Email: {email}, Phone: {phonenumber}";

            // Save the information to a file
            string filePath = "saved_info.txt";

            try
            {
                File.WriteAllText(filePath, information);
                MessageBox.Show("Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
