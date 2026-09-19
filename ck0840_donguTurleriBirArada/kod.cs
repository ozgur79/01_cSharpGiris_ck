// ck0840 — Dört döngü türü bir arada (döngü ailesinin kapanışı)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Şimdiye kadar öğrendiğin dört döngü türünü (while, do-while, for,
//                  foreach) TEK bir programda, her birini en uygun olduğu işte
//                  kullanarak görüyorsun — while ile doldur, do-while ile yazdır,
//                  for ile sırala, foreach ile sonucu yazdır.

// --- KAVRAM ---
int sayac = 0, i = 0;
int[] dizi = new int[3];
Random rnd = new Random();

// while: diziyi doldur
while (sayac < 3)
{
    dizi[sayac] = rnd.Next(0, 20);
    sayac++;
}

// do-while: karışık diziyi yazdır
Console.WriteLine("Rastgele dizi:");
do
{
    Console.WriteLine(dizi[i]);
    i++;
} while (i < 3);

// for: küçükten büyüğe sırala
for (int k = 0; k < dizi.Length; k++)
{
    for (int j = 0; j < dizi.Length; j++)
    {
        if (dizi[k] < dizi[j])
        {
            int gecici = dizi[k];
            dizi[k] = dizi[j];
            dizi[j] = gecici;
        }
    }
}

// foreach: sıralanmış diziyi yazdır
Console.WriteLine("Küçükten büyüğe sıralanmış:");
foreach (int g in dizi)
    Console.WriteLine(g);
Console.ReadKey();

// --- SEN YAP ---
// Her döngü türünün burada NEDEN o iş için seçildiğini kendi cümlenle yaz
// (ör. neden doldurma while ile, sıralama for ile yapıldı?).
