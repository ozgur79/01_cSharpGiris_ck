// ck0895 — Şifre maskeleme: her tuş yerine yıldız göster
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// NOT: ck0885'teki gibi bu ders de gerçek klavye ister, ck headless ortamda test
//       edemedi — sadece derleme doğrulandı, Özgür'ün VS'te elle denemesi gerekir.
// Ne öğreneceğiz: ck0885'teki tek tuş okumayı gerçek bir işte kullanıyoruz —
//                  kullanıcı yazarken ekranda harfler değil "*" görünüyor, Enter'a
//                  basınca girilen gerçek metin bir string'de toplanmış oluyor.

// --- KAVRAM ---
string sifre = "";
ConsoleKeyInfo tus;
do
{
    tus = Console.ReadKey(true);
    if (tus.Key == ConsoleKey.Enter)
        break;
    if (tus.Key != ConsoleKey.Backspace)
    {
        sifre += tus.KeyChar;
        Console.Write("*");
    }
} while (true);

Console.WriteLine();
Console.WriteLine("Girilen şifre: " + sifre);
Console.ReadKey();

// --- SEN YAP ---
// Backspace'e basınca ekranda yıldız SİLİNMİYOR (sadece yeni karakter eklenmiyor).
// Gerçek bir silme (hem ekrandan hem sifre değişkeninden) nasıl yapılırdı, fikrini
// yaz (kod yazman gerekmiyor, düşünmen yeterli).
