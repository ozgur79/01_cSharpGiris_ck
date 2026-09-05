// ck0150 — Çok dallı karar: if / else if / else
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: else if ile birden fazla koşulu sırayla sınamak; >, < ile sayısal
//                  karşılaştırma; if/else if/else altında birden fazla satır çalışacaksa
//                  o satırların süslü parantez { } içine alınması gerektiği.

// --- KAVRAM ---
int s1, s2;
Console.Write("1. sayıyı girin: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
s2 = Convert.ToInt32(Console.ReadLine());

if (s1 > s2)
{
    Console.WriteLine(s1 + " sayısı " + s2 + " sayısından büyük.");
}
else if (s1 < s2) // if yanlışsa buraya bakılır, bu da yanlışsa else çalışır
{
    Console.WriteLine(s2 + " sayısı " + s1 + " sayısından büyük.");
}
else
{
    Console.WriteLine("Sayılar birbirine eşit.");
}
Console.ReadKey();

// --- SEN YAP ---
// Programı üç kez çalıştır: birinci sayı büyükken, ikinci sayı büyükken, sayılar eşitken.
// Üç farklı çıktıyı da gördükten sonra, `Console.ReadKey();` satırını süslü parantezlerin
// İÇİNE taşırsan ne değişir? Dene ve gözlemle.
