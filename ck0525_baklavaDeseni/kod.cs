// ck0525 — Baklava (elmas) deseni
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0520'deki açılan ikiz üçgenin simetriği eklenip iki blok art arda
//                  çalıştırılıyor — önce açılıyor, sonra kapanıyor; birlikte baklava
//                  (elmas) şekli oluşuyor.

// --- KAVRAM ---
int d = 9;
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
bos = "";
for (int a = 1; a < 6; a++)
{
    for (int b = 0; b < a; b++)
        yildiz = yildiz + "*";
    Console.Write(yildiz);

    for (int c = d; c > 0; c--)
        bos = bos + " ";
    Console.Write(bos);
    Console.WriteLine(yildiz);
    yildiz = "";
    bos = "";
    d -= 2;
}
Console.ReadKey();

// --- SEN YAP ---
// d'nin başlangıç değerini (9) 7 yap ama azalma miktarını (-=2) değiştirme — şekil
// bozulur mu, neden? Sonra d'yi eski haline getirip azalma miktarını -=1 yap, farkı gözlemle.
