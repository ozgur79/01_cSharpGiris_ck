// ck0535 — while döngüsüne giriş
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0260'taki for döngüsü belli sayıda dönüyordu. while, şart doğru
//                  olduğu SÜRECE döner — kaç tur süreceği baştan belli değil, kullanıcı
//                  'q' yazana kadar devam eder.

// --- KAVRAM ---
int sayi;
string giris;
Console.Write("Analiz edilecek sayıyı girin ('q' ile çıkış): ");
giris = Console.ReadLine();

while (giris != "q")
{
    sayi = Convert.ToInt32(giris);
    if (sayi > 0)
        Console.WriteLine(sayi + " pozitiftir");
    else if (sayi < 0)
        Console.WriteLine(sayi + " negatiftir");
    else
        Console.WriteLine("Sıfır");

    Console.Write("Analiz edilecek sayıyı girin ('q' ile çıkış): ");
    giris = Console.ReadLine();
}
Console.WriteLine("Programdan çıkıldı.");
Console.ReadKey();

// --- SEN YAP ---
// 'q' yerine 'x' ile çıkışı da kabul et (giris != "q" && giris != "x" gibi bir koşulla).
