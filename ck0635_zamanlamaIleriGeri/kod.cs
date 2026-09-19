// ck0635 — Sonsuz döngüde ileri-geri sayma
// NASIL: Dosyanın en üstüne `using System.Threading;` ekle. Sonra aşağıdakini
//        Main() içine yapıştır.
// Ne öğreneceğiz: ck0499'daki artan/azalan sayaç tekniğini burada zamanlamayla
//                  birleştiriyoruz — for(;;) içine iki ayrı for koyup önce ileri,
//                  sonra geri saydırıyoruz, sonsuza kadar tekrar ediyor.

// --- KAVRAM ---
for (; ; )
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write(i);
        Thread.Sleep(250);
        Console.Clear();
    }
    for (int i = 9; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(250);
        Console.Clear();
    }
}

// --- SEN YAP ---
// 10'ar 10'ar artıp azalacak şekilde güncelle (0, 10, 20... sonra geri 20, 10, 0).
