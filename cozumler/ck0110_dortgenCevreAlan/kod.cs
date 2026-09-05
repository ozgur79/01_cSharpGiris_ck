// ck0110 SEN YAP çözümü
int en, boy, cevre, alan;
Console.Write("Dörtgenin enini girin: ");
en = Convert.ToInt32(Console.ReadLine());
Console.Write("Dörtgenin boyunu girin: ");
boy = Convert.ToInt32(Console.ReadLine());

// 2. adım: parantezsiz hâli — çarpma önce işlendiği için sonuç değişir
cevre = en + boy * 2;
alan = en * boy;
Console.WriteLine("Dörtgenin çevresi (parantezsiz, YANLIŞ): " + cevre);
Console.WriteLine("Dörtgenin alanı: " + alan);
Console.ReadKey();

// Açıklama: parantez olmadan önce "boy * 2" hesaplanır, sonra "en" eklenir.
// Örneğin en=3, boy=4 için doğru çevre (3+4)*2=14 iken, parantezsiz 3+4*2=11 çıkar.
