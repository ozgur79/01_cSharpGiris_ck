// ck0120 SEN YAP çözümü
int s1, s2, s3, ortalama;
Console.Write("1. sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3. sayıyı girin: ");
s3 = Convert.ToInt32(Console.ReadLine());
ortalama = (s1 + s2 + s3) / 3;
Console.WriteLine("Ortalama (int, küsurat atılır): " + ortalama);
Console.ReadKey();

// Örnek: 7, 8, 10 gir -> toplam 25, 25/3 = 8 (gerçek ortalama 8.33, küsurat kayboldu).
