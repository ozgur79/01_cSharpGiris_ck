// BU KOD NE YAPAR?
// Bu kod, işlem seçimini (1-4: toplama, çıkarma, çarpma, bölme) char olarak ve iki sayıyı
// okur. switch ile işlemi yapar ve "sayi1 işlem sayi2 = sonuç" yazar; 1-4 dışında uyarı verir.

// ck0590 — switch ile hesap makinesi (char seçim)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: switch'i gerçek bir hesap makinesi menüsüne uyguluyoruz — kullanıcının
//                  girdiği tek karakter, dört işlemden birini seçiyor.

// --- KAVRAM ---
double sayi1, sayi2, sonuc;
char secim;

Console.WriteLine("1 - Toplama");
Console.WriteLine("2 - Çıkarma");
Console.WriteLine("3 - Çarpma");
Console.WriteLine("4 - Bölme");
Console.Write("İşlem seçin (1-4): ");
secim = Convert.ToChar(Console.ReadLine());
Console.Write("1. sayıyı girin: ");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
sayi2 = Convert.ToDouble(Console.ReadLine());

switch (secim)
{
    case '1':
        sonuc = sayi1 + sayi2;
        Console.WriteLine(sayi1 + " + " + sayi2 + " = " + sonuc);
        break;
    case '2':
        sonuc = sayi1 - sayi2;
        Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
        break;
    case '3':
        sonuc = sayi1 * sayi2;
        Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
        break;
    case '4':
        sonuc = sayi1 / sayi2;
        Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
        break;
    default:
        Console.WriteLine("1-4 arası bir sayı girin");
        break;
}
Console.ReadKey();

// --- SEN YAP ---
// sayi2 olarak 0 girildiğinde bölme (case '4') ne çıktı verir, dene ve gözlemle
// (ipucu: double'da 0'a bölme int'teki gibi hata vermez).
