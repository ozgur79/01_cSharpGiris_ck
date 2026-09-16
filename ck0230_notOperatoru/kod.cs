// ck0230 — ! (NOT/DEĞİL) operatörü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ! operatörü bir koşulun (true/false) sonucunu tam tersine çevirir —
//                  koşulun kendisini değiştirmez, sadece sonucunu ters çevirir. true iken
//                  false, false iken true olur.

// --- KAVRAM ---
int a = 5, b = 3;
Console.WriteLine(a > b);      // sıradan karşılaştırma: 5 > 3 -> True
Console.WriteLine(!(a > b));   // ! ile ters çevrildi: True idi, False oldu
Console.WriteLine(a < b);      // 5 < 3 -> False
Console.WriteLine(!(a < b));   // ! ile ters çevrildi: False idi, True oldu
Console.ReadKey();

// --- SEN YAP ---
// int x = 3, y = 4; ekle. Aşağıdaki satırları KAVRAM'daki gibi birer birer ekle —
// her satırı yazmadan önce True mu False mu çıkacağını tahmin et, sonra çalıştırıp
// doğrula (a, b hâlâ 5 ve 3):
// Console.WriteLine((a > b) || (b > 4));
// Console.WriteLine(!(a > b) || (b == 5));
// Console.WriteLine((x * y) > (x * x));
// Console.WriteLine(!(a > b) && (b > 4));
// Console.WriteLine(a % b == 1);
// Console.WriteLine(x * (y % 2));
