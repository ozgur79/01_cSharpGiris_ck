// ck0280 — Çok seçenekli menüde önce geçerlilik, sonra işlem
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: "doğrulama sarmalayıcısı" deseni — dış if önce seçimin 1-4 arası geçerli
//                  olup olmadığına bakar; geçersizse sayılar hiç sorulmaz. Geçerliyse
//                  içerideki else if zinciri hangi işlemin yapılacağına karar verir.

// --- KAVRAM ---
string islemTipi;
int s1, s2, sonuc;
Console.WriteLine("İşlem tipini seçin :");
Console.WriteLine("Toplama : 1");
Console.WriteLine("Çıkarma : 2");
Console.WriteLine("Çarpma  : 3");
Console.WriteLine("Bölme   : 4");

Console.Write("İşlem tipini seçin : ");
islemTipi = Console.ReadLine();

if (islemTipi == "1" || islemTipi == "2" || islemTipi == "3" || islemTipi == "4") // dış if: geçerlilik
{
    Console.Write("1. sayıyı girin : ");
    s1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. sayıyı girin : ");
    s2 = Convert.ToInt32(Console.ReadLine());

    if (islemTipi == "1") // iç else if zinciri: hangi işlem
    {
        sonuc = s1 + s2;
        Console.WriteLine(s1 + " + " + s2 + " = " + sonuc);
    }
    else if (islemTipi == "2")
    {
        sonuc = s1 - s2;
        Console.WriteLine(s1 + " - " + s2 + " = " + sonuc);
    }
    else if (islemTipi == "3")
    {
        sonuc = s1 * s2;
        Console.WriteLine(s1 + " * " + s2 + " = " + sonuc);
    }
    else
    {
        sonuc = s1 / s2;
        Console.WriteLine(s1 + " / " + s2 + " = " + sonuc);
    }
}
else
    Console.WriteLine("1-4 arası rakam gir");

Console.ReadKey();

// --- SEN YAP ---
// 1) islemTipi=1, s1=3, s2=4 ile çalıştır (toplama). 2) islemTipi=9 ile çalıştır —
// sayılar hiç sorulmuyor, neden? 3) islemTipi=4, s1=7, s2=2 ile çalıştır, sonucu
// ck0060'ın kuralıyla karşılaştır (küsurat atılıyor mu?).
