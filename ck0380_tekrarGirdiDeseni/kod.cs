// ck0380 — Döngü içinde tekrar girdi isteme deseni
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: döngü başlamadan önce bir kez soru sorulur, döngü içinde her turun
//                  sonunda soru tekrar sorulur — böylece kullanıcı her seferinde yeni bir
//                  sayı girip sonucu görebilir, program tek seferlik çalışmaz.

// --- KAVRAM ---
int sayi;
Console.Write("Analiz edilecek sayıyı girin: ");
sayi = Convert.ToInt32(Console.ReadLine()); // döngüden ÖNCE bir kez sorulur
for (; ;)
{
    if (sayi > 0)
        Console.WriteLine("Pozitif");
    else if (sayi < 0)
        Console.WriteLine("Negatif");
    else
    {
        break; // sayi sıfırsa döngü burada biter
    }
    Console.Write("Analiz edilecek sayıyı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine()); // döngü İÇİNDE, her turun sonunda tekrar sorulur
}
Console.Write("Programdan çıkıldı: ");
Console.ReadKey();

// --- SEN YAP ---
// 5, -3, 0 sırasıyla gir — "Pozitif", "Negatif", sonra "Programdan çıkıldı:" görmelisin.
// Neden aynı `Console.Write("Analiz edilecek...")` satırı kodda iki kez yazılmış?
