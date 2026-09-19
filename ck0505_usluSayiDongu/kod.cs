// ck0505 — Üslü sayı hesaplama (döngü ile)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0390'daki faktöriyeldeki çarpımsal biriktirici (sonuc = sonuc * i)
//                  tekniği burada farklı bir problemde kullanılıyor — taban kendisiyle
//                  kuvvet kadar çarpılıyor.

// --- KAVRAM ---
Console.Write("Üssü alınacak sayıyı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.Write("Kuvvetini girin: ");
int kuvvet = Convert.ToInt32(Console.ReadLine());

int sonuc = 1;
for (int i = 1; i <= kuvvet; i++)
{
    sonuc = sonuc * sayi;
}
Console.WriteLine("Sonuç = " + sonuc);
Console.ReadKey();

// --- SEN YAP ---
// kuvvet=0 girip çalıştır, sonucun neden 1 çıktığını döngünün çalışıp çalışmadığına
// bakarak açıkla. Sonra taban=0, kuvvet=3 dene.
