// ck0850 — Dizi + ortalama: 4. eleman ilk üçün ortalaması
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0695'te toplamı son elemana koymuştuk. Burada TOPLAM yerine
//                  ORTALAMA (toplam / eleman sayısı) son elemana konuyor — aynı
//                  "biriktir, sonra son slota yaz" deseni, farklı hesaplama.

// --- KAVRAM ---
int[] tekSayilar = new int[4];
int toplam = 0;
Random rastgele = new Random();
for (int i = 0; i < 3;)
{
    int tutulansayi = rastgele.Next(0, 255);
    if (tutulansayi % 2 == 1)
    {
        tekSayilar[i] = tutulansayi;
        i++;
    }
}
for (int i = 0; i < 3; i++)
    toplam = toplam + tekSayilar[i];

int ortalama = toplam / 3;
tekSayilar[3] = ortalama;

Console.WriteLine("Ortalama: " + tekSayilar[3]);
Console.ReadKey();

// --- SEN YAP ---
// Dizi boyutunu 6 yap (5 sayı + 1 ortalama), ortalamayı 5'e bölerek hesapla.
