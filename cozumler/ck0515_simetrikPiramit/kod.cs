// Tek döngü çözümü: satırdaki toplam yıldız sayısı hep 2k+1 (k=0->1, k=1->3, k=2->5...)
string bosluk = "", yildiz = "";
for (int k = 0; k < 5; k++)
{
    for (int i = 0; i < 5 - k; i++)
        bosluk = bosluk + " ";
    Console.Write(bosluk);
    bosluk = "";
    for (int t = 0; t < 2 * k + 1; t++)
        yildiz = yildiz + "*";
    Console.WriteLine(yildiz);
    yildiz = "";
}
Console.ReadKey();
