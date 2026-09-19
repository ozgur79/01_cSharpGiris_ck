// ck0680 — Diziye farklı sayılar girmeye zorlama (düzeltilmiş)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0675'teki i--/k-- yerine bir "tekrar" bayrağı (flag) ve k=-1
//                  kullanıyoruz — inner döngü kendi k++'ıyla doğru şekilde k=0'a
//                  dönüyor, outer döngü gereksiz yere aynı indisi tekrar işlemiyor.

// --- KAVRAM ---
int tekrar = 0;
int[] sayilar = new int[5];
for (int i = 0; i < 5; i++)
{
    if (tekrar == 1)
    {
        Console.Write("Dizinin " + (i + 1) + ". elemanını tekrar girin: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        tekrar = 0;
    }
    else
    {
        Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int k = 0; k < i; k++)
    {
        if (sayilar[i] == sayilar[k])
        {
            tekrar = 1;
            i--;
            k = -1;
        }
    }
}
Console.WriteLine("Sonuç:");
for (int i = 0; i < 5; i++)
    Console.WriteLine(sayilar[i]);
Console.ReadKey();

// --- SEN YAP ---
// Aynı test sırasını (10, 20, 20, 30, 30, 30, 40, 50... gerekirse daha az) dene —
// bu sefer toplam kaç değer girmen istendi? ck0675 ile karşılaştır.
