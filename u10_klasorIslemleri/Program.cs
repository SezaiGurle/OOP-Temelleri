string[] klasorler = Directory.GetDirectories("C:\\");

foreach(string klasor in klasorler)
{
    Console.WriteLine(klasor);
}

Directory.CreateDirectory("C:\\BTKAkademi");