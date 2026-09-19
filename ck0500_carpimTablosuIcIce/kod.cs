// ck0500 — Çarpım tablosu: iç içe for pekiştirme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0465'teki iç içe for'u (dikdörtgen çizen) burada gerçek bir hesaplama
//                  problemine uyguluyoruz — dış döngü hangi sayının tablosu, iç döngü o
//                  sayının 1'den 10'a kadar katları.

// --- KAVRAM ---
int n;
Console.Write("Çarpım tablosu kaça kadar olsun? ");
n = Convert.ToInt32(Console.ReadLine());

for (int j = 1; j <= n; j++)
{
    for (int x = 1; x <= 10; x++)
    {
        Console.WriteLine(j + " x " + x + " = " + (j * x));
    }
    Console.WriteLine("--------------------");
}
Console.ReadKey();

// --- SEN YAP ---
// İç döngünün sınırını (10) sabit bırakma — kullanıcıdan ikinci bir sayı (m) daha al,
// "1'den m'ye kadar" çarpım tablosu yazdır. n=3, m=5 girildiğinde kaç satır çıktı beklersin?
