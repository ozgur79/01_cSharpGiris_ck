// ck0920 — Asal sayı analizi (arsiv/13'ün kapanışı)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir sayının asal olup olmadığını anlamanın klasik yolu —
//                  1'den kendisine kadar kaç sayıya tam bölündüğünü say. Asal
//                  sayıların TAM OLARAK 2 böleni vardır (1 ve kendisi).

// --- KAVRAM ---
for (; ; )
{
    int sayac = 0;
    Console.Write("Bir sayı girin: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
            sayac++;
    }
    if (sayac == 2)
        Console.WriteLine(n + " sayısı asaldır.");
    else
        Console.WriteLine(n + " sayısı asal değildir.");
}

// --- SEN YAP ---
// n=1 girilirse sayac kaç olur, program "asal" mı "asal değil" mi der? Matematikte
// 1 asal sayı sayılır mı (ipucu: asal sayının TAM OLARAK 2 böleni olmalı)?
