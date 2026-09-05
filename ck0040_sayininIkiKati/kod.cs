// ck0040 — Sayının iki katı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak.

// --- KAVRAM ---
int x, y; // int tipinde iki değişken tanımlandı
Console.Write("Sayıyı giriniz : ");
x = Convert.ToInt32(Console.ReadLine()); // klavyeden okunan yazı, sayıya (int) dönüştürüldü
y = 2 * x; // x sayısının iki katı hesaplanıp y'ye atandı
Console.WriteLine("Klavyeden girilen sayının iki katı : " + y);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, iki katı yerine üç katını hesaplayacak şekilde değiştir.

// --- MERAK KÖŞESİ ---
// class Program ne işe yarar?
// ck0030'da namespace'in kodlarını bir isim altında topladığını söylemiştik; class
// Program o isim altındaki kutulardan biri. Şu ana kadar yazdığın her satır (yazı
// yazdırma, sayı okuma, toplama) bu kutunun içinde durdu. Kutunun kendisini ünite
// 03'te (nesne yönelimli programlama) açacağız.
