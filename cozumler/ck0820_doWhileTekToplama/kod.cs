int sayi, toplam = 0;
do
{
    Console.Write("Tek sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 0)
        Console.WriteLine("Çıkılıyor.");
    else if (sayi % 2 == 1)
    {
        toplam = toplam + sayi;
        Console.WriteLine("Şimdiye kadarki tek sayıların toplamı: " + toplam);
    }
    else
        Console.WriteLine("Dikkat, TEK sayı girilecek: ");
} while (sayi != 0);
Console.WriteLine("Programdan çıkıldı.");
Console.ReadKey();
