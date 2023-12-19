﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPP
{
    class Ucenik
    {
        private string ime, prezime, razred;
        private int godinaRodjenja;

        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public string getIme()
        {
            return this.ime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public void setRazred(string razred)
        {
            this.razred = razred;
        }
        public string getRazred()
        {
            return this.razred;
        }
        public void setGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja = godinaRodjenja;
        }
        public int getGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }
        public override string ToString()
        {
            string ispis = "Ime: " + this.ime
                + "\nPrezime: " + this.prezime
                + "\nRazred: " + this.razred
                + "\nGodina rođenja" + this.godinaRodjenja;
            return ispis;
        }

        public Ucenik()
            {

            }

        public Ucenik(string ime, string prezime, string razred, int godinaRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;
            this.godinaRodjenja = godinaRodjenja;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik ucenik = new Ucenik();

            Console.WriteLine("Unesi ime, prezime, razred i godinu rođenja: ");
            string ime = Console.ReadLine();
            string prezime = Console.ReadLine();
            string razred = Console.ReadLine();
            int godinaRodjenja = Convert.ToInt32(Console.ReadLine());

            ucenik.setIme(ime);
            ucenik.setPrezime(prezime);
            ucenik.setRazred(razred);
            ucenik.setGodinaRodjenja(godinaRodjenja);

            Console.WriteLine("Učenik 1");
            Console.WriteLine(ucenik.ToString());
            Console.WriteLine("Učenik 2");
            Console.WriteLine(ucenik.ToString());


            Console.ReadKey();
        }
    }
}
