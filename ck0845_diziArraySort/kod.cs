// ck0845 — Hazır bir sıralama metodu vardı: Array.Sort
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0730'da kendi sıralama mantığımızı kurmuştuk çünkü hazır bir
//                  sıralama metodu henüz tanıtılmamıştı. Array.Sort tam olarak
//                  o işi (küçükten büyüğe sıralama) tek satırda yapar.

// --- KAVRAM ---
int[] tekSayilar = new int[3];
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
Console.WriteLine("Sıralanmadan önce:");
foreach (int s in tekSayilar)
    Console.Write(s + " ");
Console.WriteLine();

Array.Sort(tekSayilar);

Console.WriteLine("Küçükten büyüğe sıralandıktan sonra:");
foreach (int sayi in tekSayilar)
    Console.Write(sayi + " ");
Console.ReadKey();

// --- SEN YAP ---
// ck0730'daki kendi sıralama mantığınla (iç içe for + swap) bu tek satırlık
// Array.Sort'u karşılaştır — hangisi daha kısa? Kendi mantığını yazmayı öğrenmenin
// faydası neydi (ipucu: her problem için hazır metot olmayabilir)?
