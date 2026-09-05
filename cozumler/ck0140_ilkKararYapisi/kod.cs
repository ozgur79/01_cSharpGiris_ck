// ck0140 SEN YAP çözümü — aynı kod, iki farklı çalıştırmayla test edilir
Console.Write("Şairimiz Mehmet Akif'in soyadı nedir?\nCevabınız: ");
string cevap = Console.ReadLine();
if (cevap == "Ersoy")
    Console.WriteLine("Doğru cevap.");
else
    Console.WriteLine("Yanlış cevap.");
Console.ReadKey();

// "Ersoy" girilirse: Doğru cevap.
// "ersoy" girilirse: Yanlış cevap. -- çünkü string karşılaştırması harf büyüklüğüne duyarlı.
