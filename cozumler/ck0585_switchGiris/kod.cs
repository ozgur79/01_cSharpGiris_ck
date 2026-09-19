Console.Write("Kaçıncı ayın adını öğrenmek istiyorsun: ");
byte ay = Convert.ToByte(Console.ReadLine());
switch (ay)
{
    case 1: Console.Write(ay + ". Ayın adı: OCAK"); break;
    case 2: Console.Write(ay + ". Ayın adı: ŞUBAT"); break;
    case 3: Console.Write(ay + ". Ayın adı: MART"); break;
    case 4: Console.Write(ay + ". Ayın adı: NİSAN"); break;
    case 5: Console.Write(ay + ". Ayın adı: MAYIS"); break;
    default: Console.Write("1-5 arası sayı girin"); break;
}
Console.ReadKey();
