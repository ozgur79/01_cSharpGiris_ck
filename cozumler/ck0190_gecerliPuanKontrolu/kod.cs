// ck0190 SEN YAP çözümü
int puan;
Console.Write("Puanınızı girin : ");
puan = Convert.ToInt32(Console.ReadLine());
if (puan < 0 || puan > 100)
{
    Console.WriteLine("Geçersiz puan!");
    Console.WriteLine("Tekrar girin.");
}
else if (puan < 25)
    Console.WriteLine("Not : 0");
else if (puan < 50)
    Console.WriteLine("Not : 1");
else if (puan < 60)
    Console.WriteLine("Not : 2");
else if (puan < 70)
    Console.WriteLine("Not : 3");
else if (puan < 85)
    Console.WriteLine("Not : 4");
else
    Console.WriteLine("Not : 5");
Console.ReadKey();

// Parantezler olmasaydı: if'e sadece "Geçersiz puan!" satırı bağlı kalırdı, "Tekrar
// girin." puan koşuluna bakılmaksızın HER durumda çalışırdı (ck0150'de gördüğümüz kural).
