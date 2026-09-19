// ck0695 — Dizi + Random + biriktirme: toplamı son elemana koyma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0350'deki biriktirici (toplam) tekniğini burada dizi doldururken
//                  kullanıyoruz — 4 elemanlık dizinin ilk 3'ü rastgele, son eleman
//                  (indis 3) bu üçünün toplamı.

// --- KAVRAM ---
int toplam = 0;
int[] sayilar = new int[4];
Random rastgele = new Random();
for (int i = 0; i < 3; i++)
{
    int rasgele = rastgele.Next(0, 10);
    sayilar[i] = rasgele;
    toplam = toplam + rasgele;
}
sayilar[3] = toplam;

for (int i = 0; i < 4; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();

// --- SEN YAP ---
// Dizi boyutunu 6 yap, ilk 5 elemanı rastgele üret, 6.'yı (son) toplamları tut.
