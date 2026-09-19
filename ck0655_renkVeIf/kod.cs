// ck0655 — ConsoleColor + if: tek/çift sayıya göre renk
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0650'deki cast'i ck0270'teki tek/çift kontrolüyle birleştiriyoruz —
//                  girilen sayı çiftse bir renk, tekse başka bir renk. Random pekiştirme
//                  + zamanlama + renk ailesinin kapanışı.

// --- KAVRAM ---
int sayi;
Console.BackgroundColor = (ConsoleColor)12;
Console.Write("Bir sayı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.BackgroundColor = (ConsoleColor)9;
    Console.Clear();
}
else
{
    Console.BackgroundColor = (ConsoleColor)10;
    Console.Clear();
}
Console.ReadKey();

// --- SEN YAP ---
// sayi 5'in katıysa (sayi % 5 == 0) ayrı bir üçüncü renk (ör. 14) kullan — else if
// ekleyerek üç seçenekli hale getir.
