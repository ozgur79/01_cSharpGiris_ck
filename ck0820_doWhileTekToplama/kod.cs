// ck0820 — do-while ile tek sayı toplama, 0'da çıkış
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0815'in aynası — bu kez SADECE tek sayılar toplanıyor, çift
//                  girilirse uyarı veriliyor (ama döngü devam ediyor), 0 girilince
//                  (0 çift sayıldığı için uyarıyla birlikte) çıkılıyor.

// --- KAVRAM ---
int sayi, toplam = 0;
do
{
    Console.Write("Tek sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 1)
    {
        toplam = toplam + sayi;
        Console.WriteLine("Şimdiye kadarki tek sayıların toplamı: " + toplam);
    }
    else
        Console.WriteLine("Dikkat, TEK sayı girilecek: ");
} while (sayi != 0);
Console.WriteLine("Programdan çıkıldı.");
Console.ReadKey();

// --- SEN YAP ---
// 0 girildiğinde önce "Dikkat, TEK sayı girilecek" uyarısı çıkıyor, sonra program
// yine de çıkıyor. Bu tutarsız mı? Nasıl düzeltirdin (ipucu: 0'ı özel bir durum
// olarak ele almayı dene)?
