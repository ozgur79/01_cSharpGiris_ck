// ck0370 — for ile adım belirleme: i += 2
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: for döngüsünün adım kısmı her zaman 1 artırmak (i++) zorunda değil —
//                  `i += 2` (i = i + 2 ile aynı anlama gelir) yazılırsa sayaç 2'şer 2'şer
//                  artar.

// --- KAVRAM ---
int i;
for (i = 2; i <= 20; i += 2) // i+=2 ile i=i+2 ifadeleri aynı anlama gelir
    Console.WriteLine(i);
Console.ReadKey();

// --- SEN YAP ---
// Adımı `i += 2` yerine `i += 5` yap, `i = 1` başlat, `i <= 30` koşulunu kullan — hangi
// sayılar yazdırılır? Önce tahmin et, sonra çalıştırıp doğrula.
