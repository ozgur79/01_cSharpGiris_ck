// ck0110 — Dörtgenin çevresi ve alanı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: parantez kullanarak işlem sırasını değiştirmek — (en + boy) * 2 önce
//                  toplamı, sonra çarpmayı yapar; parantez olmasaydı çarpma önce çalışırdı
//                  çünkü C#'ta * her zaman +'dan önce işlenir.

// --- KAVRAM ---
int en, boy, cevre, alan;
Console.Write("Dörtgenin enini girin: ");
en = Convert.ToInt32(Console.ReadLine());
Console.Write("Dörtgenin boyunu girin: ");
boy = Convert.ToInt32(Console.ReadLine());
cevre = (en + boy) * 2; // parantez: önce toplama, sonra çarpma
alan = en * boy;
Console.WriteLine("Dörtgenin çevresi: " + cevre);
Console.WriteLine("Dörtgenin alanı: " + alan);
Console.ReadKey();

// --- SEN YAP ---
// 1) Programı gerçek bir dikdörtgenin (defterin, sıranın) ölçüleriyle çalıştır.
// 2) Sonra `cevre` satırındaki parantezleri kaldırıp (en + boy * 2 yap) tekrar çalıştır.
//    Sonuç neden değişti? İki satırlık bir açıklama yaz.

// --- MERAK KÖŞESİ ---
// class Program neden hep aynı isimde kalıyor, namespace her seferinde değişiyor?
// ck0040'ta class Program'ın, namespace'in içindeki bir kutu olduğunu ve yazdığın her
// satırın (en-boy hesaplayan bu kod dahil) onun içinde durduğunu söylemiştik. VS her yeni
// Console Application'a otomatik "Program" adını veriyor, sen değiştirmedikçe hep aynı
// kalıyor — namespace ise senin verdiğin proje adına göre değişir. Ayrıntı: ünite 07.
