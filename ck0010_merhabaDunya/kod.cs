// ck0010 — İlk program: ekrana yazı yazdırma
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Console.Write ve Console.WriteLine ile ekrana yazı basmak,
//                  aralarındaki fark (WriteLine'dan sonra imleç alt satıra geçer, Write'tan sonra geçmez)
//
// Şimdilik kara kutu (sonra açacağız):
//   using System; / using System.Collections.Generic; / using System.Linq; /
//   using System.Text; / using System.Threading.Tasks;      -> ckXXXX
//   namespace <proje adın>  (VS'in otomatik oluşturduğu ad) -> ckXXXX (OOP'a gelince)
//   class Program                                            -> ckXXXX (OOP'a gelince)
//   static void Main(string[] args)                          -> ckXXXX (OOP'a gelince)
//   Console.ReadKey();  -> ckXXXX (konsol penceresinin neden kapanmadan beklediğini o zaman göreceğiz)

// --- KAVRAM ---
Console.Write("Merhaba Dünya :)"); // ekrana yazdırır, imleç aynı satırda kalır
Console.ReadKey(); // bir tuşa basılana kadar programı bekletir

Console.WriteLine("Merhaba Dünya :)"); // ekrana yazdırır, imleci bir alt satıra götürür
Console.ReadKey();

// --- SEN YAP ---
// Yukarıdaki dört satırı örnek alarak, kendi adını "Merhaba, ben <adın>" şeklinde
// Console.WriteLine ile ekrana yazdıran bir satır ekle. Programı çalıştırıp kontrol et.
