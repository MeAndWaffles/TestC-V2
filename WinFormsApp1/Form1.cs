using TestProject1.Tests;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string language = textBox1.Text;
            string product = textBox2.Text;

            if (!string.IsNullOrEmpty(language) && !string.IsNullOrEmpty(product))
            {
                UnitTest1 tests = new UnitTest1();
                string result = tests.TakePrice("https://www.amazon.com/", language, product);


                Form2 form2 = new Form2(result);

                // Відображаємо Form2
                form2.ShowDialog();
                //MessageBox.Show(result, "Product price in search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Both fields must be filled. Friend.");
            }
        }
    }
}