// ck0605 — for(;;) + break: sınırsız hakla sayı tahmin
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0575'te do-while ile SINIRLI hakla tahmin ediyorduk. Burada
//                  ck0260'taki for(;;)+break ile SINIRSIZ hakla, sadece doğru
//                  bilinince duran bir tahmin oyunu kuruyoruz.

// --- KAVRAM ---
Random rastgele = new Random();
int tutulansayi = rastgele.Next(0, 100);

for (; ; )
{
    Console.Write("Sayıyı tahmin edin: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > tutulansayi)
        Console.WriteLine("Daha küçük bir sayı yazın.");
    else if (tahmin < tutulansayi)
        Console.WriteLine("Daha büyük bir sayı yazın.");
    else
    {
        Console.WriteLine("Bildiniz!");
        break;
    }
}
Console.ReadKey();

// --- SEN YAP ---
// Kaç tahmin hakkı kullanıldığını sayan bir değişken ekle, doğru bilinince
// "X tahminde bildiniz" yaz.
