// ck0250 — Aynı giriş kontrolü, tek if ile (&& ile indirgeme)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0240'taki iç içe if ile yaptığımız kontrolü, && (ck0210'da görmüştük)
//                  kullanarak tek bir if'e indirgemek — aynı sonuca iki farklı yoldan
//                  ulaşılabildiğini görmek.

// --- KAVRAM ---
string kadi, sifre;
Console.Write("Kullanıcı adını girin: ");
kadi = Console.ReadLine();
Console.Write("Şifreyi girin: ");
sifre = Console.ReadLine();
if ((kadi == "ogrenci" || kadi == "OGRENCI" || kadi == "Ogrenci") && sifre == "kalfa123")
    Console.WriteLine("Başarılı Giriş :)");
else
    Console.WriteLine("Hatalı Giriş");
Console.ReadKey();

// --- SEN YAP ---
// ck0240'taki aynı üç senaryoyu burada da dene: 1) ogrenci/kalfa123  2) OGRENCI/yanlis
// 3) mehmet/kalfa123. Sonuçlar ck0240 ile aynı mı çıkıyor? İki kod farklı yazılmış olsa da
// neden aynı sonucu veriyor?

// --- MERAK KÖŞESİ ---
// static void Main(string[] args) hâlâ aynı yerde duruyor (3. ve son tur)
// ck0050'de burasının programın başladığı satır olduğunu, ck0120'de kodun buradan aşağı
// doğru sırayla çalıştığını söylemiştik. Bugün ck0240 ile ck0250 aynı işi iki farklı
// yazımla yaptı ama ikisi de yine bu satırdan başladı — yazım değişebilir, başlangıç
// satırı değişmez. Bu kutuyu ünite 07'de gerçekten açacağız, o zamana kadar burada bir
// daha durmayacağız.
