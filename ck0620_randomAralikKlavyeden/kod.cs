// ck0620 — Random aralığını klavyeden alma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0610'daki sabit aralığı (0-10) ve sabit adedi (5) burada
//                  kullanıcıdan alıyoruz — Random pekiştirme ailesinin kapanışı.

// --- KAVRAM ---
int min, max, kacAdet;
Random rastgele = new Random();

Console.Write("Kaç sayı tutulacak: ");
kacAdet = Convert.ToInt32(Console.ReadLine());
Console.Write("Tutulacak sayının min değeri: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Tutulacak sayının max değeri: ");
max = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < kacAdet; i++)
{
    int tutulansayi = rastgele.Next(min, max);
    Console.WriteLine("Bilgisayarın tuttuğu sayı: " + tutulansayi);
}
Console.ReadKey();

// --- SEN YAP ---
// max değeri min'den küçük veya eşit girilirse ne olur, dene. Bu durumu (min < max
// olmalı) kontrol eden bir if ekleyip hatalı girişte kullanıcıyı uyar.
