// ck0540 — do-while döngüsüne giriş
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: while şartı ÖNCE kontrol eder, gövde belki hiç çalışmaz. do-while
//                  gövdeyi ÖNCE çalıştırır, şartı SONRA kontrol eder — yani en az bir
//                  kez çalışması garantidir.

// --- KAVRAM ---
int i = 0;
do
{
    i++;
    Console.WriteLine(i);
} while (i < 100);
Console.WriteLine("i'nin son değeri: " + i);
Console.ReadKey();

// --- SEN YAP ---
// i'yi 0 yerine 150'den başlat, döngünün hâlâ en az bir kez çalışıp çalışmadığını
// (100'den büyük olmasına rağmen) gözlemle. while (i < 100) olsaydı fark eder miydi?
