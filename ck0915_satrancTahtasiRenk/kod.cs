// ck0915 — Satranç tahtası deseni (renk + iç içe döngü)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0650/ck0655'teki ConsoleColor'ı iki boyutlu bir desene
//                  uyguluyoruz — (satır+sütun) çift mi tek mi kontrolü, klasik
//                  "satranç tahtası" tekniği, renkleri satır/sütuna göre değiştiriyor.

// --- KAVRAM ---
Console.Write("X değerini girin: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y değerini girin: ");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if ((i + j) % 2 == 0)
            Console.BackgroundColor = ConsoleColor.Yellow;
        else
            Console.BackgroundColor = ConsoleColor.White;
        Console.Write("  ");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// (i + j) % 2 yerine sadece i % 2 kullansan desen nasıl değişir (ipucu: artık
// sütuna değil sadece satıra mı bakıyor)?
