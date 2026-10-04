// BU KOD NE YAPAR?
// Bu kod, x = 10 ve y = 4 ile bölme yapar. Önce int olarak (2), sonra (float) dönüşümünü
// farklı yerlere koyarak dört şekilde böler (örn. (float)x / y = 2.5) ve her sonucu yazar.

// ck0790 — Cast operatörü pekiştirmesi: (Tip)değer nereye konur?
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0650'de (ConsoleColor)renk ile cast'i görmüştük. Burada ck0060'a
//                  (int bölmesi küsurat kaybı) geri dönüp cast'in TAM OLARAK NEREYE
//                  konduğunun sonucu değiştirdiğini karşılaştırmalı görüyoruz —
//                  arsiv/12'nin ve bu bloğun kapanış dersi.

// --- KAVRAM ---
int x = 10;
int y = 4;

int sonuc = x / y;
Console.WriteLine(x + "/" + y + " = " + sonuc);

float floatSonuc = (float)x / y;
Console.WriteLine("(float)x / y = " + floatSonuc);

floatSonuc = x / (float)y;
Console.WriteLine("x / (float)y = " + floatSonuc);

floatSonuc = (float)x / (float)y;
Console.WriteLine("(float)x / (float)y = " + floatSonuc);

floatSonuc = (float)(x / y);
Console.WriteLine("(float)(x / y) = " + floatSonuc);
Console.ReadKey();

// --- SEN YAP ---
// Son satırın (float)(x / y) neden hâlâ 2 verdiğini (2,5 değil) kendi cümlenle
// yaz — ipucu: parantezlerin içi hangi sırayla işleniyor?
