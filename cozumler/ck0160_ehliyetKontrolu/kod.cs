// ck0160 SEN YAP çözümü
int yas;
Console.Write("Yaşınızı girin : ");
yas = Convert.ToInt32(Console.ReadLine());

if (yas < 18)
    Console.WriteLine("Sütünü iç gel!");
else
    Console.WriteLine("Ehliyet alabilir");
Console.ReadKey();

// yas = 18 girilirse: "Ehliyet alabilir" yazar -- çünkü 18 < 18 yanlıştır (18, 18'den
// küçük değil), bu yüzden else çalışır.
