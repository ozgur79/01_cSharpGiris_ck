// ck0825 — Puan/not: çok dallı karar + geçersizse tekrar sorma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0150'deki çok dallı karar (if/else if) ile ck0430'daki
//                  retry-on-invalid deseni birlikte — 4 not aralığı + geçersiz
//                  puanda tekrar sorma, hepsi tek bir for(;;) içinde.

// --- KAVRAM ---
Console.Write("Puanınızı girin: ");
int puan = Convert.ToInt32(Console.ReadLine());
for (; ; )
{
    if (puan >= 0 && puan <= 49)
    {
        Console.Write("Kaldı");
        break;
    }
    else if (puan >= 50 && puan < 70)
    {
        Console.Write("Orta");
        break;
    }
    else if (puan >= 70 && puan < 85)
    {
        Console.Write("İyi");
        break;
    }
    else if (puan >= 85 && puan < 101)
    {
        Console.Write("Pek iyi");
        break;
    }
    else
    {
        Console.Write("Geçersiz puan, tekrar girin: ");
        puan = Convert.ToInt32(Console.ReadLine());
    }
}
Console.ReadKey();

// --- SEN YAP ---
// puan=49 ile puan=50 dene — sınır değerler doğru aralığa mı düşüyor? Her aralığın
// başlangıç/bitiş sınırlarını (>= ve <) dikkatle oku.
