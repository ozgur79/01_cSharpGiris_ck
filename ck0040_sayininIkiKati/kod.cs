// ck0040 — Sayının iki katı
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
//
// Kara kutu: VS iskeleti + Console.ReadKey (ck0010). Ön izleme: her kod bir class'ın
// (sınıf) içinde yaşar — class Program, projenin ana sınıfı, OOP dersinde (ckXXXX) açılır.

// --- KAVRAM ---
int x, y; // int tipinde iki değişken tanımlandı
Console.Write("Sayıyı giriniz : ");
x = Convert.ToInt32(Console.ReadLine()); // klavyeden okunan yazı, sayıya (int) dönüştürüldü
y = 2 * x; // x sayısının iki katı hesaplanıp y'ye atandı
Console.WriteLine("Klavyeden girilen sayının iki katı : " + y);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, iki katı yerine üç katını hesaplayacak şekilde değiştir.
