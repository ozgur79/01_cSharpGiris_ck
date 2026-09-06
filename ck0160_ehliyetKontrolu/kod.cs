// ck0160 — Ehliyet kontrolü: if/else ile sayısal karşılaştırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: if/else'i (ck0140'ta == ile görmüştük) şimdi < ile sayısal
//                  karşılaştırmada kullanmak.

// --- KAVRAM ---
int yas;
Console.Write("Yaşınızı girin : ");
yas = Convert.ToInt32(Console.ReadLine());

if (yas < 18)
    Console.WriteLine("Sütünü iç gel!");
else
    Console.WriteLine("Ehliyet alabilir");
Console.ReadKey();

// --- SEN YAP ---
// Yaşı tam 18 gir. Hangi satırın çalışacağını önce tahmin et, sonra çalıştırıp doğrula.

// --- MERAK KÖŞESİ ---
// using System; ... nedir?
// Bu satırlar C#'ın hazır kütüphanelerini projene katar; Console da bunlardan biri.
// Ama hepsi her programda kullanılmaz: bu derste yalnızca System (Console için) işe
// yaradı, System.Linq/System.Text/System.Threading.Tasks hiç çalışmadı — VS yine de
// hepsini otomatik ekler. İleri'de tek tek açacağız.
