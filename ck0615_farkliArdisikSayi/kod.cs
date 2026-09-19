// ck0615 — Ardışık aynı sayıyı engelleme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0610'da art arda üretilen sayılar birbirinin aynı olabiliyordu.
//                  Burada bir önceki sayıyı hatırlayıp yeni sayı ona eşitse yeniden
//                  üretiyoruz — iç içe döngü değil, for içinde while ile "tekrar dene".

// --- KAVRAM ---
Random rastgele = new Random();
int oncekiSayi = -1;

for (int i = 0; i < 5; i++)
{
    int tutulansayi = rastgele.Next(0, 10);
    while (tutulansayi == oncekiSayi)
        tutulansayi = rastgele.Next(0, 10);
    Console.WriteLine("Tutulan sayı: " + tutulansayi);
    oncekiSayi = tutulansayi;
}
Console.ReadKey();

// --- SEN YAP ---
// oncekiSayi'nin başlangıç değerini -1 yerine 0 yap, birkaç kez çalıştır. İlk üretilen
// sayı 0 çıktığında ne oluyor, neden -1 kullanmak daha güvenli?
