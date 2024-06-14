using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarsztatSamochodowy.Dane;

namespace GuiWarsztat
{
    public partial class UCStanowiska : UserControl
    {
        Ustawienia ustawienia;
        public UCStanowiska(Ustawienia _ustawienia)
        {
            InitializeComponent();
            ustawienia = _ustawienia;
            this.wyswietlDane();

        }

        private void wyswietlDane()
        {
            listBox1.Items.Clear();
            foreach (var item in ustawienia.stanowiskaPracy)
            {
                string wartosc = $"{item.idStanowiska}. {item.nazwaStanowiska}";
                listBox1.Items.Add(wartosc);
            }
            numericUpDown1.Value = ustawienia.stanowiskaPracy.Count;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ustawienia.stanowiskaPracy.Count >= 5)
            {
                MessageBox.Show("Osiagnięto maksymalną liczbę stanowisk.");
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stanowisko noweStanowisko = new Stanowisko();
            noweStanowisko.idStanowiska = ustawienia.stanowiskaPracy.Count + 1;
            noweStanowisko.nazwaStanowiska = txtStanowisko.Text;
            ustawienia.stanowiskaPracy.Add(noweStanowisko);
            panel2.Visible = false;
            this.wyswietlDane();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var zaznaczony = listBox1.SelectedIndex;
            if (zaznaczony == -1) {
                MessageBox.Show("Zaznacz element do usunięcia");
            }
            else
            {
                ustawienia.stanowiskaPracy.RemoveAt(zaznaczony);
                this.wyswietlDane();
            }
            
        }
    }
}
