// ck0725 — Diziyi tersleme (Array.Reverse)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Array.Reverse(dizi) dizinin eleman sırasını baştan sona ters
//                  çevirir — ck0725'e kadar sırayı elle (döngüyle) değiştiriyorduk,
//                  bu hazır metotla tek satırda yapılıyor.

// --- KAVRAM ---
string[] dizi = { "ahmet", "mehmet", "veli" };
Console.WriteLine("Mevcut dizi:");
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);

Console.WriteLine("Ters sıralama:");
Array.Reverse(dizi);
for (int i = 0; i < dizi.Length; i++)
    Console.WriteLine(dizi[i]);
Console.ReadKey();

// --- SEN YAP ---
// Array.Reverse(dizi) satırını iki kez art arda çağırırsan dizi ne durumda olur?
