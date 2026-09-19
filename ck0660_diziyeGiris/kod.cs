// ck0660 — Diziye giriş
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Birden fazla değeri TEK bir değişkende tutmak için dizi (array)
//                  kullanılır. `int[] sayilar = new int[2];` iki elemanlık bir kutu
//                  açar; her elemana `sayilar[0]`, `sayilar[1]` ile (indis ile) erişilir.

// --- KAVRAM ---
int[] sayilar = new int[2];

Console.Write("Dizinin 1. elemanını girin: ");
sayilar[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dizinin ilk elemanı: " + sayilar[0]);

Console.Write("Dizinin 2. elemanını girin: ");
sayilar[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dizinin ikinci elemanı: " + sayilar[1]);
Console.ReadKey();

// --- SEN YAP ---
// Diziyi 3 elemanlık yap (new int[3]), üçüncü elemanı da klavyeden al ve yazdır.
