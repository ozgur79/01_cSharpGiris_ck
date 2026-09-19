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
| 55 | ck0500_carpimTablosuIcIce | Çarpım tablosu (iç içe for) | yayında |
| 56 | ck0505_usluSayiDongu | Üslü sayı hesaplama (döngü ile) | yayında |
| 57 | ck0510_bosluklaHizalanmisUcgen | Boşlukla sağa hizalanmış üçgen | yayında |
| 58 | ck0515_simetrikPiramit | Simetrik piramit | yayında |
| 59 | ck0520_acilanIkizUcgen | Açılan ikiz üçgen | yayında |
| 60 | ck0525_baklavaDeseni | Baklava (elmas) deseni | yayında |
| 61 | ck0530_randomaGiris | Random ile rastgele sayı üretme | yayında |
| 62 | ck0535_whileGiris | while döngüsüne giriş | yayında |
| 63 | ck0540_doWhileGiris | do-while döngüsüne giriş | yayında |
| 64 | ck0545_whileKiraSabit | while ile kira hesabı (sabit değerler) | yayında |
| 65 | ck0550_whileKiraKlavyeden | while ile kira hesabı (klavyeden) | yayında |
| 66 | ck0555_doWhileBiriktirici | do-while ile biriktirici | yayında |
| 67 | ck0560_doWhileCiftSayiFiltre | do-while + if: çift sayı süzgeci | yayında |
| 68 | ck0565_doWhileFarkliSentinel | do-while: farklı bir çıkış değeri | yayında |
| 69 | ck0570_doWhileLogin | do-while ile giriş doğrulama | yayında |
| 70 | ck0575_doWhileRandomTahmin | do-while + Random: sayı tahmin oyunu | yayında |
| 71 | ck0580_whileTekrarOyna | while ile "tekrar oyna" döngüsü | yayında |
| 72 | ck0585_switchGiris | switch'e giriş | yayında |
| 73 | ck0590_switchHesapMakinesiChar | switch ile hesap makinesi (char) | yayında |
| 74 | ck0595_switchHesapMakinesiString | switch ile hesap makinesi (string) | yayında |
| 75 | ck0600_doWhileSwitchSayininOkunusu | do-while + switch: sayının okunuşu | yayında |
| 76 | ck0605_forSonsuzRandomTahmin | for(;;) + break ile sınırsız hakla tahmin | yayında |
| 77 | ck0610_besRastgeleSayi | Döngüde N adet rastgele sayı | yayında |
| 78 | ck0615_farkliArdisikSayi | Ardışık aynı sayıyı engelleme | yayında |
| 79 | ck0620_randomAralikKlavyeden | Random aralığını klavyeden alma | yayında |
| 80 | ck0625_zamanlamaGiris | Thread.Sleep ile zamanlanmış sayaç | yayında |
| 81 | ck0630_zamanlamaHizlanan | Giderek hızlanan sayaç | yayında |
| 82 | ck0635_zamanlamaIleriGeri | Sonsuz döngüde ileri-geri sayma | yayında |
| 83 | ck0640_zamanlamaSonsuzSayma | En sade sonsuz sayaç | yayında |
| 84 | ck0645_zamanlamaBaklava | Baklava deseni + zamanlama | yayında |
| 85 | ck0650_renkGiris | ConsoleColor'a giriş (cast) | yayında |
| 86 | ck0655_renkVeIf | ConsoleColor + if: tek/çift renk | yayında |
| 87 | ck0660_diziyeGiris | Diziye giriş | yayında |
| 88 | ck0665_diziLiteralBaslatma | Dizi literal ile başlatma | yayında |
| 89 | ck0670_diziForIleGirOku | for ile diziye giriş/okuma | yayında |
| 90 | ck0675_diziFarkliSayiZorlama | Farklı sayı zorlama (kusurlu, karşılaştırma) | yayında |
| 91 | ck0680_diziFarkliSayiDuzeltilmis | Farklı sayı zorlama (düzeltilmiş) | yayında |
| 92 | ck0685_diziRandomBasit | Dizi + Random: basit | yayında |
| 93 | ck0690_diziRandomKosulluFiltre | Dizi + Random: koşullu filtre | yayında |
| 94 | ck0695_diziRandomBiriktirme | Dizi + Random: biriktirme | yayında |
| 95 | ck0700_dinamikBoyutluDizi | Dinamik boyutlu dizi | yayında |
| 96 | ck0705_diziArama | Dizide arama | yayında |
| 97 | ck0710_diziSilme | Dizide silme (Array.Clear) | yayında |
| 98 | ck0715_diziyeElemanEkleme | Diziye eleman ekleme (Array.Resize) | yayında |
| 99 | ck0720_diziyiPozitifYapma | Diziyi pozitif yapma | yayında |
| 100 | ck0725_diziTersleme | Diziyi tersleme (Array.Reverse) | yayında |
| 101 | ck0730_rastgeleDiziSiralama | Rastgele diziyi sıralama | yayında |
| 102 | ck0735_ikiDiziRastgeleVeri | İki diziden eşleşen rastgele veri | yayında |
| 103 | ck0740_stringSesliHarfSayma | String'te sesli harf sayma | yayında |
| 104 | ck0745_stringTerstenYazdirma | String'i tersten yazdırma | yayında |
| 105 | ck0750_diziFonksiyonKoprusu | Dizi + fonksiyon köprüsü | yayında |
| 106 | ck0755_fonksiyonStringTersCevirme | Fonksiyon ile string ters çevirme | yayında |
| 107 | ck0760_fonksiyonaGiris | Fonksiyona giriş (parametre, return) | yayında |
| 108 | ck0765_fonksiyonDonguToplam | Fonksiyon + döngü: 1'den N'e toplam | yayında |
| 109 | ck0770_fonksiyonCarpmaPekistirme | Fonksiyon pekiştirme: çarpma | yayında |
| 110 | ck0775_fonksiyonFaktoriyel | Fonksiyon ile faktöriyel | yayında |
| 111 | ck0780_fonksiyonUsluSayi | Fonksiyon ile üslü sayı | yayında |
| 112 | ck0785_hazirMetotKarekok | Hazır kütüphane metodu (Math.Sqrt) | yayında |
| 113 | ck0790_castPekistirme | Cast operatörü pekiştirmesi | yayında |

Bu tablo her yeni ders eklendiğinde güncellenir. "Sırada ne var" diye buraya bakın.
