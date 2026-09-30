// ck0075 — Kendi metodumu yazmak: void ve return
// NASIL: Yeni bir Console Application aç. "1. BÖLÜM"ü Main() içine yapıştır;
//        "2. BÖLÜM"deki iki metodu class Program içine, Main()'in dışına ekle.
// Ne öğreneceğiz: ck0070'te hazır metotları (Console.WriteLine) tanımıştık. Şimdi kendi
//                  metodumuzu yazıyoruz: adını sen koyarsın, Main() içinden adını yazarak
//                  çağırırsın. `void` metot iş yapar; `int` metot işin sonucunu `return`
//                  ile geri gönderir.
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak, hepsini ünite 07'de tek tek açacağız.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
int a;
Console.WriteLine("dene");
tanit();                 // void metodu çağırdık: içindeki satırlar çalışıp geri dönüldü
a = Topla();             // int metodu çağırdık: dönen sonuç a'ya yazıldı
Console.Write(a);
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static void tanit()
{
    Console.WriteLine("ben tanit metoduyum");
    Console.WriteLine("Main() beni çağırdı");
    Console.WriteLine("c# öğreniyorum");
}

static int Topla()
{
    int sonuc = 10 + 20;
    return sonuc;        // sonucu metodu çağıran yere geri gönderir
}

// --- SEN YAP ---
// 1) tanit() satırını Main() içinde iki kez art arda yaz, çıktının kaç kez tekrarlandığını gör.
// 2) Topla() içindeki 10 + 20'yi kendi sayılarınla değiştir, sonucun değiştiğini gözle.
