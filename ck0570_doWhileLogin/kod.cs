// ck0570 — do-while ile giriş doğrulama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0210'daki || (VEYA) operatörünü burada do-while ile birlikte
//                  kullanıyoruz — kullanıcı adı VEYA şifre yanlışsa (ikisinden biri
//                  bile tutmuyorsa) döngü tekrar sorar.

// --- KAVRAM ---
string kulad = "";
string sifre = "";
do
{
    Console.Write("Kullanıcı adı: ");
    kulad = Console.ReadLine();
    Console.Write("Şifre: ");
    sifre = Console.ReadLine();
    Console.WriteLine("Yanlış giriş yaptınız!");
} while ((kulad != "ogrenci") || (sifre != "kalfa123"));
Console.Clear();
Console.WriteLine("Tebrikler, başarılı giriş!");
Console.ReadKey();

// --- SEN YAP ---
// Doğru girişte "Yanlış giriş yaptınız!" satırının hiç görünmediğini fark ettin mi?
// Console.Clear(); satırını yorum satırı yap, o satırın gerçekte de yazıldığını gör.
