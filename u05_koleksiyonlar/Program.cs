using System.Collections;
using System.ComponentModel;
using u05_koleksiyonlar;

ArrayList arrayList = new ArrayList();

arrayList.Add(3);
arrayList.Add("Btk");
arrayList.Add(true);
arrayList.Add(new Personel() {Ad = "Kerem", Soyad = "Koyuncu"});

Personel p = (Personel)arrayList[3];
int sayi = (int)arrayList[0];

arrayList.RemoveAt(2);

foreach(var elem in arrayList)
{
    Console.WriteLine(elem);
}