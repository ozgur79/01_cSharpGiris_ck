// ck0330 — 15'e bölünebilirlik: %3 + %5 + && bir arada
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayı 3'e VE 5'e aynı anda kalansız bölünüyorsa 15'e de kalansız
//                  bölünür — bunu && ile iki % kontrolünü birleştirerek sınamak.
// Not: Bu programda break yok, sonsuz döngü hiç kendiliğinden bitmez — denemeyi bitirmek
//      için Visual Studio'nun üstündeki kırmızı kare (Durdur) butonuna bas.

// --- KAVRAM ---
for (; ; ) // parantez içi boş: başlangıç/koşul/adım yok, bu döngü kendiliğinden bitmez
{
    Console.Write("Sayı Girin : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 3 == 0 && sayi % 5 == 0)
        Console.WriteLine(sayi + " sayısı 15'e kalansız bölünebilir");
    else
        Console.WriteLine(sayi + " sayısı 15'e kalansız bölünemez");
}

// --- SEN YAP ---
// 15, 7, 30 ve 9 ile sırayla dene. Hangileri "bölünebilir" diyor? 3'e bölünen ama 5'e
// bölünmeyen bir sayı (ör. 9) neden "bölünemez" çıkıyor?
