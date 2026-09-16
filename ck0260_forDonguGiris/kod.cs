// ck0260 — for döngüsüne giriş: sınırlı deneme hakkı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: for döngüsü — parantez içinde üç parça var: başlangıç (bir kere
//                  çalışır), koşul (her turun başında sınanır, yanlışsa döngü biter),
//                  adım (her turun sonunda çalışır). Burada "hak" 3'ten başlayıp her
//                  turda 1 azalıyor, 0'a inince döngü kendiliğinden bitiyor. break ise
//                  koşul hâlâ doğruyken bile döngüyü hemen durdurur — doğru giriş
//                  yapıldığında kalan hakları harcamaya gerek yok.

// --- KAVRAM ---
string kadi, sifre;
for (int hak = 3; hak > 0; hak--) // başlangıç: hak=3 | koşul: hak>0 | adım: hak bir azalır
{
    Console.Write("Kullanıcı adını girin: ");
    kadi = Console.ReadLine();
    Console.Write("Şifreyi girin: ");
    sifre = Console.ReadLine();

    if (kadi == "ogrenci" && sifre == "kalfa123")
    {
        Console.WriteLine("Hoşgeldiniz " + kadi);
        break; // doğru girişte döngüden hemen çık
    }
    else
    {
        Console.WriteLine("Hatalı Giriş");
        Console.WriteLine(hak - 1 + " hakkınız kaldı");
        if (hak == 1)
            Console.WriteLine("Hesap bloke oldu!");
    }
}
Console.ReadKey();

// --- SEN YAP ---
// İki ayrı çalıştırma yap: 1) üç kez de yanlış gir, "Hesap bloke oldu!" mesajını gör.
// 2) bir kez yanlış, ikinci seferde doğru (ogrenci/kalfa123) gir — kaç kez soru sorulduğunu
// say, break'in döngüyü ne zaman durdurduğunu gözlemle.
