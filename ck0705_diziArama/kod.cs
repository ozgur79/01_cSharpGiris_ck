// ck0705 — Dizide arama
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Dizide belirli bir değeri arayıp hangi indiste olduğunu bulmak —
//                  bulunca break ile döngüden çıkıp, bulunamadıysa döngü BİTTİKTEN
//                  SONRA tek bir mesaj vermek (bool bayrak ile).

// --- KAVRAM ---
int[] dizi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.Write("İstenilen elemanı girin: ");
int aranan = Convert.ToInt32(Console.ReadLine());

bool bulundu = false;
for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] == aranan)
    {
        Console.WriteLine("Aradığınız eleman dizinin " + i + ". indisidir.");
        bulundu = true;
        break;
    }
}
if (!bulundu)
    Console.WriteLine("Aradığınız eleman bulunamadı.");
Console.ReadKey();

// --- SEN YAP ---
// break satırını kaldırırsan ne değişir? bulundu değişkeni hâlâ doğru çalışır mı?
