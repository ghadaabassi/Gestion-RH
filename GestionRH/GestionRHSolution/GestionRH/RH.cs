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
    public partial class RH : Form
    {
        public BLL.RH entrep;
        public List<Personnel> personnels;

        public RH()
        {
            InitializeComponent();
            personnels = new List<Personnel>();
            entrep = new BLL.RH("adresse", personnels);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Employe empl = new Employe(0, 0, null, 0, 0, new DateTime(2001, 3, 1));
                AddEmpl addEmpl = new AddEmpl(empl);
                if (addEmpl.ShowDialog() == DialogResult.OK)
                {
                    entrep.personnes.Add(empl);
                    listView1.Clear();
                    foreach (Personnel personnel in entrep.findEmplType(IRH.type.Employe))
                    {
                        listView1.Items.Add(personnel.id.ToString());
                    }
                }
            }

            if (radioButton2.Checked)
            {
                Stagiaire stag = new Stagiaire(null, null, new DateTime(2010, 1, 1), 0, 0, new DateTime(2010, 1, 1));
                AddStagiaire addEmpl = new AddStagiaire(stag);
                if (addEmpl.ShowDialog() == DialogResult.OK)
                {

                    entrep.personnes.Add(stag);
                    listView1.Clear();
                    foreach (Personnel personnel in entrep.findEmplType(IRH.type.Stagiaire))
                    {
                        listView1.Items.Add(personnel.id.ToString());
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)

            {

                label2.Text = "Id: " + entrep.findEmpl(int.Parse(item.Text)).id.ToString();
                label3.Text = "Salaire :" + entrep.findEmpl(int.Parse(item.Text)).salaire.ToString();
                label4.Text = "DateEmbauche: " + entrep.findEmpl(int.Parse(item.Text)).date.ToString();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "Id: ";
                label3.Text = "Salaire :";
                label4.Text = "DateEmbauche: ";
                listView1.Clear();

                foreach (Personnel personnel in entrep.findEmplType(IRH.type.Employe))
                {
                    listView1.Items.Add(personnel.id.ToString());
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                label2.Text = "Id: ";
                label3.Text = "Salaire :";
                label4.Text = "DateEmbauche: ";

                listView1.Clear();
                foreach (Personnel personnel in entrep.findEmplType(IRH.type.Stagiaire))
                {
                    listView1.Items.Add(personnel.id.ToString());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (MessageBox.Show("Delete ?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listView1.Items.Remove(item);
                    entrep.deleteEmpl(int.Parse(item.Text));

                    label2.Text = "Id: ";
                    label3.Text = "Salaire :";
                    label4.Text = "DateEmbauche: ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    EmployeCaract empl = new EmployeCaract((Employe)entrep.findEmpl(int.Parse(item.Text)));
                    empl.Show();
                }

            }
            if (radioButton2.Checked)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    StagCarct stag = new StagCarct((Stagiaire)entrep.findEmpl(int.Parse(item.Text)));
                    stag.Show();

                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
