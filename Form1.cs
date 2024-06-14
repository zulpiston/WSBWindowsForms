using System.Data;
using System.ComponentModel;
using WarsztatSamochodowy.Dane;

namespace GuiWarsztat
{
    public partial class Form1 : Form
    {
        Ustawienia ustawienia = new Ustawienia();
        public Form1()
        {
            InitializeComponent();
            ustawienia.stanowiskaPracy.Add(new Stanowisko { idStanowiska = 0, nazwaStanowiska = "Lakiernia" });
            ustawienia.stanowiskaPracy.Add(new Stanowisko { idStanowiska = 1, nazwaStanowiska = "Elektryka" });
            ustawienia.stanowiskaPracy.Add(new Stanowisko { idStanowiska = 2, nazwaStanowiska = "Mechanika" });
            ustawienia.stanowiskaPracy.Add(new Stanowisko { idStanowiska = 3, nazwaStanowiska = "Klima" });

            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 1,
                CzasOd = DateTime.Now.Add(TimeSpan.FromHours(-2)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromHours(2)),
                Nazwa = "Polerowanie lakieru",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[1],
                Kto = new Cz³owiek { Imiê = "Adam", Nazwisko = "Gêœ" },
                Pojazd = new Samochod { Marka = "Fiat", Model = "Multipla" }
            });


            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 2,
                CzasOd = DateTime.Now.Add(TimeSpan.FromHours(-4)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromHours(-1)),
                Nazwa = "Wymiana oleju",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[2],
                Kto = new Cz³owiek { Imiê = "Krzysztof", Nazwisko = "Nowak" },
                Pojazd = new Samochod { Marka = "Toyota", Model = "Corolla" }
            });

            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 3,
                CzasOd = DateTime.Now.Add(TimeSpan.FromDays(3)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromDays(3)),
                Nazwa = "Naprawa hamulców",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[0],
                Kto = new Cz³owiek { Imiê = "Micha³", Nazwisko = "Kowalski" },
                Pojazd = new Samochod { Marka = "Honda", Model = "Civic" }
            });

            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 4,
                CzasOd = DateTime.Now.Add(TimeSpan.FromHours(-1)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromHours(3)),
                Nazwa = "Serwis klimatyzacji",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[3],
                Kto = new Cz³owiek { Imiê = "Anna", Nazwisko = "Wiœniewska" },
                Pojazd = new Samochod { Marka = "Volkswagen", Model = "Passat" }
            });

            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 5,
                CzasOd = DateTime.Now.Add(TimeSpan.FromHours(-5)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromHours(-2)),
                Nazwa = "Diagnostyka silnika",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[1],
                Kto = new Cz³owiek { Imiê = "Ewa", Nazwisko = "Sikorska" },
                Pojazd = new Samochod { Marka = "Ford", Model = "Focus" }
            });

            ustawienia.mojKalendarz.Add(new Zdarzenie
            {
                idZdarzenia = 6,
                CzasOd = DateTime.Now.Add(TimeSpan.FromHours(-6)),
                CzasDo = DateTime.Now.Add(TimeSpan.FromHours(-3)),
                Nazwa = "Wymiana klocków hamulcowych",
                StanowiskoRobocze = ustawienia.stanowiskaPracy[2],
                Kto = new Cz³owiek { Imiê = "Robert", Nazwisko = "Wójcik" },
                Pojazd = new Samochod { Marka = "Mazda", Model = "6" }
            });


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Warsztat samochodowy. {DateTime.Today.ToString("dd MMM yyyy")}";
        }

        private void tSStanowiska_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            UCStanowiska UCstanowiska = new UCStanowiska(ustawienia);
            UCstanowiska.Parent = this.panel1;

            UCstanowiska.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            UCKalendarz uCKalendarz = new UCKalendarz(ustawienia);
            uCKalendarz.dataGridView1.AutoGenerateColumns = true;
            uCKalendarz.Parent = this.panel1;

            
        }
    }
}
