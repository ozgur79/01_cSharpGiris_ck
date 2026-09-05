// ck0050 — Sayının karesi
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayıyı kendisiyle çarparak karesini almak
//                  (aynı * operatörü, önceki derste bir sayıyı sabitle çarpmıştık,
//                  burada değişkeni kendisiyle çarpıyoruz)


// --- KAVRAM ---
int sayi; // sayı için değişken
int karesi; // sonuç için ayrı bir değişken
Console.Write("Karesi alınacak sayıyı girin : ");
sayi = Convert.ToInt32(Console.ReadLine());
karesi = sayi * sayi; // sayı, kendisiyle çarpılıyor
Console.Write("Girilen sayının karesi = " + karesi);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, kare yerine küpünü (sayı * sayı * sayı) hesaplayacak şekilde değiştir.

// --- MERAK KÖŞESİ ---
// static void Main(string[] args) ne işe yarar?
// ck0040'ta class Program'ın kodlarını topladığı kutu olduğunu söylemiştik; Main o
// kutunun İÇİNDE, programın başladığı satır. İki katını aldığın kod bile Main'in
// içinde çalıştı. Ayrıntısını ünite 07'de (nesne tabanlı programlama) açacağız.
