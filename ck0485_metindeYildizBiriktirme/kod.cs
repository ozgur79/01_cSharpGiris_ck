// ck0485 — Bir satırın yıldızlarını metinde biriktirme
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Şimdiye kadar yıldızları doğrudan ekrana yazdırıyorduk (Console.Write).
//                  Burada önce bir string değişkende (yildiz) biriktiriyoruz, satır bitince
//                  tek seferde yazdırıp değişkeni sıfırlıyoruz — ck0080'deki + ile string
//                  birleştirmenin döngü içinde tekrarlanan hâli.

// --- KAVRAM ---
string yildiz = "";
for (int k = 0; k < 10; k++)
{
    for (int i = 0; i < 10; i++)
    {
        yildiz = yildiz + "*";
    }
    Console.Write(yildiz);
    Console.WriteLine();
    yildiz = "";
}
Console.ReadKey();

// --- SEN YAP ---
// yildiz = "" satırını sil (yorum satırı yap), ne olduğunu gözlemle — biriktirilen metin
// satırlar arasında neden büyüyor?
// Sonra her satırın son karakterini + yap (ipucu: iç döngüde i==9 iken yildiz'a + ekle).
