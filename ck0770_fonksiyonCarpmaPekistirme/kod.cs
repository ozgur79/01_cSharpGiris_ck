// ck0770 — Fonksiyon pekiştirme: çarpma
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki carp metodunu class Program içine, Main()'in dışına ekle.
// Ne öğreneceğiz: Kısa bir fonksiyon pekiştirmesi — bu kez sabit değerlerle,
//                  fonksiyonun kendisine odaklanmak için klavye girdisi yok.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
int a = 5, b = 6;
Console.WriteLine(carp(a, b));
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int carp(int a, int b)
{
    return a * b;
}

// --- SEN YAP ---
// carp metodunu, üç sayı alıp üçünü de çarpan bir metoda dönüştür (carpUc(a,b,c)).
