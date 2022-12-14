using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciranje objekta
            Osoba osoba = new Osoba();

            // pozivanje set metoda
            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodRodjenja(2005);
            osoba.SetVisina(179);
            osoba.SetTezina(89);
            osoba.SetSpol('M');

            // ispis podataka
            Console.WriteLine("Osoba1");
            Console.WriteLine("Ime i prezime: " + osoba.GetIme() + " " + osoba.GetPrezime()
                + "\r\nGodina rođenja: " + osoba.GetGodRodjenja()
                + "\r\nVisina: " + osoba.GetVisina()
                + "\r\nTežina: " + osoba.GetTezina()
                + "\r\nSpol: " + osoba.GetSpol());

            // instanciranje objekta 2
            Osoba osoba2 = new Osoba("Ana", "Anić", 2001, 164, 62, 'Ž');

            Console.WriteLine("\r\nOsoba2");
            Console.WriteLine(osoba2.Ispis());

            Console.WriteLine("\r\nOsoba 2 - override");
            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();

        }
    }

    class Osoba
    {
        // svojstva
        string ime, prezime;
        int godRodjenja, visina, tezina;
        char spol;

        // metode

        //set metode - služe za postavljanje vrijednosti svojstva
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void SetGodRodjenja(int godRodjenja)
        {
            this.godRodjenja = godRodjenja;
        }
        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void SetSpol(char spol)
        {
            this.spol = spol;
        }

        //get metode - služe za čitanje vrijednosti svojstava
        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetGodRodjenja()
        {
            return this.godRodjenja;
        }
        public int GetVisina()
        {
            return this.visina;
        }
        public int GetTezina()
        {
            return this.tezina;
        }
        public char GetSpol()
        {
            return this.spol;
        }

        // metode za ispis
        public string Ispis()
        {
            string ispis = "Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rođenja: " + this.GetGodRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTežina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();
            return ispis;
        }

        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rođenja: " + this.GetGodRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTežina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();
            return ispis;
        }

        // konstruktori
        public Osoba()
        {

        }
        public Osoba(string ime, string prezime, int godRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodjenja = godRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;

        }

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
