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
    public partial class UCKalendarz : UserControl
    {
        private Ustawienia mojeUstawienia;
        public UCKalendarz(Ustawienia ustawienia)
        {
            InitializeComponent();
            mojeUstawienia = ustawienia;
            PokazTabele(mojeUstawienia.mojKalendarz);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt = e.Start;
            var filtrowaneDane = mojeUstawienia.mojKalendarz
                .Where(f => f.CzasOd.Date <= dt && f.CzasDo.Date >= dt).ToList();
            PokazTabele(filtrowaneDane);

        }

        private void PokazTabele(List<Zdarzenie> dane)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("idZdarzenia", typeof(int));
            dt.Columns.Add("Nazwa", typeof(string));
            dt.Columns.Add("CzasOd", typeof(DateTime));
            dt.Columns.Add("CzasDo", typeof(DateTime));
            dt.Columns.Add("Kto", typeof(string));
            dt.Columns.Add("Pojazd", typeof(string));
            dt.Columns.Add("Stanowisko", typeof(string));


            foreach (Zdarzenie zd in dane)
            {
                dt.Rows.Add(zd.idZdarzenia, zd.Nazwa, zd.CzasOd, zd.CzasDo, (string)($"{zd.Kto.Nazwisko} {zd.Kto.Imię}"), (string)($"{zd.Pojazd.Marka}-{zd.Pojazd.Model}"), zd.StanowiskoRobocze.nazwaStanowiska);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wybraneStanowisko = textBox1.Text;
            //TO jest linq query
            var filtrowaneDane = mojeUstawienia.mojKalendarz
                .Where(f => f.StanowiskoRobocze.nazwaStanowiska.StartsWith(wybraneStanowisko)).ToList();
            PokazTabele(filtrowaneDane);
        }
    }
}
