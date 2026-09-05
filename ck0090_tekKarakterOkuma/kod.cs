// ck0090 — Tek karakter okuma ve ASCII kodu
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Console.Read() ile klavyeden tek karakter okumak — ReadLine'ın aksine
//                  bu metot int (tam sayı) döndürür, dönen sayı okunan karakterin ASCII
//                  kod karşılığıdır.

// --- KAVRAM ---
int x;
Console.Write("Bir karakter giriniz: ");
x = Console.Read(); // Read(), ReadLine'ın aksine bir karakter okur ve int döndürür
Console.WriteLine("Girilen karakterin ASCII kod karşılığı : " + x);
Console.ReadKey();

// --- SEN YAP ---
// Programı iki kez, farklı karakterlerle çalıştır (örneğin küçük "a" ve büyük "A").
// Çıkan ASCII kodlarını karşılaştır, hangisinin sayı olarak daha büyük olduğunu gözlemle.

// --- MERAK KÖŞESİ ---
// namespace ismi neden her yeni projede değişiyor?
// ck0030'da namespace'in kodlarını bir isim altında toplayan "klasör" gibi olduğunu
// söylemiştik. Bu yüzden her yeni Console Application açtığında namespace de değişir —
// VS, projene verdiğin ismi kendiliğinden namespace yapar. Ayrıntısını ünite 07'de
// (nesne tabanlı programlama) açacağız.
