// ck0320 — Birler basamağını bulma: sayi % 10
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayıyı 10'a bölünce kalan, o sayının birler basamağını verir —
//                  4728 % 10 = 8, çünkü 4728'in son rakamı 8'dir.

// --- KAVRAM ---
int sayi, birlerBasamagi;
Console.Write("Klavyeden analiz edilecek sayıyı girin : ");
sayi = Convert.ToInt32(Console.ReadLine());
birlerBasamagi = sayi % 10;
Console.Write("Birler Basamağındaki Rakam : " + birlerBasamagi);
Console.ReadKey();

// --- SEN YAP ---
// 4728, 50 ve 9 ile üç kez çalıştır. 50 için sonucu önce tahmin et (0 mı çıkar?), sonra
// çalıştırıp doğrula.
