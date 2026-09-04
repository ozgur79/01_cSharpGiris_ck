// ck0060 — Tam sayı bölmesi
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: iki int değişkeni böldüğümüzde sonucun küsuratı (ondalık kısmı) atılır —
//                  sonucu float ya da double tipinde bir değişkene atasak bile fark etmez,
//                  çünkü bölme işlemi int'ler arasında, atamadan ÖNCE yapılır.
//
// Şimdilik kara kutu (ck0010'da tanıtıldı, henüz açılmadı):
//   VS2013 iskeleti (using'ler + namespace + class Program + Main) + Console.ReadKey();
//   Ön izleme: using satırlarının her biri ayrı bir "araç kutusu" gibi düşün — System,
//   System.Collections.Generic, System.Linq... her biri farklı hazır araçlar taşır,
//   hangisinin ne işe yaradığını ckXXXX'te tek tek açacağız.

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
