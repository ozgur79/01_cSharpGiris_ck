# C# Giriş — Lise Müfredatı

Lise (9-12. sınıf) Bilişim Teknolojileri/meslek dersi için sıfırdan C# müfredatı.
Bu repo **Console (terminal)** derslerini içerir: değişken, operatör, karar yapısı, döngü,
dizi, fonksiyon.

> Form/pencere uygulamaları (buton, metin kutusu, liste, zamanlayıcı) ve nesne tabanlı
> programlama ayrı bir repoda: **02_cSharpForm_ck**. Ön koşulu bu müfredatı bitirmiş
> olmak — oradaki derslerde buranın bilgisi bilindiği varsayılır.

## Nasıl kullanılır

1. Visual Studio'da **File > New Project** ile kendi Console projenizi açın.
2. İlgili ders klasöründeki kod dosyasını açın.
3. İçeriği kopyalayıp kendi projenizde `Main()` içine yapıştırın.
4. `degerlendirme.md` dosyasındaki soruları çalışın — dersi gösterdikten sonra sorulacak.

Bu repoda proje dosyası (`.sln`/`.csproj`/`.Designer.cs`) yoktur — sadece yapıştıracağınız
kod parçaları. Proje her zaman sizin kendi Visual Studio'nuzda oluşturulur.

## Ders sırası

| # | proje adı | konu | durum |
|---|-----------|------|-------|
| 1 | ck0010_merhabaDunya | Ekrana yazı yazdırma (Console.Write / Console.WriteLine) | yayında |
| 2 | ck0020_adinizNedir | Klavyeden yazı (string) okuma | yayında |
| 3 | ck0030_ikiSayiToplam | Klavyeden sayı okuma, toplama (int, Convert.ToInt32) | yayında |
| 4 | ck0040_sayininIkiKati | Çarpma operatörü (*) | yayında |
| 5 | ck0050_sayininKaresi | Sayının karesini alma (pekiştirme) | yayında |
| 6 | ck0060_tamSayiBolmesi | int bölmesinde küsurat kaybı, float/double | yayında |
| 7 | ck0070_metotVeSinif | "metot" ve "sınıf" terimleri (Console örneğiyle) | yayında |
| 8 | ck0080_stringToplamaTuzagi | string + string birleştirir, toplamaz (pekiştirme) | yayında |
| 9 | ck0090_tekKarakterOkuma | Console.Read() ile tek karakter okuma, ASCII kod döndürmesi | yayında |
| 10 | ck0100_veriTipleriTanisma | byte, bool, char tipleriyle tanışma | yayında |
| 11 | ck0110_dortgenCevreAlan | Parantez ile işlem sırası (çevre/alan hesabı) | yayında |
| 12 | ck0120_ucSayiOrtalama | Üç sayının ortalaması (pekiştirme) | yayında |
| 13 | ck0130_kareVeKup | Kare ve küp alma | yayında |
| 14 | ck0140_ilkKararYapisi | Karar yapısına giriş (if/else) | yayında |
| 15 | ck0150_cokDalliKarar | Çok dallı karar (if/else if/else) | yayında |
| 16 | ck0160_ehliyetKontrolu | if/else ile sayısal karşılaştırma (pekiştirme) | taslak |
| 17 | ck0170_kareMiDikdortgenMi | if/else ile sayısal eşitlik (pekiştirme) | taslak |
| 18 | ck0180_notaCevirme | else if zincirinde sıralı aralık kontrolü | taslak |
| 19 | ck0190_gecerliPuanKontrolu | Mantıksal VEYA (`\|\|`) | taslak |
| 20 | ck0200_cinsiyetOkuma | Convert.ToChar ile tek karakter (char) okuma | taslak |
| 21 | ck0210_askerlikKontrolu | Mantıksal VE (`&&`), `\|\|` ile `&&` bir arada | taslak |

| 46 | ck0460_tekSatirYildiz | Tek döngüyle yan yana yıldız (Console.Write) | taslak |
| 47 | ck0465_sabitDikdortgen | İç içe for ile dikdörtgen çizme | taslak |
| 48 | ck0470_bosSatirDeseni | Desende bir satırı boş bırakma | taslak |
| 49 | ck0475_dikdortgenBosluk | Dikdörtgende bir sütunu boş bırakma | taslak |
| 50 | ck0480_dortgendeDelik | Dikdörtgende tek bir yeri boş bırakma | taslak |
| 51 | ck0485_metindeYildizBiriktirme | Metinde yıldız biriktirme | taslak |
| 52 | ck0490_artanUcgenFor | Döngü sınırıyla artan üçgen | taslak |
| 53 | ck0495_artanUcgenString | Yıldız ekleyerek artan üçgen | taslak |
| 54 | ck0499_azalanUcgen | Azalan yıldız üçgeni | taslak |

Bu tablo her yeni ders eklendiğinde güncellenir. "Sırada ne var" diye buraya bakın.
