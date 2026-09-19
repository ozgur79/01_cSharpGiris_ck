// ck0520 — Açılan ikiz üçgen
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0510'daki tek üçgen burada aynı satırda iki kez yazdırılıyor
//                  (aynı yildiz değeri), aradaki boşluk her satırda büyüyor — üçgenler
//                  birbirinden uzaklaşıyormuş gibi bir görüntü oluşuyor.

// --- KAVRAM ---
string yildiz = "";
string bos = " ";
for (int a = 0; a < 5; a++)
{
    for (int b = 0; b < 5 - a; b++)
        yildiz = yildiz + "*";
    Console.Write(yildiz);
    Console.Write(bos);
    bos = bos + "  ";
    Console.WriteLine(yildiz);
    yildiz = "";
}
Console.ReadKey();

// --- SEN YAP ---
// bos'un başlangıç değerini " " yerine "" yap, ne değişti gözlemle.
// Sonra bos'un her turdaki artışını "  " (2 boşluk) yerine "   " (3 boşluk) yap.
