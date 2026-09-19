// ck0815 — for(;;) + break ile çift sayı toplama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0560'ta aynı fikri (çift topla, tek girilince dur) do-while'ın
//                  kendi şartıyla yapmıştık. Burada aynı davranışı ck0605'teki
//                  for(;;) + break ile kuruyoruz — aynı sonuç, farklı döngü aracı.

// --- KAVRAM ---
int sayi, toplam = 0;
for (; ; )
{
    Console.Write("Toplama için ÇİFT, çıkış için TEK sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 1)
        break;
    toplam = sayi + toplam;
    Console.WriteLine("Şimdiye kadar girilen ÇİFT sayıların toplamı: " + toplam);
}
Console.ReadKey();

// --- SEN YAP ---
// Bu kodu ck0560'daki do-while versiyonuyla karşılaştır — hangisi daha kısa,
// hangisi senin için daha okunaklı? İkisi de aynı işi mi yapıyor?
