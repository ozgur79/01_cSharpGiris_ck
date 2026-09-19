// SEN YAP çözümü: iç sınırı da kullanıcıdan al
int n, m;
Console.Write("Çarpım tablosu kaça kadar olsun? ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Kaça kadar çarpılsın? ");
m = Convert.ToInt32(Console.ReadLine());

for (int j = 1; j <= n; j++)
{
    for (int x = 1; x <= m; x++)
        Console.WriteLine(j + " x " + x + " = " + (j * x));
    Console.WriteLine("--------------------");
}
Console.ReadKey();
// n=3, m=5: dış döngü 3 kez, iç döngü her turda 5 kez -> 15 satır + 3 ayraç
