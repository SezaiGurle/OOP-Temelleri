using u02_polymorphism;

Sekil sekil1 = new Sekil();

Sekil sekil2 = new Kare() {AKenari = 5};

Sekil sekil3 = new Dortgen() {AKenari = 3, Bkenari = 4};

Console.WriteLine($"Şekil1'in Alani: {sekil1.AlaniHesapla()}");
Console.WriteLine($"Şekil2'in Alani: {sekil2.AlaniHesapla()}");
Console.WriteLine($"Şekil3'in Alani: {sekil3.AlaniHesapla()}");