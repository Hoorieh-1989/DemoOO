using DemoOO.Classes;
using System.Windows.Forms;

namespace DemoOO
{
    public partial class FormCreatCustomers : Form
    {
        public FormCreatCustomers()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCreatCustomers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //    Customer customer = new Customer(textBoxName.Text,

        //       TextBoxPhone.Text, TextBoxEmail.Text);
        //    customer.Save();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer(textBoxName.Text,

              TextBoxPhone.Text, TextBoxEmail.Text);
            customer.Save();
        }
    }
}
