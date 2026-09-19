// ck0730 — Rastgele diziyi küçükten büyüğe sıralama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Diziyi kendi elimizle sıralamak — iç içe iki döngüyle her elemanı
//                  her elemanla karşılaştırıp, sıra yanlışsa yer değiştiriyoruz
//                  (takas/swap). Array.Sort de hazır bir sıralama sunar ama henüz
//                  tanıtılmadı (ck0845'te göreceğiz) — önce mantığı kendimiz kuralım.

// --- KAVRAM ---
int[] dizi1 = new int[10];
Random rnd = new Random();

for (int i = 0; i < dizi1.Length; i++)
    dizi1[i] = rnd.Next(1, 100);

Console.WriteLine("Rastgele dizi:");
for (int i = 0; i < dizi1.Length; i++)
    Console.WriteLine(dizi1[i]);

for (int i = 0; i < dizi1.Length; i++)
{
    for (int j = 0; j < dizi1.Length; j++)
    {
        if (dizi1[i] < dizi1[j])
        {
            // takas (swap): gecici olmadan iki değeri değiştirirsen biri kaybolur
            int gecici = dizi1[i];
            dizi1[i] = dizi1[j];
            dizi1[j] = gecici;
        }
    }
}

Console.WriteLine("Küçükten büyüğe:");
for (int i = 0; i < dizi1.Length; i++)
    Console.WriteLine(dizi1[i]);
Console.ReadKey();

// --- SEN YAP ---
// if (dizi1[i] < dizi1[j]) şartını if (dizi1[i] > dizi1[j]) yaparsan sıralama
// yönü nasıl değişir?
