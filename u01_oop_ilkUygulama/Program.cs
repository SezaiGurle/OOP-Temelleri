using u01_oop_ilkUygulama;

Personel p1 = new Personel(1);
p1.Ad = "Hasan";
p1.Soyad = "Demir";

Personel p2 = new Personel(2) {Ad = "Ayşe", Soyad="Can"};

Console.WriteLine("Personel 1'in bilgileri:");
p1.Yazdir();
Console.WriteLine("\n\nPersonel 2'nin bilgileri:");
p2.Yazdir();
