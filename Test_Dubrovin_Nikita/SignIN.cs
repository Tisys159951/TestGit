using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Dubrovin_Nikita
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "user1" && textBox2.Text == "1234")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
             else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Недопустимо наличие пустых полей или неверный логин или пароль");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            SignUP a = new SignUP();
            a.ShowDialog();
        
        }
    }
}
