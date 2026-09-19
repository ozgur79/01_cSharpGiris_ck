// ck0650 — ConsoleColor'a giriş: (Tip)değer dönüşümü (cast)
// NASIL: Dosyanın en üstüne `using System.Threading;` ekle. Sonra aşağıdakini
//        Main() içine yapıştır.
// Ne öğreneceğiz: ck0060'ta "(double)x" ipucunu vermiştik ama açıklamamıştık —
//                  (Tip)değer yazımı bir değeri başka bir tipe DÖNÜŞTÜRÜR (cast).
//                  Burada bir tam sayıyı ConsoleColor'a çevirip arka plan rengi
//                  olarak kullanıyoruz; her sayı (0-15) farklı bir renge karşılık gelir.

// --- KAVRAM ---
int renk = 0;
for (int i = 0; i < 8; i++)
{
    Console.BackgroundColor = (ConsoleColor)renk;
    Console.Clear();
    Thread.Sleep(400);
    renk++;
}
Console.ReadKey();

// --- SEN YAP ---
// renk 8'i geçince (8'den 15'e kadar) devam etsin diye döngü sınırını 16 yap,
// tüm renkleri sırayla gör.
