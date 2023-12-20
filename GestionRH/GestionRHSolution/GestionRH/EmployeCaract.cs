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
    public partial class EmployeCaract : Form
    {
        public Employe empl;
        public EmployeCaract(Employe empl)
        {
            InitializeComponent();
            this.empl = empl;
            label5.Text = empl.expr.ToString();
            label6.Text = empl.chef.ToString();
            label7.Text = empl.techno.ToString();



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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
