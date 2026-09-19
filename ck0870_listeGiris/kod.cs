// ck0870 — List<int>'e giriş: ck0865'in sırasını .Reverse() ile düzeltme
// NASIL: Yeni bir Console Application aç. Dosyanın en üstüne `using
//        System.Collections.Generic;` ekle (List için gerekli). Sonra
//        aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: List<int>, dizi (int[]) gibi ama BOYUTU SONRADAN DEĞİŞEBİLEN bir
//                  liste — `.Add()` ile eleman eklenir, `.Count` eleman sayısını
//                  verir, `.Reverse()` sırayı ters çevirir. ck0865'in ters-sıra
//                  sorununu burada çözüyoruz.

// --- KAVRAM ---
Console.Write("10 tabanındaki sayıyı girin: ");
int taban10 = Convert.ToInt32(Console.ReadLine());

List<int> rakamlar = new List<int>();
for (; ; )
{
    if (taban10 == 0)
        break;
    int kalan = taban10 % 2;
    taban10 = taban10 / 2;
    if (kalan == 1)
        rakamlar.Add(1);
    else
        rakamlar.Add(0);
}

Console.WriteLine("Listenin uzunluğu: " + rakamlar.Count);
rakamlar.Reverse();
foreach (int rakam in rakamlar)
    Console.Write(rakam);
Console.ReadKey();

// --- SEN YAP ---
// .Reverse()'in TAM OLARAK ne yaptığını, iç içe bir for döngüsüyle kendin
// yazmayı dene (ipucu: ck0730'daki swap tekniğini hatırla — bu ders bir SONRAKİ
// derste çözülecek, şimdilik dene).
