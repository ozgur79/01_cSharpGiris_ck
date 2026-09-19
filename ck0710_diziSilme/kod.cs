// ck0710 — Dizide silme (Array.Clear)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Array.Clear(dizi, başlangıçİndisi, kaçEleman) belirtilen aralıktaki
//                  elemanları o tipin varsayılan değerine (int için 0) döndürür —
//                  dizinin boyutu değişmez, sadece içerik sıfırlanır.

// --- KAVRAM ---
int[] dizi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Mevcut dizi:");
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);

Array.Clear(dizi, 2, 4);

Console.WriteLine("Silme işleminden sonra:");
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);
Console.ReadKey();

// --- SEN YAP ---
// Array.Clear(dizi, 2, 4) yerine Array.Clear(dizi, 0, dizi.Length) dene — ne olur?
