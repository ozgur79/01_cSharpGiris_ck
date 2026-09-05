// ck0100 — Veri tipleriyle tanışma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: her değişkenin bir veri tipi vardır — tip, değişkenin ne tür bilgi
//                  tutacağını ve bellekte ne kadar yer kapladığını belirler. int/double/
//                  string'i zaten kullanıyorduk; burada bool (doğru/yanlış) ve char (tek
//                  karakter) tiplerini tanıyoruz, ayrıca byte'ın int'e benzeyen ama daha
//                  küçük bir tam sayı tipi olduğunu görüyoruz.

// --- KAVRAM ---
byte kucukSayi = 255; // byte, int'e benzer ama çok daha küçük bir aralıkta tam sayı tutar
Console.WriteLine(kucukSayi);

int sayi = 5; // zaten bildiğimiz tam sayı tipi
Console.WriteLine(sayi);

double ortalama = 35.32; // zaten bildiğimiz, virgüllü sayı tipi
Console.WriteLine(ortalama);

bool durum = true; // bool sadece iki değer alır: true (doğru) ya da false (yanlış)
Console.WriteLine(durum);

char karakter = '?'; // char tek bir karakter tutar, tek tırnak ile yazılır
Console.WriteLine(karakter);

string cumle = "Benim adım Ahmet"; // zaten bildiğimiz yazı (metin) tipi, çift tırnak ile yazılır
Console.WriteLine(cumle);
Console.ReadKey();

// --- SEN YAP ---
// Kendi bilgilerini tutan beş değişken tanımla: adını tutan bir string, yaşını tutan
// bir int, boyunu (örn. 1.75) tutan bir double, okula gidip gitmediğini tutan bir bool,
// adının ilk harfini tutan bir char. Hepsini Console.WriteLine ile ekrana yazdır.
