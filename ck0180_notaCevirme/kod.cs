// ck0180 — Puanı nota çevirme: sıralı aralık kontrolü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: else if zincirinde koşullar sırayla denenir — bir koşula gelindiğinde
//                  öncekilerin hepsinin yanlış (false) çıktığı zaten bellidir. Bu yüzden
//                  "puan < 50" burada aslında "25 ile 50 arası" demektir, çünkü 25'ten
//                  küçük olma ihtimali bir üstteki satırda elenmiştir.

// --- KAVRAM ---
int puan;
Console.Write("Puanınızı girin : ");
puan = Convert.ToInt32(Console.ReadLine());
if (puan < 0)
    Console.WriteLine("Geçersiz Puan");
else if (puan < 25)      // buraya geldiyse puan zaten 0'dan küçük değildi
    Console.WriteLine("Not : 0");
else if (puan < 50)      // buraya geldiyse puan zaten 25'ten küçük değildi
    Console.WriteLine("Not : 1");
else if (puan < 60)
    Console.WriteLine("Not : 2");
else if (puan < 70)
    Console.WriteLine("Not : 3");
else if (puan < 85)
    Console.WriteLine("Not : 4");
else if (puan <= 100)
    Console.WriteLine("Not : 5");
else
    Console.WriteLine("Geçersiz Puan");
Console.ReadKey();

// --- SEN YAP ---
// puan=25 ve puan=24 ile çalıştır, sınırı (25) hangi dal alıyor gör. Sonra puan=-1 ve
// puan=101 ile geçersiz uçları test et.
