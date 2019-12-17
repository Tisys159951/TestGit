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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SignIN a = new SignIN();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Недопустимо наличие пустых полей ");
            }

            else
            {
                Form3 s = new Form3();
                s.Show();
                this.Hide();
            }

            }
        }
    }
