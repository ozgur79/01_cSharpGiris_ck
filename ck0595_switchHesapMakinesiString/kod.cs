// ck0595 — switch ile hesap makinesi (string seçim)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0590'daki aynı hesap makinesi burada char yerine string ile —
//                  case değerleri artık "1","2","3","4" (tırnaklı, string sabiti).

// --- KAVRAM ---
double sayi1, sayi2, sonuc = 0;
string secim;
Console.Write("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\nSeçiminiz (1-4): ");
secim = Console.ReadLine();
Console.Write("1. sayıyı girin: ");
sayi1 = double.Parse(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
sayi2 = double.Parse(Console.ReadLine());
switch (secim)
{
    case "1": sonuc = sayi1 + sayi2; break;
    case "2": sonuc = sayi1 - sayi2; break;
    case "3": sonuc = sayi1 * sayi2; break;
    case "4": sonuc = sayi1 / sayi2; break;
    default:
        Console.WriteLine("Hatalı seçim yapıldı!");
        break;
}
Console.Write("Sonuç = " + sonuc);
Console.ReadKey();

// --- SEN YAP ---
// ck0590 ile bu dersi karşılaştır: secim değişkeninin tipi ve case değerlerinin
// yazımı dışında hangi satırlar birebir aynı kaldı?
