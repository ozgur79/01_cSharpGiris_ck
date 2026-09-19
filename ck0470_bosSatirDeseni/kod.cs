// ck0470 — Desende bir satırı boş bırakma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0465'teki dikdörtgene bir karar ekleniyor — dış döngünün sayacı
//                  belirli bir değere ulaştığında (i==4) o satırda hiç yıldız çizilmiyor,
//                  sadece satır atlanıyor.

// --- KAVRAM ---
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        Console.WriteLine();
    }
    else
    {
        for (int k = 0; k < 5; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
Console.ReadKey();

// --- SEN YAP ---
// i==4 yerine i==0 yap — hangi satır boş kalıyor şimdi? Sonra iki farklı satırı boş
// bırakmayı dene (ipucu: || kullanabilirsin, ck0190'da görmüştük).
// Boş bırakılmayan satırlarda son yıldızı + yap (ipucu: iç döngüde k==4 kontrolü ekle).
