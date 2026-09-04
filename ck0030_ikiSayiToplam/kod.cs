// ck0030 — İki sayının toplamı
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: int değişken tanımlamak, Convert.ToInt32 ile klavyeden okunan yazıyı
//                  sayıya dönüştürmek, sayılarda + ile toplama yapmak
//                  (bir önceki derste + iki yazıyı birleştiriyordu, burada iki sayıyı toplar)
//
// Kara kutu: VS iskeleti + Console.ReadKey (ck0010). Ön izleme: namespace, kodlarını bir
// isim altında gruplayan "klasör" gibidir, çakışmayı önler — ileride (ckXXXX) açacağız.

// --- KAVRAM ---
int s1, s2, toplam; // int tipinde üç değişken tanımlandı
Console.Write("1. Sayıyı giriniz : ");
s1 = Convert.ToInt32(Console.ReadLine()); // klavyeden okunan yazı, sayıya (int) dönüştürüldü
Console.Write("2. Sayıyı giriniz : ");
s2 = Convert.ToInt32(Console.ReadLine());
toplam = s1 + s2; // burada + iki yazıyı değil, iki sayıyı toplar
Console.WriteLine("Klavyeden girilen sayıların toplamı : " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, toplama yerine çıkarma yapacak şekilde değiştir
// ("Klavyeden girilen sayıların farkı : ..." yazdırsın).
