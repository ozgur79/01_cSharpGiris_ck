// BU KOD NE YAPAR?
// Bu kod, ekranda sayaç gösterir ve her adımda bekleme süresini kısaltır. Bekleme 1000 ms'de
// başlar, her turda sayaç kadar azalır, 40 ms'nin altına inmez; sayaç giderek hızlanır.

// ck0630 — Giderek hızlanan sayaç
// NASIL: Dosyanın en üstüne `using System.Threading;` ekle. Sonra aşağıdakini
//        Main() içine yapıştır.
// Ne öğreneceğiz: ck0625'teki bekleme süresi (sleep) sabitti. Burada her turda
//                  azaltılıyor — sayaç arttıkça bekleme kısalıyor, sayaç hızlanıyor.
//                  Bu döngü kendiliğinden bitmez, elle durdurulmalı (VS'in kırmızı
//                  Durdur butonu).

// --- KAVRAM ---
int sleep = 1000;
for (int i = 0; i >= 0; i++)
{
    Console.Clear();
    Console.Write(i);
    Thread.Sleep(sleep);
    if (sleep > 40)
        sleep = sleep - i;
    else
        sleep = 40;
}

// --- SEN YAP ---
// sleep - i yerine sleep - (i * 2) yaparsan sayaç ne kadar daha hızlı yavaşlar/hızlanır?
