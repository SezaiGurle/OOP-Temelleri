using System;
using System.Net.NetworkInformation;
using u02_polymorphism;

namespace u02_polymorphism
{
    public class Sekil
    {
        protected double pi = 3.14;
        public virtual double AlaniHesapla()
        {
            return 0;
        }
    }
}

public class Kare : Sekil
{
    public double AKenari { get; set; }// auto property
    public override double AlaniHesapla()
    {
        return AKenari * AKenari;
    }
}

public class Dortgen : Kare
{
    public double Bkenari { get; set;}
    public override double AlaniHesapla()
    {
        return AKenari * Bkenari;
    }
}

public class Cember : Sekil 
{
    public double YariCap {get; set;}
    public override double AlaniHesapla()
    {
        return pi* YariCap* YariCap ;
    }
}