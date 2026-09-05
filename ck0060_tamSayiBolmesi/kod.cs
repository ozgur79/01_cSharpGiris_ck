// ck0060 — Tam sayı bölmesi
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: iki int değişkeni böldüğümüzde sonucun küsuratı (ondalık kısmı) atılır —
//                  sonucu float ya da double tipinde bir değişkene atasak bile fark etmez,
//                  çünkü bölme işlemi int'ler arasında, atamadan ÖNCE yapılır.


// --- KAVRAM ---
int x = 10, y = 4;
int intSonuc = x / y;       // int / int = int, küsurat atılır: 2
float floatSonuc = x / y;   // bölme yine int olarak yapıldı (2), SONRA float'a çevrildi
double doubleSonuc = x / y; // aynı durum, sonuç yine 2
Console.WriteLine("x / y (int)    = " + intSonuc);
Console.WriteLine("x / y (float)  = " + floatSonuc);
Console.WriteLine("x / y (double) = " + doubleSonuc);
Console.ReadKey();
// Üçü de 2 çıktı, çünkü x ve y int olduğu için bölme int bölmesi olarak yapılıyor,
// küsurat daha atama satırına gelmeden kayboluyor.

// --- SEN YAP ---
// x/y işleminin gerçek sonucunu (2,5) elde etmeye çalış.
// İpucu: (double)x / y gibi, bölmeden önce x'i double'a çevirmeyi dene.

// --- MERAK KÖŞESİ ---
// Console.ReadKey(); neden her programın sonunda var?
// ck0050'de Main'in programın başladığı satır olduğunu söylemiştik; ReadKey ise
// programın BİTMEDEN önceki son satırı. O olmasa pencere anında kapanır, üç sonucu
// da (int/float/double) göremeden ekran kaybolurdu. Neden böyle çalıştığını ünite
// 07'de (nesne tabanlı programlama) açacağız.
