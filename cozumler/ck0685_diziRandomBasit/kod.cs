int[] sayilar = new int[10];
Random rastgele = new Random();
for (int i = 0; i < 10; i++)
    sayilar[i] = rastgele.Next(0, 1000);

for (int i = 0; i < 10; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();
