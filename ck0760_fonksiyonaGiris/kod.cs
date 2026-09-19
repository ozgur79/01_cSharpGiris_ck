// ck0760 — Fonksiyona giriş: parametre ve return
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki Topla metodunu class Program içine, Main()'in dışına ekle.
// Ne öğreneceğiz: Fonksiyon (metot), bağımsız bir kod bloğudur. Parantez içindeki
//                  değerler (parametre) fonksiyona veri taşır; `return` fonksiyondan
//                  bir sonucu geri gönderir. ck0750/ck0755'te bunu örnekleriyle
//                  görmüştük, şimdi genel kuralı adım adım açıklıyoruz.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
int sayi1, sayi2, sonuc;
Console.Write("1. sayıyı girin: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
sayi2 = Convert.ToInt32(Console.ReadLine());
sonuc = Topla(sayi1, sayi2);
Console.WriteLine("Toplam: " + sonuc);
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int Topla(int sayi1, int sayi2)
{
    int sonuc = 0;
    sonuc = sayi1 + sayi2;
    return sonuc;
}

// --- SEN YAP ---
// Topla metodunu Main() içindeki sayi1/sayi2 değişkenleriyle AYNI ADDA parametre
// alıyor — bu iki çift değişken birbirine karışıyor mu? Deneyerek gözlemle.
