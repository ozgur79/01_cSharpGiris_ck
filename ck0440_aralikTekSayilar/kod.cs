// ck0440 — Aralıkta tek sayılar: başlangıcı ayarlama tekniği
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0430'un varyantı — bu kez tek sayılar isteniyor. s1 çiftse `s1++` ile
//                  bir sonraki (tek) sayıya kaydırılıyor, sonra döngü 2'şer 2'şer ilerliyor
//                  (ck0370'teki i+=2 gibi) — böylece hep tek sayılarda kalınıyor.

// --- KAVRAM ---
int s1, s2;
Console.Write("1.Sayı: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.Sayı: ");
s2 = Convert.ToInt32(Console.ReadLine());
if (s1 % 2 == 0) // s1'in ikiye bölümünden kalan sıfır ise: s1 çift ise
    s1++;
for (int i = s1; i <= s2; i += 2)
{
    Console.WriteLine(i);
}
Console.ReadKey();

// --- SEN YAP ---
// s1=2 (çift), s2=10 ile çalıştır — s1++ ile 3'e kayar, 3 5 7 9 çıkar. Sonra s1=3 (tek
// baştan) ile aynı s2 ile dene — sonuç değişir mi? Neden?
