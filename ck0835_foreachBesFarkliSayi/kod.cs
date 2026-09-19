// ck0835 — foreach ile 5 farklı sayı (ck0615'in tam çözümü)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0615'te diziler henüz yoktu, sadece ARDIŞIK tekrarı
//                  engelleyebiliyorduk. Şimdi dizi + foreach ile TÜM önceki
//                  sayılarla karşılaştırıp GERÇEKTEN tamamen farklı 5 sayı üretiyoruz.

// --- KAVRAM ---
int sayac = 0, kontrol = 0;
Random rastgele = new Random();
int[] sayilar = new int[5];
while (sayac < 5)
{
    int tutulansayi = rastgele.Next(1, 6);
    foreach (int gecici in sayilar)
    {
        if (tutulansayi == gecici)
        {
            kontrol = 1;
            break;
        }
    }
    if (kontrol == 0)
    {
        sayilar[sayac] = tutulansayi;
        sayac++;
    }
    kontrol = 0;
}
foreach (int sayi in sayilar)
    Console.Write(sayi + " ");
Console.ReadKey();

// --- SEN YAP ---
// rastgele.Next(1, 6) yerine rastgele.Next(0, 5) yazarsan (0 dahil olur) ck0830'daki
// "0 hiç çıkmıyor" sorunu burada da yaşanır mı? Neden bu dersin orijinali 1'den başlıyor?
