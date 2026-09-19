// ck0880 — İki pointer tekniğiyle tersleme
// NASIL: Yeni bir Console Application aç. Dosyanın en üstüne `using
//        System.Collections.Generic;` ekle. Sonra aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0875'te tek bir sayaç (i) ile tersleme yapmıştık. Burada İKİ
//                  ayrı sayaç (baslangic, bitis) baştan ve sondan birbirine doğru
//                  yürüyor — aynı takas fikri, farklı bir yazım.

// --- KAVRAM ---
List<int> rakamlar = new List<int>();
rakamlar.Add(1);
rakamlar.Add(2);
rakamlar.Add(3);

Console.WriteLine("Normal:");
foreach (int rakam in rakamlar)
    Console.WriteLine(rakam);

int baslangic = 0;
int bitis = rakamlar.Count - 1;
while (baslangic < bitis)
{
    int gecici = rakamlar[baslangic];
    rakamlar[baslangic] = rakamlar[bitis];
    rakamlar[bitis] = gecici;
    baslangic++;
    bitis--;
}

Console.WriteLine("Ters çevrilmiş:");
foreach (int rakam in rakamlar)
    Console.WriteLine(rakam);
Console.ReadKey();

// --- SEN YAP ---
// while (baslangic < bitis) yerine while (baslangic <= bitis) yazarsan ne olur
// (ipucu: ortadaki eleman kendisiyle takas edilir mi, bir sorun yaratır mı)?
