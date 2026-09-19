// ck0670 — Dizi + for: 3 elemanı gir, sonra oku
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0660'ta her elemanı ayrı ayrı elle yazmıştık. Burada bir for
//                  döngüsüyle hem doldurma hem okuma işini tek satırlık bir kalıpla
//                  yapıyoruz — döngü sayacı (i) aynı zamanda dizinin indisi oluyor.

// --- KAVRAM ---
int[] sayilar = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + sayilar[i]);
Console.ReadKey();

// --- SEN YAP ---
// Dizi boyutunu 3 yerine 6 yap, iki for döngüsündeki 3'leri de 6 ile değiştir.
