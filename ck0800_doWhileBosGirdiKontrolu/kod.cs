// ck0800 — do-while ile boş girdi kontrolü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0555'teki do-while retry-deseni burada YENİ bir geçerlilik
//                  kontrolüyle — sayı aralığı değil, string.IsNullOrWhiteSpace ile
//                  "hiç bir şey ya da sadece boşluk girilmedi mi?" kontrolü.

// --- KAVRAM ---
string girdi;
do
{
    Console.Write("Veri girin: ");
    girdi = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(girdi))
        Console.WriteLine("Geçerli bir veri girmelisiniz, tekrar deneyin.");
} while (string.IsNullOrWhiteSpace(girdi));

Console.WriteLine("Girilen veri: " + girdi);
Console.ReadKey();

// --- SEN YAP ---
// string.IsNullOrWhiteSpace(girdi) yerine sadece girdi == "" yazarsan, sadece
// boşluk (" ") girildiğinde ne fark eder?
