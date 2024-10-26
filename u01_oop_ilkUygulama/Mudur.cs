namespace u01_oop_ilkUygulama;

//Kalıtım
public class Mudur : Personel
{
    private int calisanSayisi = 0;
    Personel[] calisanlar = new Personel[10];
    public Mudur(int id): base(id) //önce Personel oluşturulsun
    {
        Console.WriteLine("Müdür yapici methodu çalisti.");
    }

    public void CalisanEkle(Personel p)
    {
        if(calisanSayisi>=calisanlar.Length)
        {
            Console.WriteLine("Yeni personle eklenemez. Sinir doldu.");
        }
        calisanlar[calisanSayisi] = p;
        calisanSayisi++;
    }

    public void CalisanlariListele()
    {
        Console.WriteLine($"{Ad} {Soyad} altinda çalişan personleller:");
        for(int i=0; i < calisanSayisi;i++)
        {
            calisanlar[i].Yazdir();
        }
    }
    public override void Yazdir() //virtual ---> override
    {
        Console.WriteLine($"{Id} - {Ad} - Müdür");
    }
}