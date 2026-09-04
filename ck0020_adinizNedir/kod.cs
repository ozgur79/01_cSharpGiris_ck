// ck0020 — Kullanıcıdan yazı (string) almak
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: string değişken tanımlamak, Console.ReadLine ile klavyeden yazı okumak,
//                  + ile iki yazıyı birleştirmek
//
// Şimdilik kara kutu (sonra açacağız):
//   using System; / using System.Collections.Generic; / using System.Linq; /
//   using System.Text; / using System.Threading.Tasks;      -> ckXXXX
//   namespace <proje adın>  (VS'in otomatik oluşturduğu ad) -> ckXXXX (OOP'a gelince)
//   class Program                                            -> ckXXXX (OOP'a gelince)
//   static void Main(string[] args)                          -> ckXXXX (OOP'a gelince)
//   Console.ReadKey();  -> ckXXXX (konsol penceresinin neden kapanmadan beklediğini o zaman göreceğiz)

// --- KAVRAM ---
string isim; // isim adında bir metin (string) değişkeni tanımlandı
Console.Write("Adınız nedir : ");
isim = Console.ReadLine(); // klavyeden girilen yazı isim değişkenine atandı
Console.WriteLine("Merhaba " + isim); // + ile iki yazı birleştirildi
Console.ReadKey();

// --- SEN YAP ---
// Kullanıcıya soyadını da sor (ikinci bir string değişkende sakla), sonra
// "Merhaba <isim> <soyisim>" şeklinde tek satırda yazdır.
