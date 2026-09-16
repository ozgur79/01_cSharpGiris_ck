// ck0430 — Aralıkta çift sayılar + geçersiz girişte tekrar sorma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: "geçersizse tekrar sor" deseni — dış for(;;) kullanıcı geçerli bir
//                  aralık (s1 < s2) girene kadar sormaya devam eder; geçerli girişte içteki
//                  for ile aralıktaki çift sayılar yazdırılıp break ile dış döngüden çıkılır.

// --- KAVRAM ---
int s1, s2;
for (; ; )
{
    Console.Write("1. sayıyı girin: ");
    s1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. sayıyı girin: ");
    s2 = Convert.ToInt32(Console.ReadLine());
    if (s1 >= s2)
        Console.WriteLine("İlk sayı küçük olmalıdır! Tekrar giriniz");
    else
    {
        for (int i = s1; i < s2; i++)
            if (i % 2 == 0)
                Console.Write(i + " ");
        break;
    }
}
Console.ReadKey();

// --- SEN YAP ---
// Önce s1=5, s2=3 gir (geçersiz, tekrar soracak), sonra s1=2, s2=10 gir — "2 4 6 8"
// çıkmalı. 10 neden listede yok?
