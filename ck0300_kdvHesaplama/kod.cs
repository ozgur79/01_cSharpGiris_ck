// ck0300 — KDV hesaplama: yüzde formülü
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: bir sayının yüzdesini bulma formülü — (oran / 100) * sayı; sonucu asıl
//                  değere ekleyerek tek satırda "yüzde artışlı" yeni bir değer hesaplamak.

// --- KAVRAM ---
double gelisFiyati, kdvOrani, satisFiyati;
Console.Write("Ürünün geliş fiyatını girin : ");
gelisFiyati = Convert.ToDouble(Console.ReadLine());
Console.Write("Ürüne uygulanacak kdv oranını girin : ");
kdvOrani = Convert.ToDouble(Console.ReadLine());

satisFiyati = gelisFiyati + (kdvOrani / 100) * gelisFiyati;
Console.Write("Ürünün satış fiyatı : " + satisFiyati);
Console.ReadKey();

// --- SEN YAP ---
// gelisFiyati=100, kdvOrani=20 ile çalıştır, sonucu elle de hesapla (100 + %20'si),
// programın verdiğiyle karşılaştır. Sonra kdvOrani=0 ile dene — satış fiyatı neden geliş
// fiyatıyla aynı çıkıyor?
