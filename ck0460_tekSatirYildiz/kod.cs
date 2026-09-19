// ck0460 — Tek döngüyle yan yana yıldız
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Şimdiye kadar Console.WriteLine ile her yazdırmadan sonra alt satıra
//                  geçtik. Console.Write satır atlamaz — aynı döngüde tekrar tekrar
//                  çağrılırsa çıktı yan yana, tek satırda birikir.

// --- KAVRAM ---
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.ReadKey();

// --- SEN YAP ---
// 10 yerine 20 yap, kaç yıldız çıkıyor say. Sonra Console.Write yerine Console.WriteLine
// koy, ikisi arasındaki farkı gözlemle.
// son yıldız'ı + ya çevir