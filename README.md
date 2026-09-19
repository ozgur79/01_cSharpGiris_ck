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
| 16 | ck0160_ehliyetKontrolu | if/else ile sayısal karşılaştırma (pekiştirme) | yayında |
| 17 | ck0170_kareMiDikdortgenMi | if/else ile sayısal eşitlik (pekiştirme) | yayında |
| 18 | ck0180_notaCevirme | else if zincirinde sıralı aralık kontrolü | yayında |
| 19 | ck0190_gecerliPuanKontrolu | Mantıksal VEYA (`\|\|`) | yayında |
| 20 | ck0200_cinsiyetOkuma | Convert.ToChar ile tek karakter (char) okuma | yayında |
| 21 | ck0210_askerlikKontrolu | Mantıksal VE (`&&`), `\|\|` ile `&&` bir arada | yayında |
| 22 | ck0220_dortIslemFormatli | Dört işlemi formatlı yazdırma (pekiştirme) | yayında |
| 23 | ck0230_notOperatoru | Mantıksal DEĞİL (`!`) operatörü | yayında |
| 24 | ck0240_icIceIf | İç içe if (nested if) | yayında |
| 25 | ck0250_loginTekIf | Aynı mantığın `&&` ile tek if'e indirgenmesi | yayında |
| 26 | ck0260_forDonguGiris | `for` döngüsüne giriş, `break` ile erken çıkış | yayında |
| 27 | ck0270_tekCiftKontrolu | `%` (mod) ile tek/çift kontrolü | yayında |
| 28 | ck0280_gecerliMenu | Doğrulama sarmalayıcısı deseni (geçerlilik önce) | yayında |
| 29 | ck0290_sembolIleSecim | `char` ile sembol tabanlı seçim (hesap makinesi) | yayında |
| 30 | ck0300_kdvHesaplama | KDV hesaplama — yüzde formülü | yayında |
| 31 | ck0310_maasKesinti | Maaş kesinti hesaplama — çok dallı yüzde | yayında |
| 32 | ck0320_birlerBasamagi | Birler basamağını bulma (`sayi % 10`) | yayında |
| 33 | ck0330_onBeseBolunebilirlik | 15'e bölünebilirlik (`%`, `&&`, sonsuz döngü) | yayında |
| 34 | ck0340_bankaHesabi | Banka hesabı — kalıcı durum, sonsuz döngü | yayında |
| 35 | ck0350_toplamBiriktirme | Toplam biriktirme (`+=`), kırılgan girdi | yayında |
| 36 | ck0360_tryParseIleSaglam | `int.TryParse` ile hatalı girdiye dayanıklı hâle getirme | yayında |
| 37 | ck0370_forAdimliArtis | `for` ile adım/artış belirleme (`i += 2`) | yayında |
| 38 | ck0380_tekrarGirdiDeseni | Döngü içinde tekrar girdi isteme deseni | yayında |
| 39 | ck0390_faktoriyel | Çarpımsal biriktirici (faktöriyel), `i++` | yayında |
| 40 | ck0400_periyodikBicimlendirme | Döngüde periyodik biçimlendirme (`%5`) | yayında |
| 41 | ck0410_dinamikAralik | Kullanıcı sınırlarıyla dinamik aralık yazdırma | yayında |
| 42 | ck0420_birdenXeToplam | 1'den X'e toplam — biriktirici | yayında |
| 43 | ck0430_aralikCiftSayilar | Aralıkta çift sayılar, retry-on-invalid deseni | yayında |
| 44 | ck0440_aralikTekSayilar | Aralıkta tek sayılar — ck0430 varyantı | yayında |
| 45 | ck0450_qIleCikis | Pozitif/negatif/sıfır analizi, `"q"` ile çıkış | yayında |
| 46 | ck0460_tekSatirYildiz | Tek döngüyle yan yana yıldız (Console.Write) | yayında |
| 47 | ck0465_sabitDikdortgen | İç içe for ile dikdörtgen çizme | yayında |
| 48 | ck0470_bosSatirDeseni | Desende bir satırı boş bırakma | yayında |
| 49 | ck0475_dikdortgenBosluk | Dikdörtgende bir sütunu boş bırakma | yayında |
| 50 | ck0480_dortgendeDelik | Dikdörtgende tek bir yeri boş bırakma | yayında |
| 51 | ck0485_metindeYildizBiriktirme | Metinde yıldız biriktirme | yayında |
| 52 | ck0490_artanUcgenFor | Döngü sınırıyla artan üçgen | yayında |
| 53 | ck0495_artanUcgenString | Yıldız ekleyerek artan üçgen | yayında |
| 54 | ck0499_azalanUcgen | Azalan yıldız üçgeni | yayında |

Bu tablo her yeni ders eklendiğinde güncellenir. "Sırada ne var" diye buraya bakın.
