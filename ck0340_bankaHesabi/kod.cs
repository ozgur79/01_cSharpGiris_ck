// ck0340 — Banka hesabı: kalıcı bakiye, yatır/çek
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: döngü dışında tanımlanan bir değişken (bakiye), döngünün her turunda
//                  değerini korur ve bir sonraki turda kaldığı yerden devam eder — her tur
//                  sıfırdan başlamaz.
// Not: Bu programda break yok, sonsuz döngü hiç kendiliğinden bitmez. Bu normal, hata
//      değil — denemeyi bitirmek için Visual Studio'nun üstündeki kırmızı kare (Durdur)
//      butonuna bas.

// --- KAVRAM ---
int bakiye = 1000, miktar;
char yatCek = ' ';
Console.WriteLine("Bakiyeniz: " + bakiye);
for (; ; )
{
    Console.Write("Yatır veya Çek y/ç :");
    yatCek = Convert.ToChar(Console.ReadLine());
    Console.Write("Kaç para? ");
    miktar = Convert.ToInt32(Console.ReadLine());
    if (yatCek == 'y' || yatCek == 'Y')
    {
        bakiye = bakiye + miktar;
        Console.WriteLine("Bakiyeniz: " + bakiye);
    }
    else
    {
        if (miktar > bakiye)
        {
            Console.WriteLine("Yetersiz bakiye");
            Console.WriteLine("Bakiyeniz: " + bakiye);
        }
        else
        {
            bakiye = bakiye - miktar;
            Console.WriteLine("Bakiyeniz: " + bakiye);
        }
    }
}

// --- SEN YAP ---
// Sırayla dene: 1) yatır 500 (bakiye 1500 olmalı) 2) çek 2000 (yetersiz bakiye, bakiye
// değişmemeli) 3) çek 300 (bakiye 1200 olmalı). bakiye değişkeni her turda sıfırlanıyor
// mu, yoksa kaldığı yerden mi devam ediyor?
