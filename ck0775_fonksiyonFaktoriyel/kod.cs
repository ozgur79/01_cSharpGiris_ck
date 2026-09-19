// ck0775 — Fonksiyon ile faktöriyel
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki FaktoriyelAl metodunu class Program içine, Main()'in
//        dışına ekle.
// Ne öğreneceğiz: ck0390'daki faktöriyel hesaplaması artık bir fonksiyonun içinde —
//                  ck0765 (toplam) ile aynı kalıp, bu kez çarpımsal biriktirici ile.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
int sayi;
Console.Write("Faktöriyeli alınacak sayıyı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = FaktoriyelAl(sayi);
Console.WriteLine(sayi + "! = " + sonuc);
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int FaktoriyelAl(int sayi)
{
    int sonuc = 1;
    for (int i = 1; i <= sayi; i++)
        sonuc *= i;
    return sonuc;
}

// --- SEN YAP ---
// sayi=0 girilirse FaktoriyelAl ne döndürür? Matematikte 0! kaça eşittir, kodun
// verdiği sonuç bununla uyuşuyor mu?
