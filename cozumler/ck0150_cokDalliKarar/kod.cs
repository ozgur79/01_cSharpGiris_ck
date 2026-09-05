// ck0150 SEN YAP çözümü
int s1, s2;
Console.Write("1. sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());

if (s1 > s2)
{
    Console.WriteLine(s1 + " sayısı " + s2 + " sayısından büyük.");
    Console.ReadKey(); // süslü parantezin İÇİNE taşındı
}
else if (s1 < s2)
{
    Console.WriteLine(s2 + " sayısı " + s1 + " sayısından büyük.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Sayılar birbirine eşit.");
    Console.ReadKey();
}

// Gözlem: ReadKey her bloğun içine ayrı ayrı taşınınca üç kez yazmak gerekti (kod uzadı),
// ama davranış aynı kaldı -- hangi dal çalışırsa o dalın kendi ReadKey'i çalışıyor.
// Dışarıda tek satırken zaten her durumda çalışıyordu, bu yüzden dışarıda bırakmak
// daha kısa ve daha doğru bir tercih.
