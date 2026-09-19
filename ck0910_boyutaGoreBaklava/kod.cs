// ck0910 — Boyutu klavyeden alınan baklava
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0525/ck0645'teki baklava deseni sabit (5 satırlık) boyuttaydı.
//                  Burada boyut klavyeden alınıp desen ona göre büyüyüp küçülüyor —
//                  ck0700'deki "dinamikleştirme" fikrinin desen ailesine uygulanması.

// --- KAVRAM ---
Console.Write("Baklava diliminin boyutunu girin: ");
int boyut = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= boyut; i++)
{
    for (int j = 0; j <= (boyut + 1) - i; j++)
        Console.Write(" ");
    for (int g = 0; g <= 2 * i - 2; g++)
        Console.Write("*");
    Console.WriteLine();
}

for (int u = 0; u <= boyut; u++)
{
    for (int p = 0; p <= u; p++)
        Console.Write(" ");
    for (int r = u * 2; r <= boyut * 2; r++)
        Console.Write("*");
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// boyut=1 ve boyut=5 ile dene — desen her ikisinde de düzgün bir baklava mı
// çiziyor, yoksa çok küçük/büyük boyutlarda bozuluyor mu?
