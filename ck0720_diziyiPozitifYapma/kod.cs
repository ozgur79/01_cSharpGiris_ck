// ck0720 — Diziyi pozitif yapma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Dizideki elemanları TEK TEK değiştirmek (mutasyon) — negatif olan
//                  her elemanı *= -1 ile pozitife çeviriyoruz, dizinin kendisi
//                  kalıcı olarak değişiyor.

// --- KAVRAM ---
int[] liste = { -16, 71, -18, -4, 10, 0 };
for (int i = 0; i < liste.Length; i++)
{
    if (liste[i] < 0)
        liste[i] *= -1;
}
for (int i = 0; i < liste.Length; i++)
    Console.Write("[ " + liste[i] + " ]  ");
Console.ReadKey();

// --- SEN YAP ---
// 0 sayısı da negatif mi, pozitif mi? Kod 0'ı nasıl ele alıyor, doğru mu?
