// ck0190 — Geçerli puan kontrolü: || (mantıksal VEYA)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: || iki koşuldan EN AZ BİRİ doğruysa true döner. "puan < 0 VEYA
//                  puan > 100" tek bir if satırında, iki ayrı if yazmadan kontrol edilir.

// --- KAVRAM ---
int puan;
Console.Write("Puanınızı girin : ");
puan = Convert.ToInt32(Console.ReadLine());
if (puan < 0 || puan > 100) // en az biri doğruysa (geçersiz uçlardan biri yakalanırsa) çalışır
{
    Console.WriteLine("Geçersiz puan!");
    // burada birden fazla satır olacağı için { } zorunlu (ck0150'den hatırla)
}
else if (puan < 25)
    Console.WriteLine("Not : 0");
else if (puan < 50)
    Console.WriteLine("Not : 1");
else if (puan < 60)
    Console.WriteLine("Not : 2");
else if (puan < 70)
    Console.WriteLine("Not : 3");
else if (puan < 85)
    Console.WriteLine("Not : 4");
else
    Console.WriteLine("Not : 5");
Console.ReadKey();

// --- SEN YAP ---
// puan=-1, puan=101, puan=50 ile üç kez çalıştır. Sonra { } içindeki yorum satırının
// yerine gerçek bir Console.WriteLine("Tekrar girin."); satırı ekle — parantezler
// olmasaydı bu yeni satır ne zaman çalışırdı?
