// ck0885 — ConsoleKeyInfo'ya giriş: tek tuş okuma
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// NOT: Bu ders (ve ck0890/0895/0900) Console.ReadKey ile TEK TUŞ okur — Enter'a
//       basmana GEREK YOKTUR, bir tuşa basar basmaz program devam eder. ck bu
//       dersleri kendi ortamında (dotnet CLI, girdi yönlendirilmiş) test edemez
//       çünkü tek tuş okuma gerçek bir konsol ister; Özgür'ün VS'te elle
//       denemesi gerekir.
// Ne öğreneceğiz: Console.ReadLine() ENTER'a basılana kadar bekler. Console.ReadKey()
//                  ise TEK bir tuşa basılır basılmaz döner — hangi tuşa basıldığını
//                  ConsoleKeyInfo nesnesiyle öğrenebiliriz.

// --- KAVRAM ---
Console.Write("Bir tuşa basınız! ");
ConsoleKeyInfo tusBilgisi = Console.ReadKey(true);
Console.WriteLine(tusBilgisi.Key.ToString() + " tuşuna bastınız!");
Console.ReadKey();

// --- SEN YAP ---
// Console.ReadKey(true) yerine Console.ReadKey(false) (ya da parametresiz
// Console.ReadKey()) dene — basılan tuş ekranda görünüyor mu, görünmüyor mu?
// Fark nereden geliyor (ipucu: true "intercept" — tuşu YAKALA ama gösterme demek)?
