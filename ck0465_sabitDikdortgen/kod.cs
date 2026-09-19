// ck0465 — İç içe for ile sabit dikdörtgen çizme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir for döngüsünün içine ikinci bir for döngüsü konabilir. Dıştaki döngü
//                  satır sayısını, içteki döngü her satırdaki yıldız sayısını belirliyor —
//                  ck0460'taki tek satır artık her satırda tekrarlanıyor.

// --- KAVRAM ---
for (int k = 0; k < 10; k++)
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// Dıştaki sınırı 10'dan 3'e, içteki sınırı 5'ten 8'e değiştir. Kaç satır, satır başına
// kaç yıldız çıkacağını önce tahmin et, sonra çalıştırıp doğrula.
// Sonra her satırın son yıldızını + yap (ipucu: iç döngüde son sayaç değerini kontrol et).
