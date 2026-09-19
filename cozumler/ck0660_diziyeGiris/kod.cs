int[] sayilar = new int[3];

Console.Write("Dizinin 1. elemanını girin: ");
sayilar[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Dizinin 2. elemanını girin: ");
sayilar[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Dizinin 3. elemanını girin: ");
sayilar[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sayilar[0] + ", " + sayilar[1] + ", " + sayilar[2]);
Console.ReadKey();
