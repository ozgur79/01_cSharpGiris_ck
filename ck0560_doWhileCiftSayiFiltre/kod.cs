// ck0560 — do-while + if: çift sayı girildikçe devam
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0555'teki do-while biriktiriciye bir if süzgeci ekliyoruz — sadece
//                  çift sayılar toplama girsin, döngü de tek sayı girilene kadar sürsün.

// --- KAVRAM ---
int sayi, toplam = 0;
do
{
    Console.Write("Analiz edilecek sayıyı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        Console.WriteLine(sayi + " çift, toplama ekleniyor.");
        toplam = toplam + sayi;
    }
} while (sayi % 2 == 0);
Console.WriteLine("Çift sayıların toplamı: " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// Kaç adet çift sayı girildiğini de say (bir sayac değişkeni ekle), sonunda
// "toplam" ile birlikte "kaç sayı" bilgisini de yazdır.
