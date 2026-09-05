// ck0010 — İlk program: ekrana yazı yazdırma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Console.Write ve Console.WriteLine ile ekrana yazı basmak,
//                  aralarındaki fark (WriteLine'dan sonra imleç alt satıra geçer, Write'tan sonra geçmez)
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak, hepsini ileride tek tek açacağız.

// --- KAVRAM ---
Console.Write("Merhaba Dünya :)"); // ekrana yazdırır, imleç aynı satırda kalır
Console.ReadKey(); // bir tuşa basılana kadar programı bekletir

Console.WriteLine("Merhaba Dünya :)"); // ekrana yazdırır, imleci bir alt satıra götürür
Console.ReadKey();

// --- SEN YAP ---
// Yukarıdaki dört satırı örnek alarak, kendi adını "Merhaba, ben <adın>" şeklinde
// Console.WriteLine ile ekrana yazdıran bir satır ekle. Programı çalıştırıp kontrol et.
