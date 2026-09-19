// ck0610 — Döngüde N adet rastgele sayı üretme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0530'daki tek seferlik Random kullanımını bir for döngüsüne
//                  koyup art arda birden fazla rastgele sayı üretiyoruz.

// --- KAVRAM ---
Random rastgele = new Random();
for (int i = 0; i < 5; i++)
{
    int tutulansayi = rastgele.Next(0, 10);
    Console.WriteLine("Bilgisayarın tuttuğu sayı: " + tutulansayi);
}
Console.ReadKey();

// --- SEN YAP ---
// 5 yerine kaç adet üretileceğini kullanıcıdan al.
