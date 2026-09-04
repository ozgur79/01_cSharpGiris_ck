// ck0040 — Sayının iki katı
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
//
// Şimdilik kara kutu (sonra açacağız):
//   using System; / using System.Collections.Generic; / using System.Linq; /
//   using System.Text; / using System.Threading.Tasks;      -> ckXXXX
//   namespace <proje adın>  (VS'in otomatik oluşturduğu ad) -> ckXXXX (OOP'a gelince)
//   class Program                                            -> ckXXXX (OOP'a gelince)
//   static void Main(string[] args)                          -> ckXXXX (OOP'a gelince)
//   Console.ReadKey();  -> ckXXXX (konsol penceresinin neden kapanmadan beklediğini o zaman göreceğiz)

// --- KAVRAM ---
int x, y; // int tipinde iki değişken tanımlandı
Console.Write("Sayıyı giriniz : ");
x = Convert.ToInt32(Console.ReadLine()); // klavyeden okunan yazı, sayıya (int) dönüştürüldü
y = 2 * x; // x sayısının iki katı hesaplanıp y'ye atandı
Console.WriteLine("Klavyeden girilen sayının iki katı : " + y);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, iki katı yerine üç katını hesaplayacak şekilde değiştir.
