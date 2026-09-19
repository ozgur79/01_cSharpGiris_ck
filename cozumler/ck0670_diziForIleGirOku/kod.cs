int[] sayilar = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 6; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();
