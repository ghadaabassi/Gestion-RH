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
    public partial class AddStagiaire : Form
    {
        public Stagiaire stag;
        Random rnd = new Random();
        public AddStagiaire(Stagiaire stag)
        {
            InitializeComponent();
            this.stag = stag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stag.id = rnd.Next(1, 300); ;
            stag.salaire = decimal.Parse(textBox2.Text);
            DateTime dt = new DateTime(int.Parse(textBox3.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            stag.date = dt;
            stag.pfe = textBox6.Text;
            stag.encadrant = textBox4.Text;
            DateTime dt1 = new DateTime(int.Parse(textBox5.Text), int.Parse(textBox10.Text), int.Parse(textBox9.Text));
            stag.DateValidite = dt1;

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
