// BU KOD NE YAPAR?
// Bu kod, bilgisayarın tuttuğu 0-254 arası rastgele sayıyı 3 hakta bulmanı ister. Her
// tahminden sonra "daha büyük" ya da "daha küçük" ipucu verir; bilinirse ya da hak biterse oyun biter.

// ck0575 — do-while + Random: sayı tahmin oyunu
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0530'daki Random'ı ck0555'teki do-while ile birleştiriyoruz —
//                  bilgisayar bir sayı tutuyor, oyuncu sınırlı hakla tahmin ediyor.

// --- KAVRAM ---
int tutulansayi, tahmin, hak = 3;
Random rastgele = new Random();
tutulansayi = rastgele.Next(0, 255);

do
{
    Console.Write("Sayıyı tahmin edin (" + hak + " hakkınız var): ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > tutulansayi)
        Console.WriteLine("Daha küçük bir sayı yazın.");
    else if (tahmin < tutulansayi)
        Console.WriteLine("Daha büyük bir sayı yazın.");
    else
        Console.WriteLine("Bildiniz!");
    hak--;
} while (tahmin != tutulansayi && hak > 0);

Console.WriteLine("Oyun bitti.");
Console.ReadKey();

// --- SEN YAP ---
// hak=3 yerine 5 yap, aralığı da 0-255 yerine 0-50 yap — oyunu daha kazanılabilir hale getir.
