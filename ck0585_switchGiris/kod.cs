// ck0585 — switch'e giriş
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Çok sayıda == karşılaştırmalı else if zincirini (ck0180) switch ile
//                  daha okunaklı yazabiliriz — her case tek bir olası değeri karşılar.

// --- KAVRAM ---
Console.Write("Kaçıncı ayın adını öğrenmek istiyorsun: ");
byte ay = Convert.ToByte(Console.ReadLine());
switch (ay)
{
    case 1:
        Console.Write(ay + ". Ayın adı: OCAK");
        break;
    case 2:
        Console.Write(ay + ". Ayın adı: ŞUBAT");
        break;
    case 3:
        Console.Write(ay + ". Ayın adı: MART");
        break;
    default:
        Console.Write("1-3 arası sayı girin");
        break;
}
Console.ReadKey();

// --- SEN YAP ---
// 4-NİSAN ve 5-MAYIS case'lerini ekle, default mesajını "1-5 arası sayı girin" yap.
