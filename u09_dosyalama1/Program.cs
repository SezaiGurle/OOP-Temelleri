string yol1 = "C:\\Users";
string yol2 = "Belgeler\\dosyalar.txt";

string yol3= Path.Combine(yol1, yol2);//arasına iki tane \\ ekler 

Console.WriteLine(yol3);

Console.WriteLine("DirectoryName:" + Path.GetDirectoryName(yol3));
Console.WriteLine("FileName:" + Path.GetFileName(yol3));
Console.WriteLine("Extension:" + Path.GetExtension(yol3));

