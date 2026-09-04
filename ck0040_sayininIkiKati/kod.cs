// ck0040 — Sayının iki katı
// NASIL: VS2013'te yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
//
// Şimdilik kara kutu (ck0010'da tanıtıldı, henüz açılmadı):
//   VS2013 iskeleti (using'ler + namespace + class Program + Main) + Console.ReadKey();

// --- KAVRAM ---
int x, y; // int tipinde iki değişken tanımlandı
Console.Write("Sayıyı giriniz : ");
x = Convert.ToInt32(Console.ReadLine()); // klavyeden okunan yazı, sayıya (int) dönüştürüldü
y = 2 * x; // x sayısının iki katı hesaplanıp y'ye atandı
Console.WriteLine("Klavyeden girilen sayının iki katı : " + y);
Console.ReadKey();

// --- SEN YAP ---
// Aynı programı, iki katı yerine üç katını hesaplayacak şekilde değiştir.
