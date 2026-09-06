// ck0210 — Askerlik kontrolü: && (mantıksal VE)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: && iki koşulun İKİSİ BİRDEN doğru olmasını ister (|| en az birini
//                  yeterli görüyordu, ck0190'da görmüştük). Burada || ve && aynı satırda
//                  bir arada kullanılıyor: "(cinsiyet e ya da E) VE (yaş 18+)".

// --- KAVRAM ---
char cinsiyet;
int yas;
Console.Write("Cinsiyetinizi Girin (E/K) : ");
cinsiyet = Convert.ToChar(Console.ReadLine());
Console.Write("Yaşınızı Girin : ");
yas = Convert.ToInt32(Console.ReadLine());
if ((cinsiyet == 'e' || cinsiyet == 'E') && yas >= 18)
    Console.WriteLine("Asker olabilir");
else
    Console.WriteLine("Askerlik için uygun değil!");
Console.ReadKey();

// --- SEN YAP ---
// (cinsiyet=e, yaş=20), (cinsiyet=e, yaş=15), (cinsiyet=k, yaş=25) ile üç kez çalıştır,
// sonucu önce tahmin et. Sonra parantezleri kaldırıp satırı
// "if (cinsiyet == 'e' || cinsiyet == 'E' && yas >= 18)" yaz — (cinsiyet=e, yaş=15)
// girişinde sonuç değişir mi? Neden?
