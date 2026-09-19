// ck0890 — Tuşa basınca yazı ilerlet (yazma pratiği efekti)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// NOT: Bu ders de tek tuş okur, Özgür'ün VS'te elle denemesi gerekir (ck0885'teki not).
// Ne öğreneceğiz: ck0740'taki string indeksleme (metin[i]) ile ck0885'teki
//                  ReadKey'i birleştiriyoruz — HANGİ tuşa basıldığı önemli değil,
//                  her basışta hazır metnin bir sonraki harfi ekrana çıkıyor.

// --- KAVRAM ---
string metin = "C# öğreniyorum, her tuşa bastıkça bir harf ilerliyorum!";
int i = 0;
while (i < metin.Length)
{
    Console.ReadKey(true);
    Console.Write(metin[i]);
    i++;
}
Console.ReadKey();

// --- SEN YAP ---
// metin değişkenini kendi seçtiğin bir cümleyle değiştir, programı VS'te
// çalıştırıp gerçekten tuşlara basarak dene.
