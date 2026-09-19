// ck0715 — Diziye eleman ekleme (Array.Resize)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Dizinin boyutu normalde SABİTTİR (new ile bir kez belirlenir).
//                  Array.Resize diziyi GERÇEKTEN büyütür/küçültür — dizinin kendisini
//                  değiştirdiği için `ref` ile çağrılır (diziye referansla erişir).

// --- KAVRAM ---
string[] dizi = { "ahmet", "mehmet", "veli" };
Console.WriteLine("Mevcut dizi:");
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);

Array.Resize(ref dizi, 4);
Console.Write("Eklenecek elemanı girin: ");
string ekle = Console.ReadLine();
dizi[3] = ekle;

Console.WriteLine("Son dizi durumu:");
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);
Console.ReadKey();

// --- SEN YAP ---
// Array.Resize(ref dizi, 4) yerine Array.Resize(ref dizi, 2) dene — dizi küçülürse
// sondaki elemanlar ne olur?
