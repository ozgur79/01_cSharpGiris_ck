// ck0499 — Azalan sayaçla ters üçgen
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0490'da k artarak üçgeni büyütüyordu. Burada k azalarak (k--) başlıyor
//                  — ck0260'taki azalan sayaç deseniyle aynı teknik, bu kez yıldız sayısını
//                  küçültmek için kullanılıyor. Ünite 04'ü burada kapatıyoruz.

// --- KAVRAM ---
for (int k = 11; k > 0; k--)
{
    for (int i = 0; i < k; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// k'nin başlangıcını 11'den 6'ya indir, üçgenin ilk satırı kaç yıldızla başlıyor gözlemle.
// Sonra ck0490 (artan) ile bu dersi (azalan) art arda çalıştırıp aynı programda üstte artan
// altta azalan bir "elmas" şekli oluşturmaya çalış (ileri seviye, opsiyonel).
// Sonra her satırın son yıldızını + yap (ipucu: iç döngüde i==k-1 kontrolü ekle).
