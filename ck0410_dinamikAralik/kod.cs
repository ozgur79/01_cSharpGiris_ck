// ck0410 — İki sayı arasını yazdırma: dinamik aralık
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: for döngüsünün başlangıç ve bitiş değerleri sabit sayı olmak zorunda
//                  değil — kullanıcıdan okunan s1 ve s2 değişkenleri de kullanılabilir,
//                  aralık her çalıştırmada değişebilir.

// --- KAVRAM ---
int s1, s2;
Console.Write("1.Sayı: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.Sayı: ");
s2 = Convert.ToInt32(Console.ReadLine());
for (int i = s1; i <= s2; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();

// --- SEN YAP ---
// s1=3, s2=6 ile çalıştır (3,4,5,6 çıkmalı). Sonra s1=6, s2=3 gibi ters gir — ne olur,
// hiç sayı yazdırılır mı? Neden?
