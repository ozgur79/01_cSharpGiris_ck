// ck0270 — % (mod) ile tek/çift kontrolü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: % işareti bir bölmenin kalanını verir. Bir sayının 2'ye bölümünden
//                  kalan 0 ise sayı çifttir, 0 değilse (1 ya da -1 olabilir) tektir.

// --- KAVRAM ---
int sayi, kalan;
Console.Write("Analiz edilecek sayıyı girin : ");
sayi = Convert.ToInt32(Console.ReadLine());
kalan = sayi % 2;
Console.WriteLine(sayi + " sayısının 2'ye bölümünden kalan " + kalan + " dır.");
if (kalan == 0)
{
    Console.WriteLine(sayi + " sayısı çifttir");
}
else
{
    Console.WriteLine(sayi + " sayısı tektir");
}
Console.ReadKey();

// --- SEN YAP ---
// 7, 8 ve -3 ile üç kez çalıştır. -3 için kalanı tahmin et (0 mı, 1 mi, -1 mi?), sonra
// çalıştırıp doğrula.

// --- MERAK KÖŞESİ ---
// Console.ReadKey(); emekli oluyor (3. ve son tur)
// ck0060'ta bu satırın olmasa pencerenin anında kapanacağını, ck0130'da iki sonuç
// hesaplanan bir derste neden en sonda durması gerektiğini söylemiştik. Bugünkü programda
// if/else'in sadece bir dalı çalışıyor (ya "çifttir" ya "tektir") ama hangi dal çalışırsa
// çalışsın en sonunda hep bu satıra geliniyor — hangi yoldan gidersen git, pencereyi açık
// tutan hep aynı satır. Bu kutuyu ünite 07'de gerçekten açacağız; beş iskelet kutusu da
// (using, namespace, class Program, static Main, Console.ReadKey) artık emekli — ünite
// 07'ye kadar burada bir daha durmayacaklar.
