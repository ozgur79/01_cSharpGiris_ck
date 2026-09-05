// ck0130 SEN YAP çözümü
double s1, s2, kare, kup;
Console.Write("Karesini alacağın sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Küpünü alacağın sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());
kare = s1 * s1;
kup = s2 * s2 * s2;
Console.WriteLine("Sayının karesi: " + kare);
Console.WriteLine("Sayının küpü: " + kup);
Console.ReadKey();

// 2 girilirse: kare 4, küp 8 (fark 4).
// 5 girilirse: kare 25, küp 125 (fark 100) -- küp çok daha hızlı büyüyor.
