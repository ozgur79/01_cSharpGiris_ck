// ck0780 — Fonksiyon ile üslü sayı hesaplama
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki usAlma metodunu class Program içine, Main()'in dışına ekle.
// Ne öğreneceğiz: ck0505'te AYNI problemi (üslü sayı) sade bir döngüyle çözmüştük.
//                  Burada aynı hesaplama bir fonksiyonun içine taşınıyor — problem
//                  aynı, çözüm fonksiyonla paketlenmiş.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
Console.Write("Üssü alınacak sayıyı girin: ");
int taban = Convert.ToInt32(Console.ReadLine());
Console.Write("Üssünü girin: ");
int us = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sonuç = " + usAlma(taban, us));
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int usAlma(int taban, int us)
{
    int sonuc = 1;
    for (int i = 1; i <= us; i++)
        sonuc = sonuc * taban;
    return sonuc;
}

// --- SEN YAP ---
// ck0505'teki kodla bu dersi karşılaştır — hesaplama mantığı (for döngüsü) birebir
// aynı mı? Fonksiyona taşımak neyi değiştirdi, neyi değiştirmedi?
