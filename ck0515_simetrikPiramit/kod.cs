// ck0515 — Simetrik piramit
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0510'daki tek taraflı üçgene, aynı satırda ikinci bir yıldız bloğu
//                  daha ekleyip simetrik (piramit görünümlü) hale getiriyoruz.

// --- KAVRAM ---
string bosluk = "", yildiz = "";
for (int k = 0; k < 5; k++)
{
    for (int i = 0; i < 5 - k; i++)
    {
        bosluk = bosluk + " ";
    }
    Console.Write(bosluk);
    bosluk = "";

    for (int j = -1; j < k; j++)
    {
        yildiz = yildiz + "*";
    }
    Console.Write(yildiz);
    yildiz = "";
    for (int t = 0; t < k; t++)
    {
        yildiz = yildiz + "*";
    }
    Console.WriteLine(yildiz);
    yildiz = "";
}
Console.ReadKey();

// --- SEN YAP ---
// (İleri seviye, opsiyonel) Yıldızları iki ayrı for yerine TEK bir for döngüsüyle
// yazdırmayı dene — ipucu: tek döngü içinde toplam yıldız sayısı (2k+1) kadar dönüp
// hepsini aynı yildiz değişkeninde biriktirebilirsin, iki ayrı bloğa gerek kalmaz.
