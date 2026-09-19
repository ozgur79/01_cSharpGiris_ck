// ck0795 — Ondalıklı sayı girişi: virgül mü, nokta mı?
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Türkçe ayarlarda ondalık ayracı NOKTA değil VİRGÜLDÜR. "3.5" yazarsan
//                  hata almazsın ama SESSİZCE yanlış bir sayı okunur — bu yüzden "3,5"
//                  yazman gerekir.

// --- KAVRAM ---
Console.Write("Klavyeden ondalıklı sayı girin: ");
double ondalikliSayi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Girilen sayının iki katı: " + (ondalikliSayi * 2));
Console.ReadKey();

// --- SEN YAP ---
// Programı önce "3,5" ile, sonra "3.5" ile çalıştır. İkisinin de çıktısını not al —
// hangisi beklediğin sonucu veriyor?
