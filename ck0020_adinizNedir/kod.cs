// ck0020 — Kullanıcıdan yazı (string) almak
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: string değişken tanımlamak, Console.ReadLine ile klavyeden yazı okumak,
//                  + ile iki yazıyı birleştirmek
//
// Şimdilik kara kutu (ck0010'da tanıtıldı, henüz açılmadı):
//   VS2013 iskeleti (using'ler + namespace + class Program + Main) + Console.ReadKey();
//   Ön izleme: using satırları, C#'ın hazır kütüphanelerinden bazılarını projene dahil
//   eder — ileride (ckXXXX) ne işe yaradıklarını göreceğiz.

// --- KAVRAM ---
string isim; // isim adında bir metin (string) değişkeni tanımlandı
Console.Write("Adınız nedir : ");
isim = Console.ReadLine(); // klavyeden girilen yazı isim değişkenine atandı
Console.WriteLine("Merhaba " + isim); // + ile iki yazı birleştirildi
Console.ReadKey();

// --- SEN YAP ---
// Kullanıcıya soyadını da sor (ikinci bir string değişkende sakla), sonra
// "Merhaba <isim> <soyisim>" şeklinde tek satırda yazdır.
