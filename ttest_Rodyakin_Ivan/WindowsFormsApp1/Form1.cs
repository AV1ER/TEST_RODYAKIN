using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnterF : Form
    {
        public EnterF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if ((LoginTextBox.Text == "Admin") && (PasswordTextBox.Text == "12345"))
            {

                Form2 f = new Form2();
                f.Show();
            }
            else MessageBox.Show("Неверный пароль или логин");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.Show();
        }
    }
}
