// ck0600 — do-while + switch: sayının okunuşu
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0430'daki doğrulama-tekrar (retry-on-invalid) deseni burada
//                  do-while ile birlikte; sonra sayı basamaklarına ayrılıp (ck0320
//                  birler basamağı pekiştirme) her basamak için ayrı bir switch ile
//                  Türkçe okunuşu yazdırılıyor. Döngü ve karar ailesinin kapanışı.

// --- KAVRAM ---
int sayi;
do
{
    Console.Write("0 ile 9999 arasında bir sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi > 9999 || sayi < 0)
        Console.WriteLine("Girdiğiniz sayı 0 ile 9999 arasında olmalı.");
} while (sayi > 9999 || sayi < 0);

Console.WriteLine(sayi + " sayısı:");

switch (sayi / 1000)
{
    case 9: Console.Write("dokuzbin"); break;
    case 8: Console.Write("sekizbin"); break;
    case 7: Console.Write("yedibin"); break;
    case 6: Console.Write("altıbin"); break;
    case 5: Console.Write("beşbin"); break;
    case 4: Console.Write("dörtbin"); break;
    case 3: Console.Write("üçbin"); break;
    case 2: Console.Write("ikibin"); break;
    case 1: Console.Write("bin"); break;
}
switch (sayi % 1000 / 100)
{
    case 9: Console.Write("dokuzyüz"); break;
    case 8: Console.Write("sekizyüz"); break;
    case 7: Console.Write("yediyüz"); break;
    case 6: Console.Write("altıyüz"); break;
    case 5: Console.Write("beşyüz"); break;
    case 4: Console.Write("dörtyüz"); break;
    case 3: Console.Write("üçyüz"); break;
    case 2: Console.Write("ikiyüz"); break;
    case 1: Console.Write("yüz"); break;
}
switch ((sayi % 100) / 10)
{
    case 9: Console.Write("doksan"); break;
    case 8: Console.Write("seksen"); break;
    case 7: Console.Write("yetmiş"); break;
    case 6: Console.Write("altmış"); break;
    case 5: Console.Write("elli"); break;
    case 4: Console.Write("kırk"); break;
    case 3: Console.Write("otuz"); break;
    case 2: Console.Write("yirmi"); break;
    case 1: Console.Write("on"); break;
}
switch (sayi % 10)
{
    case 9: Console.Write("dokuz"); break;
    case 8: Console.Write("sekiz"); break;
    case 7: Console.Write("yedi"); break;
    case 6: Console.Write("altı"); break;
    case 5: Console.Write("beş"); break;
    case 4: Console.Write("dört"); break;
    case 3: Console.Write("üç"); break;
    case 2: Console.Write("iki"); break;
    case 1: Console.Write("bir"); break;
}
if (sayi == 0)
    Console.Write("sıfır");
Console.WriteLine(" şeklinde okunur.");
Console.ReadKey();

// --- SEN YAP ---
// sayi=1005 ile çalıştır — çıktı "binbeş" olmalı (yüzler ve onlar basamağı 0 olduğu
// için o iki switch'ten hiçbir case eşleşmiyor, sessizce atlanıyor). Neden hata
// vermediğini (default yok ama program çökmüyor) açıkla.
