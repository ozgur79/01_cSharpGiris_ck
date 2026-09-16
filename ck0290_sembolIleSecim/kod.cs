// ck0290 — Sembol tabanlı seçim: char ile + - * / karşılaştırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: pekiştirme — Convert.ToChar (ck0200) ile okunan bir karakteri '+','-',
//                  '*','/' sembolleriyle karşılaştırıp hesap makinesinin doğal hâlini
//                  kurmak (ck0280'de "1,2,3,4" rakamıyla seçim yapmıştık).

// --- KAVRAM ---
double s1, s2, sonuc;
Console.Write("İşlem Tipini Seçin (+ - * /): ");
char secim = Convert.ToChar(Console.ReadLine());
Console.Write("1.Sayıyı Girin: ");
s1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2.Sayıyı Girin: ");
s2 = Convert.ToDouble(Console.ReadLine());
if (secim == '+')
{
    sonuc = s1 + s2;
    Console.WriteLine(s1 + " + " + s2 + " = " + sonuc);
}
else if (secim == '-')
{
    sonuc = s1 - s2;
    Console.WriteLine(s1 + " - " + s2 + " = " + sonuc);
}
else if (secim == '*')
{
    sonuc = s1 * s2;
    Console.WriteLine(s1 + " * " + s2 + " = " + sonuc);
}
else if (secim == '/')
{
    sonuc = s1 / s2;
    Console.WriteLine(s1 + " / " + s2 + " = " + sonuc);
}
else
{
    Console.WriteLine("+, -, * veya / sembollerinden birini girin.");
}
Console.ReadKey();

// --- SEN YAP ---
// secim='*', s1=3, s2=4 ile çalıştır. Sonra secim='x' (listede olmayan bir karakter) ile
// çalıştır, hata mesajını gör. ck0280'deki "1-4 arası rakam" mesajıyla bu mesajın neden
// farklı yazıldığını düşün.
