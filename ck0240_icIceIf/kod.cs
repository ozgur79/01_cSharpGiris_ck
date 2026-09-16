// ck0240 — İç içe if (nested if): kullanıcı adı, sonra şifre
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir if bloğunun içine ikinci bir if yazmak (iç içe if) — dıştaki if
//                  yanlış (false) çıkarsa içteki if hiç çalışmaz, hiç sorulmaz bile.

// --- KAVRAM ---
Console.Write("Kullanıcı Adınızı Girin: ");
string kadi = Console.ReadLine();
if (kadi == "ogrenci" || kadi == "OGRENCI" || kadi == "Ogrenci") // dıştaki if
{
    Console.Write("Şifrenizi Girin: ");
    string sifre = Console.ReadLine();
    if (sifre == "kalfa123") // içteki if — sadece dıştaki True ise buraya gelinir
        Console.WriteLine("Başarılı Giriş :)");
    else
        Console.WriteLine("Hatalı Şifre");
}
else
{
    Console.WriteLine("Hatalı giriş!");
}
Console.ReadKey();

// --- SEN YAP ---
// Üç kez çalıştır: 1) kadi=ogrenci, sifre=kalfa123  2) kadi=OGRENCI, sifre=yanlis
// 3) kadi=mehmet (şifre hiç sorulmayacak — neden?). Üçünü de tahmin edip sonra doğrula.
