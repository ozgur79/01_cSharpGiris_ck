// ck0685 — Dizi + Random: 3 rastgele sayı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0530'daki Random'ı diziyle birleştiriyoruz — klavyeden almak
//                  yerine her elemanı rastgele üretip diziye yerleştiriyoruz.

// --- KAVRAM ---
int[] sayilar = new int[3];
Random rastgele = new Random();
for (int i = 0; i < 3; i++)
    sayilar[i] = rastgele.Next(0, 50);

for (int i = 0; i < 3; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();

// --- SEN YAP ---
// Dizi boyutunu 3 yerine 10 yap, aralığı da 0-50 yerine 0-1000 yap.
