// ck0750 — Dizi + fonksiyon köprüsü (dizi ailesinin kapanışı)
// NASIL: Yeni bir Console Application aç. Bu ders İSTİSNA: aşağıdaki her şeyi
//        Main() içine YAPIŞTIRMA. Main() içine sadece "1. BÖLÜM"ü yapıştır; "2. BÖLÜM"
//        (iki alan + iki metot) class Program'ın içine ama Main()'in DIŞINA/ALTINA
//        eklenir — metotlar Main ile aynı kutuda (class) yaşar, Main'in içinde değil.
// Ne öğreneceğiz: Kendi yazdığımız bir fonksiyonu (metodu) ilk kez kullanıyoruz —
//                  elemanEkle ve listele, diziyi class'ın PAYLAŞILAN alanları
//                  (strDizi, elemanSayac) üzerinden yönetiyor. Ayrıntısını bir
//                  sonraki derste (ck0760, fonksiyona giriş) göreceğiz.

// --- KAVRAM: 1. BÖLÜM (Main() içine) ---
elemanEkle("Ali");
elemanEkle("Cemil");
listele();
Console.ReadKey();

// --- KAVRAM: 2. BÖLÜM (class Program içine, Main()'in dışına) ---
static string[] strDizi = new string[4];
static int elemanSayac = 0;

static void elemanEkle(string yeniEleman)
{
    strDizi[elemanSayac] = yeniEleman;
    elemanSayac++;
}

static void listele()
{
    for (int j = 0; j < elemanSayac; j++)
        Console.WriteLine(strDizi[j]);
}

// --- SEN YAP ---
// Main() içine üçüncü bir elemanEkle("Zeynep") çağrısı daha ekle, listele()'nin
// artık üç ismi de yazdırdığını gözlemle.
