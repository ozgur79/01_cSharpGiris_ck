// ck0130 — Kare ve küp alma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayıyı kendisiyle üç kez çarparak küpünü almak (kare için iki
//                  çarpım yeterliydi, küp için üç); aynı programda iki farklı hesabı
//                  art arda yapmak.

// --- KAVRAM ---
double s1, s2, kare, kup;
Console.Write("Karesini alacağın sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Küpünü alacağın sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());
kare = s1 * s1;       // kare: sayı kendisiyle 1 kez çarpılır
kup = s2 * s2 * s2;    // küp: sayı kendisiyle 2 kez çarpılır (toplam 3 sayı)
Console.WriteLine("Sayının karesi: " + kare);
Console.WriteLine("Sayının küpü: " + kup);
Console.ReadKey();

// --- SEN YAP ---
// Programı 2 ve 5 sayılarıyla çalıştır. Küpün, kareye göre ne kadar hızlı büyüdüğünü
// gözlemle (2'nin karesiyle küpünü, 5'in karesiyle küpünü karşılaştır).

// --- MERAK KÖŞESİ ---
// Console.ReadKey() neden iki sonucu da yazdırdıktan sonra, en sonda duruyor?
// ck0060'ta ReadKey'in Main'den sonraki son satır olduğunu, o olmasa pencerenin anında
// kapanacağını söylemiştik. Bu derste iki ayrı sonuç (kare ve küp) hesaplanıyor — ReadKey
// ikisi de ekrana yazdırıldıktan SONRA çalışmalı, yoksa pencere ilk sonucu görmeden
// kapanabilir. Ayrıntı: ünite 07.
