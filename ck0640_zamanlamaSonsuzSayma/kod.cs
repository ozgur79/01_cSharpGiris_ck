// BU KOD NE YAPAR?
// Bu kod, sonsuz döngüde 1'den başlayarak sayar. Sayıları yan yana yazar ve her sayıdan
// sonra 200 ms bekler; program kendiliğinden bitmez.

// ck0640 — Sonsuza kadar sayma
// NASIL: Dosyanın en üstüne `using System.Threading;` ekle. Sonra aşağıdakini
//        Main() içine yapıştır.
// Ne öğreneceğiz: En basit sonsuz sayaç — Console.Clear() bile yok, sayılar yan
//                  yana birikerek yazılıyor. ck0625'teki "tek sayı göster" ile
//                  ck0635'teki "ileri-geri" arasında en sade hâl.

// --- KAVRAM ---
int a = 0;
for (; ; )
{
    a++;
    Console.Write(a + " ");
    Thread.Sleep(200);
}

// --- SEN YAP ---
// Saniyede 5 sayı yazacak şekilde Thread.Sleep değerini ayarla (ipucu: 1000ms / 5 = 200ms,
// zaten öyle — bunun yerine saniyede 2 sayı yazacak şekilde değiştir).
