using u06_genericList;

List<int> liste = new List<int>();

liste.Add(1);//ekle
liste.AddRange(4,7,8);//toplu ekleme extension metot 
liste.Insert(2,14);//index numarası 14
liste.AddRange(new int[]{1,2,3});//mevcut metot

Console.WriteLine($"Listenin Uzunluğu : {liste.Count}");
foreach ( int i in liste )
Console.WriteLine(i);
