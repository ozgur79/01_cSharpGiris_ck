// ck0495 — Aynı üçgen, tek döngü ve string biriktirme ile
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0490'daki üçgen iç içe iki döngüyle çizilmişti. Burada aynı görsel
//                  sonuca tek bir döngüyle ulaşılıyor — ck0485'teki biriktirme deseni, bu
//                  kez hiç sıfırlanmadan satırdan satıra devam ediyor.

// --- KAVRAM ---
string yildiz = "";
for (int i = 0; i < 5; i++)
{
    yildiz = yildiz + "*";
    Console.WriteLine(yildiz);
}
Console.ReadKey();

// --- SEN YAP ---
// ck0490'ı (iç içe for ile üçgen) ve bu dersi 10 satır üretecek şekilde ayarla, ikisinin
// çıktısını karşılaştır — aynı mı? Hangisi sence daha kolay okunuyor?
// Sonra son satırda eklenen yıldızı + yap (ipucu: i==4 iken yildiz'a + ekle, önceki satırlar
// zaten yazdırılmış olacak).
