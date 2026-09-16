// ck0400 — Döngü içinde periyodik biçimlendirme: her 5 sayıda bir satır atlama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: döngü sayacına % ile bakarak "her N turda bir" bir şey yapmak — burada
//                  i%5==1 olduğunda (1,6,11,16...) yeni satıra geçiliyor, böylece sayılar
//                  5'erli gruplar hâlinde alt alta diziliyor.

// --- KAVRAM ---
int i;
for (i = 1; i < 51; i++)
{
    if (i % 5 == 1)
        Console.WriteLine();
    Console.Write(i + " ");
}
Console.ReadKey();

// --- SEN YAP ---
// Programı çalıştır, 1'den 50'ye kadar sayıların 5'erli satırlar hâlinde dizildiğini gör.
// `i % 5 == 1` yerine `i % 10 == 1` yazsan satır başına kaç sayı düşer?
