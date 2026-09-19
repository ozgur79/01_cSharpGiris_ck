// ck0900 — Şifre kontrolü: girilen ile önceden belirlenmiş şifreyi karşılaştırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// NOT: Bu ders de gerçek klavye ister, ck headless ortamda test edemedi — sadece
//       derleme doğrulandı, Özgür'ün VS'te elle denemesi gerekir.
// Ne öğreneceğiz: ck0895'teki maskelemeye bir char[] dizisi ekliyoruz — her tuş
//                  diziye kaydediliyor, Enter'a basılınca dizi bir string'e
//                  dönüştürülüp sabit bir şifreyle karşılaştırılıyor.

// --- KAVRAM ---
string dogruSifre = "12345";
char[] tuslar = new char[10];
int say = 0;
Console.Write("Şifre girin: ");
ConsoleKeyInfo tus;
do
{
    tus = Console.ReadKey(true);
    if (tus.Key == ConsoleKey.Enter)
        break;
    tuslar[say] = tus.KeyChar;
    Console.Write("*");
    say++;
} while (true);

string girilenSifre = "";
for (int i = 0; i < say; i++)
    girilenSifre += tuslar[i];

Console.WriteLine();
if (girilenSifre == dogruSifre)
    Console.WriteLine("Şifre doğru");
else
    Console.WriteLine("Şifre yanlış");
Console.ReadKey();

// --- SEN YAP ---
// 10 karakterden fazla tuşa basarsan ne olur (ipucu: tuslar dizisi kaç elemanlık)?
