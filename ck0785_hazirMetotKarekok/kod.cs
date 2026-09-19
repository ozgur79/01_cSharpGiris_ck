// ck0785 — Hazır kütüphane metodu: Math.Sqrt
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0760-ck0780'de KENDİ fonksiyonlarımızı yazdık. Math.Sqrt ise
//                  C#'ın HAZIR getirdiği bir fonksiyon (metot) — karekök almak için
//                  kendi döngümüzü yazmamıza gerek yok, biri bizim için yazmış.
//                  Fonksiyon ailesinin kapanışı: kendi yazdığın vs hazır olan.

// --- KAVRAM ---
Console.Write("Bir sayı girin: ");
double sayi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Karekök: " + Math.Sqrt(sayi));
Console.ReadKey();

// --- SEN YAP ---
// Negatif bir sayı (ör. -9) girersen Math.Sqrt ne döndürür? Program çöker mi?
