// ck0360 — Aynı program, int.TryParse ile hatalı girdiye dayanıklı hâle getirme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: int.TryParse bir yazıyı sayıya çevirmeyi "dener" — başarılıysa true
//                  döner ve sonucu `out sayi` ile değişkene yazar; başarısızsa (ör. "abc")
//                  program çökmez, false döner ve biz hata mesajı gösterip devam ederiz.
//                  ck0350'nin `Convert.ToInt32` ile çöken hâlinin sağlamlaştırılmışı.

// --- KAVRAM ---
int sayi, toplam = 0;
for (; ; )
{
    Console.Write("Bir sayı girin (çıkmak için sıfır girin): ");
    string girilenSayi = Console.ReadLine();

    if (girilenSayi == "0")
        break;

    if (int.TryParse(girilenSayi, out sayi))
    {
        toplam += sayi;
    }
    else
    {
        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
    }
}
Console.WriteLine("Girilen sayıların toplamı: " + toplam);
Console.ReadKey();

// --- SEN YAP ---
// 5, "abc", 3, 0 sırasıyla gir — "abc" için hata mesajı görünmeli ama program çökmemeli,
// devam etmeli. Toplam kaç çıkar? ck0350'de aynı "abc" girseydin ne olurdu?
