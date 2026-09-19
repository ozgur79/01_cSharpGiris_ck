int[] onunKatlari = new int[3];
Random rastgele = new Random();
for (int i = 0; i < 3;)
{
    int sayi = rastgele.Next(0, 100);
    if (sayi % 10 == 0)
    {
        Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayi);
        onunKatlari[i] = sayi;
        i++;
    }
}
Console.ReadKey();
