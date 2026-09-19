int toplam = 0;
int[] sayilar = new int[6];
Random rastgele = new Random();
for (int i = 0; i < 5; i++)
{
    int rasgele = rastgele.Next(0, 10);
    sayilar[i] = rasgele;
    toplam = toplam + rasgele;
}
sayilar[5] = toplam;

for (int i = 0; i < 6; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();
