// ck0310 — Maaş kesinti hesaplama: çok dallı yüzde
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0300'deki yüzde formülünü (oran/100)*sayı, farklı aralıklarda farklı
//                  oranlarla else if zinciri içinde kullanmak — hangi aralığa düştüğüne
//                  göre kesinti oranı değişiyor.

// --- KAVRAM ---
double maas, netmaas;
Console.Write("Maaşınızı Girin: ");
maas = Convert.ToDouble(Console.ReadLine());

if (maas > 0 && maas <= 1000)
{
    netmaas = maas - (maas / 100) * 10; // %10 kesinti
}
else if (maas > 1000 && maas <= 3500)
{
    netmaas = maas - (maas / 100) * 15; // %15 kesinti
}
else
{
    netmaas = maas - (maas / 100) * 20; // %20 kesinti
}
Console.Write("Net maaşınız " + netmaas);
Console.ReadKey();

// --- SEN YAP ---
// 100, 2000 ve 5000 ile üç kez çalıştır — sırasıyla 90, 1700, 4000 çıkmalı. Her biri için
// hangi dalın çalıştığını ve hangi oranın uygulandığını söyle.
