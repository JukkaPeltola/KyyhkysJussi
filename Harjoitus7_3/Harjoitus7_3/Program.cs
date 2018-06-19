﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class KulkuValine
{
    protected string tyyppi;
    protected string merkki;
    protected int vuosiMalli;
    protected double hinta;

    public KulkuValine(string tyyppi, string merkki, int vuosiMalli, double hinta)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
    }
    public KulkuValine()
    {
        tyyppi = "Ei tiedossa!";
        merkki = "Ei tiedossa!";
        vuosiMalli = 0;
        hinta = 0;
    }
    public KulkuValine(KulkuValine kulkuvaline)
    {
        tyyppi = kulkuvaline.tyyppi;
        merkki = kulkuvaline.merkki;
        vuosiMalli = kulkuvaline.vuosiMalli;
        hinta = kulkuvaline.hinta;

    }
    public virtual void TulostaTiedot()
    {
        Console.WriteLine("Auton tiedot: " + "\n---------------");
        Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi);
        Console.WriteLine("Ajoneuvon merkki: " + merkki);
        Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
        Console.WriteLine("AJoneuvon hinta: " + hinta + "\n");

    }


}

class Auto : KulkuValine
{
    protected int koneenKoko;
    protected string malli;
    protected int ovienLkm;

    public Auto() : base()
    {
        koneenKoko = 0;
        malli = "Ei tiedossa! ";
        ovienLkm = 0;

    }
    public Auto (string tyyppi, string merkki, int vuosimalli, double hinta, int koneenKoko, string malli, int ovienLkm)
        : base (tyyppi, merkki, vuosimalli, hinta)

    {
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;

    }
    public Auto(Auto auto)
    {
        koneenKoko = auto.koneenKoko;
        malli = auto.malli;
        ovienLkm = auto.ovienLkm;

    }
    public override void TulostaTiedot()
    {
        Console.WriteLine("Auton tiedot: " + "\n---------------");
        Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi);
        Console.WriteLine("Ajoneuvon merkki: " + merkki);
        Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
        Console.WriteLine("AJoneuvon hinta: " + hinta + "\n");
        Console.WriteLine("Auton lisätiedot: ");
        Console.WriteLine("--------------");

        Console.WriteLine("Koneen koko: " + koneenKoko + " litraa");
        Console.WriteLine("Ajoneuvon malli: " + malli);
        Console.WriteLine("Ovien lukumäärä: " + ovienLkm);

    }


    public override string ToString()
    {
        return "Ovien lukumäärä: " + ovienLkm;
    }

    public override bool Equals(object obj)
    {
        if (this.koneenKoko == ((Auto)obj).koneenKoko)
            return true;
        else return false;

    }

}

namespace Harjoitus7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Auto", "Audi", 2005, 10500,2,"A7",4);

            auto.TulostaTiedot();

            Auto auto2 = new Auto("Auto", "Volvo", 2010, 12300, 2, "V4", 4);

            Console.WriteLine("\nToisen auton tiedot: \n");

            auto2.TulostaTiedot();

            auto.ToString();

            Console.WriteLine("\nKoneen koon vertailu: " + auto.Equals(auto2));

        }
    }
}

