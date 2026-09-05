// ck0140 — İlk karar yapısı: if / else
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: if ile bir koşulu sınamak — koşul doğruysa (true) if'in altındaki satır,
//                  yanlışsa (false) else'in altındaki satır çalışır. == ile eşitlik
//                  kontrolü yapılır (= ile karıştırma, = değer atar, == karşılaştırır).
//                  string karşılaştırması büyük/küçük harfe duyarlıdır.

// --- KAVRAM ---
Console.Write("Şairimiz Mehmet Akif'in soyadı nedir?\nCevabınız: ");
string cevap = Console.ReadLine();
if (cevap == "Ersoy") // == : eşit mi? sorusu, karşılaştırma sonucu true ya da false olur
    Console.WriteLine("Doğru cevap.");
else
    Console.WriteLine("Yanlış cevap.");
Console.ReadKey();

// --- SEN YAP ---
// Programı iki kez çalıştır: bir kez doğru cevapla ("Ersoy"), bir kez aynı cevabı küçük
// harfle yazarak ("ersoy"). İkisinde de aynı sonucu mu alıyorsun? İki satırda açıkla.
