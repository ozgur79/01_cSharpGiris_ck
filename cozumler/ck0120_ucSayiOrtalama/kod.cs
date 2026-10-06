// ck0120 SEN YAP çözümü
// 1) Üç değişkenli sürüm
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

// 2) Tek değişkenli sürüm (ayrı bir projede dene; üstteki ile aynı anda yapıştırma)
int sayi;

Console.Write("1. sayıyı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayıyı girin: ");
sayi = sayi + Convert.ToInt32(Console.ReadLine());

Console.Write("3. sayıyı girin: ");
sayi = sayi + Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ortalama: " + sayi / 3);

Console.ReadKey();

// Neden çalışır: sayi = sayi + ... satırında önce sağ taraf hesaplanır (eski sayi + yeni okunan),
// sonuç sayi'ya yazılır. Eski değer kaybolmaz, toplamın içine girmiştir. 7, 8, 10 -> 7, 15, 25 -> 25/3 = 8.
