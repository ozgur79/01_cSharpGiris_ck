// ck0700 — Dinamik boyutlu dizi
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Şimdiye kadar dizi boyutu (new int[3] gibi) kodun içinde sabitti.
//                  Burada boyutu kullanıcıdan alıp diziyi ONA GÖRE oluşturuyoruz —
//                  ayrıca sayilar.Length ile dizinin boyutunu diziden okuyoruz.

// --- KAVRAM ---
int boyut;
Console.Write("Dizi boyutunu girin: ");
boyut = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[boyut];

for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write("Sayı girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < boyut; j++)
    Console.WriteLine(sayilar[j]);
Console.ReadKey();

// --- SEN YAP ---
// İkinci for döngüsündeki boyut yerine de sayilar.Length yaz — ikisi neden aynı
// sonucu verir?
