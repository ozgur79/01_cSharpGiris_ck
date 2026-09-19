// ck0690 — Dizi + Random: sadece tek sayıları toplama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0685'te her üretilen sayı direkt diziye giriyordu. Burada bir
//                  koşul (tek mi?) sağlanana kadar üretmeye devam ediyoruz — for'un
//                  artış kısmı BOŞ bırakılıp i++ sadece koşul sağlanınca çalışıyor.

// --- KAVRAM ---
int[] tekSayilar = new int[3];
Random rastgele = new Random();
for (int i = 0; i < 3;)
{
    int sayi = rastgele.Next(0, 100);
    if (sayi % 2 == 1)
    {
        Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayi);
        tekSayilar[i] = sayi;
        i++;
    }
}
Console.ReadKey();

// --- SEN YAP ---
// Tek sayı yerine 10'un katı olan sayıları (sayi % 10 == 0) diziye doldur.
