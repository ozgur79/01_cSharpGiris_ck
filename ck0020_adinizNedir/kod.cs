// ck0020 — Kullanıcıdan yazı (string) almak
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: string değişken tanımlamak, Console.ReadLine ile klavyeden yazı okumak,
//                  + ile iki yazıyı birleştirmek


// --- KAVRAM ---
string isim; // isim adında bir metin (string) değişkeni tanımlandı
Console.Write("Adınız nedir : ");
isim = Console.ReadLine(); // klavyeden girilen yazı isim değişkenine atandı
Console.WriteLine("Merhaba " + isim); // + ile iki yazı birleştirildi
Console.ReadKey();

// --- SEN YAP ---
// Kullanıcıya soyadını da sor (ikinci bir string değişkende sakla), sonra
// "Merhaba <isim> <soyisim>" şeklinde tek satırda yazdır.

// --- MERAK KÖŞESİ ---
// using System; ne işe yarar?
// ck0010'da Console.Write ve Console.WriteLine kullanmıştık — bunlar hazır yazılmış
// kod parçaları. using satırları, bu hazır parçaların durduğu kütüphaneleri projene
// dahil eder, sen çağırabilesin diye. Hangisinin ne getirdiğini ünite 07'de (nesne
// tabanlı programlama) tek tek açacağız.
