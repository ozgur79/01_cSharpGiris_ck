// ck0170 SEN YAP çözümü
int en, boy;
Console.Write("Dörtgenin enini girin : ");
en = Convert.ToInt32(Console.ReadLine());
Console.Write("Dörtgenin boyunu girin : ");
boy = Convert.ToInt32(Console.ReadLine());

int cevre = (en + boy) * 2;
int alan = en * boy;

if (en == boy)
    Console.WriteLine("Karedir");
else
    Console.WriteLine("Dikdörtgendir");
Console.WriteLine("Çevre: " + cevre);
Console.WriteLine("Alan: " + alan);
Console.ReadKey();

// en=7, boy=7: "Karedir", Çevre: 28, Alan: 49
// en=7, boy=9: "Dikdörtgendir", Çevre: 32, Alan: 63
