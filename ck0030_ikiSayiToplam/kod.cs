// ck0030 — İki sayının toplamı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: int değişken tanımlamak, Convert.ToInt32 ile klavyeden okunan yazıyı
//                  sayıya dönüştürmek, sayılarda + ile toplama yapmak
//                  (bir önceki derste + iki yazıyı birleştiriyordu, burada iki sayıyı toplar)
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak, hepsini ileride tek tek açacağız.

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

// --- MERAK KÖŞESİ ---
// namespace <proje adın> ne işe yarar?
// ck0020'de using'in hazır kütüphaneleri projene kattığını söylemiştik. namespace ise
// senin YAZDIĞIN kodları bir isim altında toplayan "klasör" gibidir — VS bu ismi
// proje adından kendisi üretti. 
