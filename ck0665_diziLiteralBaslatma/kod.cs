// BU KOD NE YAPAR?
// Bu kod, 5 isimlik bir string dizisini (ali, veli, selim, ayşe, cansu) doğrudan değerlerle
// oluşturur. Dizinin ilk (indis 0) ve son (indis 4) elemanını ekrana yazar.

// ck0665 — Dizi literal ile başlatma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0660'ta diziyi boş açıp elle dolduruyorduk. Burada elemanları
//                  { } içinde art arda yazarak diziyi doğrudan doldurulmuş oluşturuyoruz.

// --- KAVRAM ---
string[] isimler = { "ali", "veli", "selim", "ayşe", "cansu" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[4]);
Console.ReadKey();

// --- SEN YAP ---
// isimler[5]'i yazdırmayı dene, ne çıkıyor gözlemle (ipucu: dizide 5 eleman var,
// en büyük geçerli indis 4'tür).
