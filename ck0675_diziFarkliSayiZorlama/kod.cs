// ck0675 — Diziye farklı sayılar girmeye zorlama (bu ders bilerek kusurlu)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir öncekiyle AYNI sayı girilirse tekrar sormak için iç içe for +
//                  i--/k-- ile "geri sarma" deneniyor. Bu ders BİLEREK ck0680 ile
//                  karşılaştırma için kusurlu bırakıldı — çalıştırıp garip davranışı
//                  gözlemleyeceğiz, ck0680'de neden düzeltildiğini göreceğiz.

// --- KAVRAM ---
int[] sayilar = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    for (int k = 0; k < i; k++)
    {
        if (sayilar[i] == sayilar[k])
        {
            Console.Write("Dizinin " + (i + 1) + ". elemanını tekrar girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            i--;
            k--;
        }
    }
}
Console.WriteLine("Sonuç:");
for (int i = 0; i < 5; i++)
    Console.WriteLine(sayilar[i]);
Console.ReadKey();

// --- SEN YAP ---
// Şu sırayla gir: 10, 20, 20, 30, 30, 30, 40, 50 (8 değer hazırla). Kaç kez "tekrar
// girin" istendiğini ve toplam kaç değer girmen istendiğini say — beklediğinden
// fazla mı çıktı?
