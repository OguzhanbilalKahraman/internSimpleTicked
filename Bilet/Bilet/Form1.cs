using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] cities =new string[] {"Ankara","Istanbul","Bursa","Kutahya", " Kastamonu","Kayseri" };
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGidis.Items.Add(cities[0]);
            cmbGidis.Items.Add(cities[1]);
            MessageBox.Show("Suanlik maalesef "+cities.Length+" Ilimize hizmet verebilmekteyiz, sabriniz ve bizi tercih ettiginiz icin  tesekkur ederiz.");

        }

        private void cmbGidis_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbVaris.Items.Clear();
            cmbVaris.Text = "";
            if (cmbGidis.SelectedItem.ToString() == cities[0])
            {
                cmbVaris.Items.Add(cities[2]);
                cmbVaris.Items.Add(cities[3]);

            }
            else
            {
                 cmbVaris.Items.Add(cities[4]);
                 cmbVaris.Items.Add(cities[5]);

            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string gidis = cmbGidis.SelectedItem.ToString();
            string varis = cmbVaris.SelectedItem.ToString();


            MessageBox.Show("Bilet Bilgileriniz: \n Gidis:"+gidis+" Varis:"+varis+" \nBizi Tercih Ettiginiz icin tesekkur ederiz. ");

        }
    }
}
