// ck0555 — do-while ile biriktirici (0 girilene kadar)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0350'deki biriktirici (+=) tekniği burada do-while ile birlikte —
//                  kullanıcı 0 girene kadar sayı istemeye devam ediyoruz.

// --- KAVRAM ---
int toplam = 0;
int sayi;
do
{
    Console.Write("Sayı girin (çıkmak için 0): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi;
} while (sayi != 0);
Console.WriteLine("Genel toplam: " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// toplam'a sadece POZİTİF sayıları ekle (0 girilince yine çıkılsın, ama negatif
// sayılar toplama katılmasın — ipucu: toplama ekleme satırını if içine al).
