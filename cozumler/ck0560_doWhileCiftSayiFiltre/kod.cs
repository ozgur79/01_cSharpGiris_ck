int sayi, toplam = 0, sayac = 0;
do
{
    Console.Write("Analiz edilecek sayıyı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        toplam = toplam + sayi;
        sayac++;
    }
} while (sayi % 2 == 0);
Console.WriteLine("Toplam: " + toplam + ", adet: " + sayac);
Console.ReadKey();
