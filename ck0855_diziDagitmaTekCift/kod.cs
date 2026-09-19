// ck0855 — Bir diziyi ikiye dağıtma: tek ve çift
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir dizideki elemanları bir koşula göre İKİ AYRI diziye
//                  dağıtıyoruz (cift/tek) — her dizinin kendi sayacı (c, t) o
//                  dizide kaç eleman dolduğunu takip ediyor.

// --- KAVRAM ---
int t = 0, c = 0;
Random rastgele = new Random();
int[] sayilar = new int[10];
int[] tek = new int[10];
int[] cift = new int[10];
for (int i = 0; i < 10; i++)
{
    sayilar[i] = rastgele.Next(0, 255);
    if (sayilar[i] % 2 == 0)
    {
        cift[c] = sayilar[i];
        c++;
    }
    else
    {
        tek[t] = sayilar[i];
        t++;
    }
}
Console.WriteLine("Tüm sayılar:");
foreach (int sayi in sayilar)
    Console.Write(sayi + " ");
Console.WriteLine();

Console.WriteLine("Çiftler:");
for (int i = 0; i < c; i++)
    Console.Write(cift[i] + " ");
Console.WriteLine();

Console.WriteLine("Tekler:");
for (int i = 0; i < t; i++)
    Console.Write(tek[i] + " ");
Console.ReadKey();

// --- SEN YAP ---
// Çiftler ve tekler yazdırılırken neden foreach değil, c/t sınırlı for kullanıldı?
// (ipucu: tek ve cift dizileri 10 elemanlık ama hepsi dolu değil.)
