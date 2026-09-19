// ck0530 — Random'a giriş
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Rastgele sayı üretmek için Random sınıfından bir üretici oluşturuyoruz
//                  (new Random()), sonra .Next(min, max) ile istediğimiz aralıkta sayı
//                  istiyoruz. Bu bloktaki (while/do-while, dizi) birçok derste kullanılacak.

// --- KAVRAM ---
Random rastgele = new Random();
byte tutulansayi = Convert.ToByte(rastgele.Next(0, 255));
Console.WriteLine("Bilgisayarın tuttuğu sayı: " + tutulansayi);
Console.ReadKey();

// --- SEN YAP ---
// Next(0, 255) yerine Next(1, 7) yaz — bir zar atma simülasyonu. Programı birkaç kez
// çalıştırıp her seferinde farklı bir sayı çıktığını gözlemle.

// --- MERAK KÖŞESİ ---
// new Random() ne demek?
// Random, "rastgele sayı üretici" tarifi (bir sınıf). new yazarak bu tariften gerçek bir
// üretici (nesne) oluşturuyoruz — rastgele değişkeni artık kullanılabilir bir üretici.
// new'i kendi tariflerimizi (sınıflarımızı) yazmaya başlayınca çok daha sık göreceğiz.
// Kutunun kendisini (new, sınıf, nesne farkı) ünite 07'de (nesne tabanlı programlama) açacağız.
