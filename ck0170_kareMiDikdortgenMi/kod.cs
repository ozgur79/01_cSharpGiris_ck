// ck0170 — Kare mi dikdörtgen mi: if/else ile sayısal eşitlik
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: if/else'i == ile sayısal eşitlik sınamada kullanmak (ck0110'daki
//                  dörtgen örneğine karar yapısı eklemek).

// --- KAVRAM ---
int en, boy;
Console.Write("Dörtgenin enini girin : ");
en = Convert.ToInt32(Console.ReadLine());
Console.Write("Dörtgenin boyunu girin : ");
boy = Convert.ToInt32(Console.ReadLine());
if (en == boy)
    Console.WriteLine("Karedir");
else
    Console.WriteLine("Dikdörtgendir");
Console.ReadKey();

// --- SEN YAP ---
// en=7, boy=7 ve en=7, boy=9 ile iki kez çalıştır. Sonra ck0110'daki çevre/alan
// hesabını bu koda ekleyip, hem şekli hem çevre/alanı aynı anda yazdırmayı dene.

// --- MERAK KÖŞESİ ---
// namespace <proje adın> nedir?
// Kodlarını isim altında gruplayan bir "klasör" gibidir; proje adını verdiğinde VS bu
// ismi otomatik üretir. Bu derste yeni bir Console projesi açtıysan namespace'in önceki
// derslerdeki projeden farklı bir isim taşıdığını fark ettin mi? Her yeni proje kendi
// namespace'ini alır. İleride tam açacağız.
