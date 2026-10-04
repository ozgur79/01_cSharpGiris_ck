// BU KOD NE YAPAR?
// Bu kod, 2022'den 2031'e kadar her yıl için kirayı yazar. Kira 1000 TL'den başlar ve
// her yıl %10 artar (while döngüsü, sabit değerlerle).

// ck0545 — while ile kira hesabı (sabit değerler)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: while'ı gerçek bir hesaplama problemine uyguluyoruz — yıl sabit bir
//                  sınıra ulaşana kadar kira her turda yüzde 10 artıyor.

// --- KAVRAM ---
int baslangicYili = 2022;
int bitisYili = 2031;
double kira = 1000;

while (baslangicYili <= bitisYili)
{
    Console.WriteLine("Yıl: " + baslangicYili + " Kira: " + kira);
    kira = kira + (kira * 10 / 100);
    baslangicYili++;
}
Console.ReadKey();

// --- SEN YAP ---
// baslangicYili++ satırını yorum satırı yap (silme), ne olduğunu gözlemle — sonra
// geri aç. Neden bu satır olmadan program asla bitmez?
