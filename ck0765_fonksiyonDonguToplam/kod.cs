// ck0765 — Fonksiyon + döngü: 1'den N'e toplam
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki ToplaminiBul metodunu class Program içine, Main()'in
//        dışına ekle.
// Ne öğreneceğiz: ck0420'deki "1'den X'e toplam" döngüsü artık bir fonksiyonun
//                  İÇİNDE — hesaplama mantığı Main()'den ayrılıp kendi kutusuna taşındı.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
int sayi, sonuc;
Console.Write("1'den kaça kadar toplanacak: ");
sayi = Convert.ToInt32(Console.ReadLine());
sonuc = ToplaminiBul(sayi);
Console.WriteLine("1'den " + sayi + "'e kadar olan sayıların toplamı: " + sonuc);
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int ToplaminiBul(int sayi)
{
    int sonuc = 0;
    for (int i = 1; i <= sayi; i++)
        sonuc += i;
    return sonuc;
}

// --- SEN YAP ---
// sayi=0 girilirse ToplaminiBul ne döndürür? for döngüsü çalışır mı?
