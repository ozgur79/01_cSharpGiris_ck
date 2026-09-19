// ck0860 — Dizi döndüren fonksiyon (fonksiyon + dizi kapanışı)
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki rasgeleXtek metodunu class Program içine, Main()'in
//        dışına ekle.
// Ne öğreneceğiz: ck0760-ck0785'teki fonksiyonlar int/string döndürüyordu.
//                  Bir fonksiyon bir DİZİ de döndürebilir — dönüş tipi int[]
//                  olur, ck0690'daki dizi doldurma mantığı artık bir fonksiyonun
//                  içinde ve dışarıya tam bir dizi veriyor.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
Console.Write("Kaç adet tek sayı tutulacak: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] sonuc = rasgeleXtek(x);
foreach (int sayi in sonuc)
    Console.Write(sayi + " ");
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static int[] rasgeleXtek(int x)
{
    Random rastgele = new Random();
    int[] tekSayilar = new int[x];
    for (int i = 0; i < x;)
    {
        int tutulansayi = rastgele.Next(0, 255);
        if (tutulansayi % 2 == 1)
        {
            tekSayilar[i] = tutulansayi;
            i++;
        }
    }
    return tekSayilar;
}

// --- SEN YAP ---
// rasgeleXtek(0) çağırırsan ne olur? (ipucu: new int[0] geçerli mi, for döngüsü
// hiç çalışır mı?)
