// ck0735 — İki diziden rastgele veri çekme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: AYNI rastgele indisi iki farklı diziye uygulayarak "eşleşen" iki
//                  değer seçiyoruz — örn. rastgele bir erkek ismi ile rastgele bir
//                  kadın ismi, ama İKİSİ DE aynı sıradaki (index) isimler.

// --- KAVRAM ---
string[] erkek = { "ahmet", "mehmet", "ali", "mustafa", "yasin", "serdar", "kazım" };
string[] bayan = { "ayşe", "fatma", "elif", "gülşah", "zeynep", "gülay", "buse" };
Random rastgele = new Random();
int index = rastgele.Next(0, erkek.Length);
Console.WriteLine(erkek[index]);
Console.WriteLine(bayan[index]);
Console.ReadKey();

// --- SEN YAP ---
// erkek ve bayan dizilerine birer isim daha ekle (8. eleman), ikisine de AYNI sırada
// eklediğinden emin ol — yoksa index eşleşmesi bozulur.
