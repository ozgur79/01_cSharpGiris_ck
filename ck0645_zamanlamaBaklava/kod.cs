// ck0645 — Baklava deseni + zamanlama: hareketli desen
// NASIL: Dosyanın en üstüne `using System.Threading;` ekle. Sonra aşağıdakini
//        Main() içine yapıştır.
// Ne öğreneceğiz: ck0525'teki baklava desenini for(;;) içine koyup her çiziminden
//                  sonra ekranı temizleyip tekrar çiziyoruz — desen ve zamanlama
//                  ailelerinin kapanışı, iki farklı konunun bir araya gelmesi.

// --- KAVRAM ---
for (; ; )
{
    int d = 9;
    string yildiz = "";
    string bos = " ";
    for (int a = 0; a < 5; a++)
    {
        for (int b = 0; b < 5 - a; b++)
            yildiz = yildiz + "*";
        Console.Write(yildiz);
        Console.Write(bos);
        bos = bos + "  ";
        Console.WriteLine(yildiz);
        yildiz = "";
    }
    bos = "";
    for (int a = 1; a < 6; a++)
    {
        for (int b = 0; b < a; b++)
            yildiz = yildiz + "*";
        Console.Write(yildiz);
        for (int c = d; c > 0; c--)
            bos = bos + " ";
        Console.Write(bos);
        Console.WriteLine(yildiz);
        yildiz = "";
        bos = "";
        d -= 2;
    }
    Thread.Sleep(500);
    Console.Clear();
    Thread.Sleep(500);
}

// --- SEN YAP ---
// İki Thread.Sleep(500) satırını tek bir Thread.Sleep(1000) ile değiştir — görünüşte
// fark var mı? (İpucu: birincisi çizim BİTTİKTEN sonra bekler, Console.Clear() sonra
// gelir; birleştirirsen Clear() hemen çizimin ardından olur.)
