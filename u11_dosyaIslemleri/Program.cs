﻿string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string btkYolu = Path.Combine(masaustuYolu,"BTK");
string dosyaYolu = Path.Combine(btkYolu,"belge.txt");

File.WriteAllText(dosyaYolu,"Merhaba Dünya!!");

File.AppendAllText(dosyaYolu,"\nBu satır sonradan eklendi");

string icerik = File.ReadAllText(dosyaYolu);

Console.WriteLine("İçerik:"+icerik);

if(!Directory.Exists("C\\BTKAkademi"))
    Directory.CreateDirectory("C\\BTKAkademi");
    
File.Copy(dosyaYolu, "C\\BTKAkademi\\belge.txt");