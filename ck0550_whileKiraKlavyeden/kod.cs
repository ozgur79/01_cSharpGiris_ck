// ck0550 — while ile kira hesabı (klavyeden değerler)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0545'teki sabit kira ve zam oranı burada kullanıcıdan alınıyor —
//                  aynı while mantığı, artık farklı girdilerle farklı sonuç üretebiliyor.

// --- KAVRAM ---
int baslangicYili = 2022;
int bitisYili = 2031;
double kira;
int zam;

Console.Write("Kiranın başlangıç değerini girin: ");
kira = Convert.ToInt32(Console.ReadLine());
Console.Write("Her yıl yüzde kaç zam gelsin: ");
zam = Convert.ToInt32(Console.ReadLine());

while (baslangicYili <= bitisYili)
{
    Console.WriteLine("Yıl: " + baslangicYili + " Kira: " + kira);
    kira = kira + (kira * zam / 100);
    baslangicYili++;
}
Console.ReadKey();

// --- SEN YAP ---
// bitisYili'yi de klavyeden al (baslangicYili'den sonra kaç yıl hesaplanacağını sor).
