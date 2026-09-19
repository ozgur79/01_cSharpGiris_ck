int baslangicYili = 2022;
double kira;
int zam;
int kacYil;

Console.Write("Kiranın başlangıç değerini girin: ");
kira = Convert.ToInt32(Console.ReadLine());
Console.Write("Her yıl yüzde kaç zam gelsin: ");
zam = Convert.ToInt32(Console.ReadLine());
Console.Write("Kaç yıl hesaplansın: ");
kacYil = Convert.ToInt32(Console.ReadLine());

int bitisYili = baslangicYili + kacYil;
while (baslangicYili <= bitisYili)
{
    Console.WriteLine("Yıl: " + baslangicYili + " Kira: " + kira);
    kira = kira + (kira * zam / 100);
    baslangicYili++;
}
Console.ReadKey();
// kacYil=3 girilirse 2022'den 2025'e kadar (4 satır) hesaplanır — baslangicYili dahil.
