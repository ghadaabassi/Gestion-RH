using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionRH
{
    public partial class AddEmpl : Form
    {
        public Employe employe;
        Random rnd = new Random();
        public AddEmpl(Employe empl)
        {
            InitializeComponent();
            this.employe = empl;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employe.id = rnd.Next(1, 300);
            employe.salaire = decimal.Parse(textBox2.Text);
            DateTime dt = new DateTime(int.Parse(textBox3.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            employe.date = dt;
            employe.expr = decimal.Parse(textBox6.Text);
            employe.chef = int.Parse(textBox4.Text);
            employe.techno = textBox5.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
