// ck0580 — while ile "tekrar oyna" döngüsü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0575'te do-while bir OYUN İÇİNDE tekrar tekrar tahmin almak için
//                  kullanılmıştı. Burada while, OYUNUN KENDİSİNİ baştan sona tekrar
//                  başlatmak için kullanılıyor — "tekrar oynamak ister misiniz?".

// --- KAVRAM ---
int devam = 1;
while (devam == 1)
{
    Random rastgele = new Random();
    int sayi = rastgele.Next(1, 10);

    Console.Write("1 ile 9 arasında bir sayı tahmin edin: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin == sayi)
        Console.WriteLine("Bildiniz! Sayı: " + sayi);
    else
        Console.WriteLine("Bilemediniz, sayı: " + sayi + " idi.");

    Console.Write("Tekrar oynamak ister misiniz? (E/H): ");
    string tekrar = Console.ReadLine();
    if (tekrar == "H" || tekrar == "h")
        devam = 0;
}
Console.WriteLine("Oyun bitti.");
Console.ReadKey();

// --- SEN YAP ---
// Kaç kez oynandığını sayan bir değişken ekle, oyun bitince "toplam X kez oynadınız" yaz.
