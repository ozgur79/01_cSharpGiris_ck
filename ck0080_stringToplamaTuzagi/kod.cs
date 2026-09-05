// ck0080 — String toplama tuzağı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: string + string, sayısal toplama değil BİRLEŞTİRMEdir —
//                  ck0030'da Convert.ToInt32 kullanma sebebimiz buymuş.


// --- KAVRAM ---
string x, y;
Console.Write("1. sayıyı gir: ");
x = Console.ReadLine();
Console.Write("2. sayıyı gir: ");
y = Console.ReadLine();
Console.WriteLine(x + " + " + y + " = " + (x + y)); // x, y string -> + burada BİRLEŞTİRME yapar
Console.ReadKey();
// 3 ve 5 girsen bile sonuç 8 değil "35" çıkar, çünkü x ve y hâlâ string.

// --- SEN YAP ---
// Yukarıdaki kodu, ck0030'daki gibi Convert.ToInt32 kullanarak gerçek toplamı
// yapacak şekilde düzelt.

// --- MERAK KÖŞESİ ---
// using satırları neden 5 tane, tek satır olsa olmaz mı?
// ck0020'de using'in hazır kütüphaneleri projene kattığını söylemiştik. Aslında her
// using ayrı bir "araç kutusu" — biri yazı işleri için, biri sayı/liste işleri için.
// Şu ana kadar hep aynı beşi gördün ama hepsini kullanmadın; hangisinin ne
// içerdiğini ileride açacağız.
