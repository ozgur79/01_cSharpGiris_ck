// ck0510 — Boşlukla sağa hizalanmış üçgen
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0490'daki artan üçgeni sütun sayısıyla hizalıyorduk. Burada aynı
//                  üçgeni ck0485'teki string biriktirme tekniğiyle çiziyoruz — bu kez
//                  iki ayrı biriktirici (bosluk, yildiz) aynı satırda art arda kullanılıyor.

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
    Console.WriteLine(yildiz);
    yildiz = "";
}
Console.ReadKey();

// --- SEN YAP ---
// j döngüsünü j=-1 yerine j=0'dan başlat, k=0 satırında kaç yıldız basıldığını gözlemle.
// Neden farklı çıktı, kendi cümlenle yaz (yorum satırı olarak koda ekleyebilirsin).
