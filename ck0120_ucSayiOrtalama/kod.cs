// ck0120 — Üç sayının ortalaması
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: pekiştirme — üç sayıyı toplayıp parantez içine alarak 3'e bölme, ck0060'ta
//                  gördüğümüz int bölmesinin küsuratı attığı kuralını hatırlama.

// --- KAVRAM ---
int s1, s2, s3, ortalama;
Console.Write("1. sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3. sayıyı girin: ");
s3 = Convert.ToInt32(Console.ReadLine());
ortalama = (s1 + s2 + s3) / 3; // parantez olmadan önce s3/3 hesaplanırdı, o yüzden şart
Console.WriteLine("Ortalama: " + ortalama);
Console.ReadKey();

// --- SEN YAP ---
// Toplamı 3'e tam bölünmeyen üç sayı gir (örn. 7, 8, 10). Çıkan sonucu hesap makineniyle
// bulduğun gerçek ortalamayla karşılaştır — ck0060'ı hatırlayarak aradaki farkı açıkla.

// --- MERAK KÖŞESİ ---
// static Main içindeki satırlar hep yukarıdan aşağı mı çalışır?
// ck0050'de static Main'in, class Program'ın içinde programın başladığı satır olduğunu
// söylemiştik. Başladığı yer orası ama devamında satırlar tam yazıldığı sırayla çalışır —
// bu yüzden bu derste önce s1, s2, s3 okunuyor, ortalama ancak üçü de okunduktan sonra
// hesaplanabiliyor. Sırayı bozarsan (ortalamayı s3'ten önce hesaplarsan) kod çalışmaz.
// Ayrıntı: ünite 07.
