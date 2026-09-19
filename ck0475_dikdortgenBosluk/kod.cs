// ck0475 — Dikdörtgende bir sütunu boş bırakma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0470'te karar satır bazındaydı (dış döngünün sayacına bakıyordu).
//                  Burada karar iç döngünün sayacına bakıyor — her satırda aynı sütunda
//                  (i==2) bir boşluk açılıyor.

// --- KAVRAM ---
for (int k = 0; k < 10; k++)
{
    for (int i = 0; i < 4; i++)
    {
        if (i == 2)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// i==2 yerine i==0 yap, boşluk hangi sütuna kayıyor gözlemle. Sonra dış döngünün sınırını
// 10'dan 3'e indir.
// Sonra her satırın son karakterini + yap (ipucu: iç döngüde i==3 kontrolü ekle).
