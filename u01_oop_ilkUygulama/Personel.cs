using System;

namespace u01_oop_ilkUygulama
{
    class Personel
    {
        //Fields(alanlar)
        private int id;
        private string ad;
        private string soyad;

        //Properties(Özellikler)
        public int Id { get { return id; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }

        //Constructor (Yapıcı Methodlar)
        public Personel(int personelId)
        {
            id = personelId;
        }

        //Methods (Methodlar)
        public void Yazdir()
        {
            Console.WriteLine($"{id}-{ad}-{soyad}");
        }
    }


}
