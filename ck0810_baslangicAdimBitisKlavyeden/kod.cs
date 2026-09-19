// ck0810 — Başlangıç, adım ve bitiş hepsi klavyeden
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0370'teki adımlı artış (i += adim) ile ck0410'daki dinamik
//                  aralığı (kullanıcıdan sınır alma) birleştiriyoruz — üç değer de
//                  (başlangıç, adım, bitiş) artık klavyeden.

// --- KAVRAM ---
Console.Write("Başlangıç değeri: ");
int baslangic = Convert.ToInt32(Console.ReadLine());
Console.Write("Kaçar kaçar artacak: ");
int adim = Convert.ToInt32(Console.ReadLine());
Console.Write("Hangi sayıya kadar: ");
int bitis = Convert.ToInt32(Console.ReadLine());

for (int i = baslangic; i <= bitis; i += adim)
    Console.Write(i + " ");
Console.ReadKey();

// --- SEN YAP ---
// adim olarak 0 girersen ne olur, dene (dikkat: sonsuz döngü olabilir, gerekirse
// VS'in kırmızı Durdur butonunu kullan).
