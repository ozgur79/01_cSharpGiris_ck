// ck0755 — Fonksiyon ile string ters çevirme
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki cevir metodunu class Program içine, Main()'in DIŞINA ekle
//        (ck0750'deki gibi — metotlar Main ile aynı kutuda, içinde değil).
// Ne öğreneceğiz: ck0750'deki elemanEkle/listele bir şey DÖNDÜRMÜYORDU (void).
//                  cevir ise PARAMETRE alıyor VE bir değer DÖNDÜRÜYOR (return
//                  string) — ayrıntısını sıradaki derste (ck0760) göreceğiz.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
Console.Write("Bir kelime girin: ");
string girilen = Console.ReadLine();
string cevrilmis = cevir(girilen);
Console.WriteLine("Tersine çevrilmiş: " + cevrilmis);
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static string cevir(string str)
{
    char[] harfler = str.ToCharArray();
    int uzunluk = harfler.Length;
    for (int k = 0; k < uzunluk / 2; k++)
    {
        char gecici = harfler[k];
        harfler[k] = harfler[uzunluk - 1 - k];
        harfler[uzunluk - 1 - k] = gecici;
    }
    return new string(harfler);
}

// --- SEN YAP ---
// Tek harfli ("a") ve boş ("") bir kelime dene — cevir fonksiyonu hata verir mi?
