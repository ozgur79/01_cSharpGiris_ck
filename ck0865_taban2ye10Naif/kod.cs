// ck0865 — 10 tabanından 2 tabanına: ilk deneme (bilerek ters sırada çıkar)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir sayıyı ikili tabana çevirmenin klasik yolu — 2'ye böl, kalanı
//                  not et, tekrar et. BU DERS BİLEREK ters sırada yazdırıyor:
//                  ilk hesaplanan kalan en ÖNEMSİZ basamaktır ama önce o yazılıyor.
//                  Sırayı düzeltmenin üç farklı yolunu sıradaki derslerde göreceğiz.

// --- KAVRAM ---
Console.Write("10 tabanındaki sayıyı girin: ");
int taban10 = Convert.ToInt32(Console.ReadLine());
for (; ; )
{
    if (taban10 == 0)
        break;
    int kalan = taban10 % 2;
    taban10 = taban10 / 2;
    if (kalan == 1)
        Console.Write("1");
    else
        Console.Write("0");
}
Console.ReadKey();

// --- SEN YAP ---
// 6 sayısını dene — doğru ikili karşılığı "110"dur. Bu program ne yazdırıyor?
// Neden ters çıkıyor (ipucu: hangi basamak ÖNCE hesaplanıyor, en önemsiz mi en
// önemli mi)?
