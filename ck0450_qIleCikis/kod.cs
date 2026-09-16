// ck0450 — Pozitif/negatif/sıfır analizi: çıkış 'q' harfiyle
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0380'de aynı analizi 0 girilince break ile bitirmiştik — burada çıkış
//                  koşulu harf tabanlı ("q" yazmak). Bu yüzden değişken önce string
//                  (`giris`) olarak okunuyor, sayıya çevirme ancak "q" olmadığı anlaşıldıktan
//                  sonra yapılıyor.

// --- KAVRAM ---
int sayi;
string giris;

for (; ; )
{
    Console.Write("Analiz edilecek sayıyı girin ('q' tuşuyla çıkış yapabilirsiniz): ");
    giris = Console.ReadLine();

    if (giris == "q")
    {
        break;
    }

    sayi = Convert.ToInt32(giris);

    if (sayi > 0)
    {
        Console.WriteLine(sayi + " pozitiftir");
    }
    else if (sayi < 0)
    {
        Console.WriteLine(sayi + " negatiftir");
    }
    else
    {
        Console.WriteLine("Sıfır");
    }
}
Console.WriteLine("Programdan çıkıldı");
Console.ReadKey();

// --- SEN YAP ---
// 5, -3, 0, q sırasıyla gir. ck0380'de aynı egzersizi 0 girerek bitiriyorduk — burada 0
// girmek programı bitirir mi? "Sıfır" mesajını görüp görmediğini kontrol et.
