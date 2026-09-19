string[] erkek = { "ahmet", "mehmet", "ali", "mustafa", "yasin", "serdar", "kazım", "burak" };
string[] bayan = { "ayşe", "fatma", "elif", "gülşah", "zeynep", "gülay", "buse", "deniz" };
Random rastgele = new Random();
int index = rastgele.Next(0, erkek.Length);
Console.WriteLine(erkek[index]);
Console.WriteLine(bayan[index]);
Console.ReadKey();
