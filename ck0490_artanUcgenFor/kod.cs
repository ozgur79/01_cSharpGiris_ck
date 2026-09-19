// ck0490 — İç döngü sınırını dış sayaca bağlayarak artan üçgen
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Şimdiye kadar iç döngünün sınırı hep sabit bir sayıydı (5, 10...).
//                  Burada iç döngünün sınırı dış döngünün kendi sayacı (k) — k arttıkça
//                  içteki döngü de bir fazla dönüyor, satır satır büyüyen bir üçgen çıkıyor.

// --- KAVRAM ---
for (int k = 1; k < 11; k++)
{
    for (int i = 0; i < k; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// k'nin başlangıcını 1 yerine 3 yap — üçgenin ilk satırı kaç yıldızla başlıyor şimdi?
// Üst sınırı da 11'den 6'ya indir, üçgen kaç satır sürüyor say.
// Sonra her satırın son yıldızını + yap (ipucu: iç döngüde i==k-1 kontrolü ekle).
