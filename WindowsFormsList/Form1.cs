using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsList
{
    public partial class Form1 : Form
    {
        List<Vozilo> listVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxMarke.Text == "" || txtBoxModel.Text == "" || cmbBoxVrsta.Text == "") {
                MessageBox.Show("Error, neispravan unos");
            } 
            else {
                Vozilo Voz = new Vozilo(txtBoxMarke.Text, txtBoxModel.Text, cmbBoxVrsta.Text);
                listVozila.Add(Voz);
                txtBoxMarke.Clear();
                txtBoxModel.Clear();
                cmbBoxVrsta.Text = "";
                txtBoxMarke.Focus();
            }
        }

        private void bntIspis_Click(object sender, EventArgs e)
        {
            txtBoxIspis.Clear();
            foreach (Vozilo v in listVozila) {
            txtBoxIspis.AppendText(v.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Vozilo v in listVozila)
            {
                if (v.Vrsta == "Avion")
                {
                    v.Vozipo = "Zrak";
                }
                else if (v.Vrsta == "Automobilu")
                {
                    v.Vozipo = "Cesta";
                }
                else if (v.Vrsta == "Brod")
                {
                    v.Vozipo = "Voda";
                }
                else
                {
                    v.Vozipo = "?";
                }
            }
        }
    }
}
