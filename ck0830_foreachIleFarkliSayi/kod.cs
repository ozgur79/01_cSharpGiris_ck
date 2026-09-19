// ck0830 — foreach'e giriş: dizide arama yapmanın kısa yolu
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: foreach, bir dizinin İÇİNDEKİ HER ELEMANI, indis (i) kullanmadan
//                  tek tek gezmeni sağlar. Burada yeni üretilen rastgele sayının
//                  dizide zaten olup olmadığını foreach ile kontrol ediyoruz.

// --- KAVRAM ---
int sayac = 0, kontrol = 0;
Random rastgele = new Random();
int[] sayilar = new int[3];
while (sayac < 3)
{
    int tutulansayi = rastgele.Next(0, 4);
    foreach (int gecici in sayilar)
    {
        if (tutulansayi == gecici)
        {
            kontrol = 1;
            break;
        }
    }
    if (kontrol == 0)
    {
        sayilar[sayac] = tutulansayi;
        sayac++;
    }
    kontrol = 0;
}
for (int i = 0; i < 3; i++)
    Console.Write(sayilar[i] + " ");
Console.ReadKey();

// --- SEN YAP ---
// Programı birkaç kez çalıştır, çıktıları not al — hiç 0 gördün mü? ck0615'teki
// -1 dersini hatırla: sayilar dizisinin BAŞLANGIÇ değeri (new int[3] ile) kaçtır,
// bu neden 0'ı "zaten var" gibi gösterebilir?
