// ck0805 — Tuzak: for'dan sonraki fazladan noktalı virgül (10B'nin gerçekten takıldığı kod)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bu ders BİLEREK hatalı — for(...) satırının hemen sonunda gizli bir
//                  `;` var. Girinti (indentation) seni kandırıyor: WriteLine'ın döngünün
//                  İÇİNDE olduğunu sanırsın ama değil, tek başına duran bir satırdır.

// --- KAVRAM (bilerek hatalı, çalıştırıp gözlemle) ---
int sayac;
for (sayac = 7; sayac <= 10; sayac = sayac + 1);
    Console.WriteLine(sayac);
Console.ReadKey();

// --- SEN YAP ---
// Çıktı 7, 8, 9, 10 mu, yoksa tek bir sayı mı? Fazladan noktalı virgülü sil, tekrar
// çalıştır, farkı gözlemle. Neden bir tek noktalı virgül bu kadar şey değiştiriyor?
