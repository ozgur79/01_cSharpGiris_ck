// ck0740 — String'te sesli harf sayma (char dizisi)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Bir string aslında karakterlerin dizisi gibi davranır (kelime[i]
//                  ile tek tek harfe erişilir). Burada bir char[] dizisiyle (sesli
//                  harfler) karşılaştırıp sayıyoruz — iki farklı dizi bir arada.

// --- KAVRAM ---
int sayac = 0;
Console.Write("Bir kelime girin: ");
string kelime = Console.ReadLine();
char[] sesli = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };

for (int i = 0; i < kelime.Length; i++)
{
    for (int k = 0; k < sesli.Length; k++)
    {
        if (kelime[i] == sesli[k])
            sayac++;
    }
}
Console.WriteLine("Kelimedeki ünlü harf sayısı: " + sayac);
Console.ReadKey();

// --- SEN YAP ---
// Büyük harfle yazılan bir kelime (ör. "MERHABA") dener misin? Sayaç doğru sayıyor
// mu? Neden (ipucu: 'a' ile 'A' aynı karakter midir)?
