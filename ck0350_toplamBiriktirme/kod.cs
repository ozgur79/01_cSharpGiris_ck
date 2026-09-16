// ck0350 — Toplam biriktirme: 0 girilince çıkış
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: "biriktirici" deseni — döngü dışında tanımlanan `toplam` her turda
//                  `+=` ile büyütülür; 0 girilirse (özel/sentinel bir değer) break ile
//                  döngüden çıkılır. Not: 0 dışında bir yazı (ör. "abc") girilirse
//                  program çöker — bu kırılganlığı ck0360'ta düzelteceğiz.

// --- KAVRAM ---
int toplam = 0;
for (;;)
{
    Console.Write("Bir sayı girin (çıkmak için sıfır girin): ");
    int girilenSayi = Convert.ToInt32(Console.ReadLine());
    if (girilenSayi == 0)
        break;
    toplam += girilenSayi;
}
Console.WriteLine("Girilen sayıların toplamı: " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// 5, 3, 7, 0 sırasıyla gir — toplam 15 çıkmalı. Sonra baştan çalıştırıp bir sayı yerine
// "abc" yaz, ne olduğunu gözlemle (program hata verip kapanacak).
