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
    public partial class StagCarct : Form
    {
        public Stagiaire stag;
        public StagCarct(Stagiaire stag)
        {
            InitializeComponent();
            this.stag = stag;
            label5.Text = stag.pfe;
            label6.Text = stag.encadrant;
            label7.Text = stag.date.ToString();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
