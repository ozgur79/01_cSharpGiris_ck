// ck0875 — Listeyi kendi for'unla tersleme (ck0870'in ödevi)
// NASIL: Yeni bir Console Application aç. Dosyanın en üstüne `using
//        System.Collections.Generic;` ekle. Sonra aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0870'te .Reverse()'i hazır kullanmıştık. Burada AYNI işi
//                  ck0730'daki swap tekniğiyle kendimiz kuruyoruz — uzunluk/2 kez
//                  dönüp baştaki ile sondaki elemanı takas ediyoruz.

// --- KAVRAM ---
Console.Write("10 tabanındaki sayıyı girin: ");
int taban10 = Convert.ToInt32(Console.ReadLine());

List<int> rakamlar = new List<int>();
for (; ; )
{
    if (taban10 == 0)
        break;
    int kalan = taban10 % 2;
    taban10 = taban10 / 2;
    if (kalan == 1)
        rakamlar.Add(1);
    else
        rakamlar.Add(0);
}

int uzunluk = rakamlar.Count;
Console.WriteLine("Listenin uzunluğu: " + uzunluk);

for (int i = 0; i < uzunluk / 2; i++)
{
    int gecici = rakamlar[i];
    rakamlar[i] = rakamlar[uzunluk - i - 1];
    rakamlar[uzunluk - i - 1] = gecici;
}

foreach (int rakam in rakamlar)
    Console.Write(rakam);
Console.ReadKey();

// --- SEN YAP ---
// uzunluk tek sayı olursa (ör. 5 basamaklı bir ikili) ortadaki eleman hiç
// takas edilmiyor — bu bir sorun mu? Neden (ipucu: ortadaki eleman kendi
// kendisiyle mi takas edilmeli)?
