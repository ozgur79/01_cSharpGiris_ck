// ck0420 — 1'den X'e kadar toplam
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: pekiştirme — ck0390'daki çarpımsal biriktiriciye benzer ama burada
//                  toplama biriktiricisi (ck0350 gibi) kullanılıyor, sınır kullanıcıdan
//                  okunuyor (ck0410'daki gibi dinamik).

// --- KAVRAM ---
Console.Write("1'den kaça kadar toplanacak ? : ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = 0; // atama yapılmazsa otomatikman 0 atanır
for (int i = 1; i <= sayi; i++)
{
    sonuc = sonuc + i;
}
Console.Write("1'den " + sayi + " ya kadar olan sayıların toplamı : " + sonuc);
Console.ReadKey();

// --- SEN YAP ---
// sayi=5 ile çalıştır, sonuc=15 çıkmalı (1+2+3+4+5). sayi=1 ile dene — sonuc ne çıkar?
