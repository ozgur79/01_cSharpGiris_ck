// ck0905 — Sonsuz döngüde tekrar tekrar üçgen çizme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0490'daki artan üçgene her satırın başına numara (i:) ekliyoruz,
//                  ve tüm bunu bir for(;;) içine koyup kullanıcı her seferinde
//                  yeni bir boyut girip tekrar tekrar çizebiliyor — desen ailesi
//                  ile sonsuz döngünün başka bir birleşimi.

// --- KAVRAM ---
for (; ; )
{
    Console.Write("Bir sayı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= sayi; i++)
    {
        Console.Write(i + ":");
        for (int j = 0; j < i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
}

// --- SEN YAP ---
// 0 girersen ne olur (ipucu: for (int i=1; i<=0; ...) çalışır mı)? Programın
// sonsuz döngüsünü VS'in kırmızı Durdur butonuyla kapatman gerektiğini unutma.
