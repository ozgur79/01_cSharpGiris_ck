// ck0220 — Dört işlem: formatlı sonuç yazdırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: pekiştirme — +, -, *, / işlemlerini aynı programda art arda kullanmak;
//                  sonucu "x+y=sonuç" biçiminde tek satırda yazdırmak için sayıyla yazıyı
//                  aynı WriteLine içinde birleştirmek (ck0080'de gördüğümüz + birleştirmesi).

// --- KAVRAM ---
int x = 10;
int y = 5;
Console.WriteLine(x + "+" + y + "=" + (x + y));
Console.WriteLine(x + "-" + y + "=" + (x - y));
Console.WriteLine(x + "*" + y + "=" + (x * y));
Console.WriteLine(x + "/" + y + "=" + (x / y));
Console.ReadKey();

// --- SEN YAP ---
// x = 9, y = 2 yap, dört satırı tekrar çalıştır. "/" satırının sonucunu önce tahmin et
// (4.5 mi, 4 mü?), sonra çalıştırıp doğrula — ck0060'ta gördüğümüz int bölmesi kuralını
// hatırla.

// --- MERAK KÖŞESİ ---
// class Program hâlâ aynı yerde duruyor (3. ve son tur)
// ck0040'ta bu kutunun namespace'in içinde bir kutu olduğunu, ck0110'da adının hep
// "Program" kaldığını söylemiştik. Bugünkü programda dört ayrı WriteLine satırı var ama
// hepsi yine aynı tek kutunun içinde — kutu kaç satır yazarsan yaz büyümüyor, sen sadece
// içini dolduruyorsun. Bu kutuyu ünite 07'de gerçekten açacağız, o zamana kadar burada bir
// daha durmayacağız.
