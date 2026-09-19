// ck0745 — String'i tersten yazdırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0740'ta string'i indisle okumayı görmüştük. Burada aynı fikri
//                  ck0499'daki azalan sayaçla birleştirip son harften başa doğru
//                  yazdırıyoruz.

// --- KAVRAM ---
Console.Write("Bir metin girin: ");
string metin = Console.ReadLine();
for (int i = metin.Length - 1; i >= 0; i--)
    Console.Write(metin[i]);
Console.ReadKey();

// --- SEN YAP ---
// metin.Length - 1 yerine metin.Length yazsan ne olur, dene (ipucu: en büyük
// geçerli indis Length-1'dir, Length'in kendisi değil).
