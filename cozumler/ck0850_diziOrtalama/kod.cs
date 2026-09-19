int[] tekSayilar = new int[6];
int toplam = 0;
Random rastgele = new Random();
for (int i = 0; i < 5;)
{
    int tutulansayi = rastgele.Next(0, 255);
    if (tutulansayi % 2 == 1)
    {
        tekSayilar[i] = tutulansayi;
        i++;
    }
}
for (int i = 0; i < 5; i++)
    toplam = toplam + tekSayilar[i];
int ortalama = toplam / 5;
tekSayilar[5] = ortalama;
Console.WriteLine("Ortalama: " + tekSayilar[5]);
Console.ReadKey();
