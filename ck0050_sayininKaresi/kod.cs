// ck0050 — Sayının karesi
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayıyı kendisiyle çarparak karesini almak
//                  (aynı * operatörü, önceki derste bir sayıyı sabitle çarpmıştık,
//                  burada değişkeni kendisiyle çarpıyoruz)
//
// Şimdilik kara kutu (ck0010'da tanıtıldı, henüz açılmadı):
//   VS2013 iskeleti (using'ler + namespace + class Program + Main) + Console.ReadKey();

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
