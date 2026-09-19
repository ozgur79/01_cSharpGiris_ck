// ck0625 — Zamanlama'ya giriş: Thread.Sleep
// NASIL: Dosyanın en üstündeki using satırlarının altına `using System.Threading;`
//        ekle (Thread.Sleep bu kütüphanede). Sonra aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Thread.Sleep(ms) programı belirtilen milisaniye kadar durdurur.
//                  Console.Clear() ile ekranı temizleyip her turda tek bir sayı
//                  göstererek bir "sayaç" efekti oluşturuyoruz.

// --- KAVRAM ---
for (int i = 0; i <= 100; i++)
{
    Console.Clear();
    Console.Write(i);
    Thread.Sleep(200);
}
Console.ReadKey();

// --- SEN YAP ---
// Thread.Sleep(200) değerini 500 ve sonra 50 yaparak çalıştır, hızın nasıl
// değiştiğini gözlemle.
