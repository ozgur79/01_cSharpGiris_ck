// ck0565 — do-while: farklı bir çıkış değeri (sentinel)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0555'te döngüyü bitiren özel değer (sentinel) 0'dı. Burada aynı
//                  yapı, çıkış değeri olarak 0 değil 10 kullanıyor — sentinel istediğin
//                  herhangi bir değer olabilir, 0'a özgü değil.

// --- KAVRAM ---
int toplam = 0;
int sayi;
do
{
    Console.Write("Sayı girin (çıkmak için 10): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi;
} while (sayi != 10);
Console.WriteLine("Genel toplam: " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// Çıkış değerini 10 yerine kullanıcının kendi seçtiği bir sayı yap (programın başında
// "hangi sayıda durayım?" diye sor, o değeri sentinel olarak kullan).
