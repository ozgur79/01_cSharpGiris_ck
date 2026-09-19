# Müfredat

Ders listesi ve kara kutu takip tablosu. Her onaylanan derste bu dosya güncellenir.
Bu dosya şimdilik yalnızca Console (ünite 00-04) derslerini listeler. WinForms dersleri
(ünite 05-09) için üretim planı `winforms-plan.md`'de ders ders yazılı; WinForms
üretimi fiilen başlayınca satırlar bu dosyaya da (aynı ders listesi + kara kutu
tablosu formatında) girecek.

## Ders listesi

| ders | konu | tür | zincir (dil) | zincir (arayüz) | kaynak | durum |
|------|------|-----|---------------|-------------------|--------|-------|
| ck0010_merhabaDunya | Console.Write / Console.WriteLine, satır sonu farkı | Console | çıktı (giriş öncesi) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 1) | onaylandı |
| ck0020_adinizNedir | string değişken, Console.ReadLine ile klavyeden yazı okuma, + ile birleştirme | Console | değişken (string) + girdi | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 2) | onaylandı |
| ck0030_ikiSayiToplam | int değişken, Convert.ToInt32 ile sayıya çevirme, + ile sayısal toplama | Console | değişken (int) + operatör (+) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 3, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0040_sayininIkiKati | * ile çarpma | Console | operatör (*) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 4, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0050_sayininKaresi | bir sayıyı kendisiyle çarpma (kare alma) | Console | operatör (*) pekiştirme | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 5) | onaylandı |
| ck0060_tamSayiBolmesi | int bölmesinin küsuratı atması, float/double tipleri | Console | operatör (/) + veri tipi (float, double) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 6) | onaylandı |
| ck0070_metotVeSinif | "metot" ve "sınıf" terimleri, Console.WriteLine örneğiyle (IntelliSense) | Console | terim (metot, sınıf) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 7) | onaylandı |
| ck0080_stringToplamaTuzagi | string + string'in birleştirme yaptığı, sayısal toplama olmadığı | Console | operatör (+) string vs sayı, pekiştirme | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 8, kısım b) | onaylandı |
| ck0090_tekKarakterOkuma | Console.Read() ile tek karakter okuma, int (ASCII kod) döndürmesi | Console | metot çeşitliliği (Read vs ReadLine) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 9) | onaylandı |
| ck0100_veriTipleriTanisma | byte, bool, char tiplerinin tanıtımı (int/double/string recap ile bir arada) | Console | veri tipi çeşitliliği | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 10) | onaylandı |
| ck0110_dortgenCevreAlan | parantez ile işlem sırasını belirleme, aynı girdilerden birden fazla sonuç hesaplama | Console | operatör (parantez/öncelik) | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 11, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0120_ucSayiOrtalama | üç sayının ortalaması, parantez zorunluluğu + int bölmesi küsuratı pekiştirme | Console | operatör (parantez) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 12, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0130_kareVeKup | küp alma (3 katlı çarpma), aynı programda iki farklı hesap yapma | Console | operatör (*) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 13, `ToInt16`→`ToInt32` düzeltildi, giriş etiketleri netleştirildi) | onaylandı |
| ck0140_ilkKararYapisi | if/else ile karar yapısına giriş, == ile eşitlik karşılaştırması, string büyük/küçük harf duyarlılığı | Console | karar yapısı (if/else) — zincire yeni halka | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 14) | onaylandı |
| ck0150_cokDalliKarar | else if ile çok dallı karar, >,< sayısal karşılaştırma, çok satırlı blokta süslü parantez zorunluluğu | Console | karar yapısı (if/else if/else) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 15) | onaylandı |
| ck0160_ehliyetKontrolu | if/else ile sayısal karşılaştırma (<), ck0140'ın == yerine sayısal örneği | Console | karar yapısı (if/else) pekiştirme | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 16, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0170_kareMiDikdortgenMi | if/else ile sayısal eşitlik (==), ck0110'daki dörtgen örneğine karar yapısı eklenmesi | Console | karar yapısı (if/else) pekiştirme | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 17, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0180_notaCevirme | else if zincirinde sıralı aralık kontrolü (bir üstteki koşulun elenmiş olması) | Console | karar yapısı (else if zinciri) — zincire yeni halka | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 18, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0190_gecerliPuanKontrolu | `\|\|` (mantıksal VEYA) ile tek satırda iki koşul, süslü parantez zorunluluğu pekiştirme | Console | operatör (`\|\|`) — zincire yeni halka | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 19, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0200_cinsiyetOkuma | Convert.ToChar ile klavyeden tek karakter (char) okuma | Console | veri tipi (char) okuma — zincire yeni halka | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 20, kısım a) | onaylandı |
| ck0210_askerlikKontrolu | `&&` (mantıksal VE), aynı satırda `\|\|` ile `&&` birlikte, parantezin önceliği belirlediği | Console | operatör (`&&`) — zincire yeni halka | Console | arsiv/04cSharpÇekirdekKodlar.txt (madde 20, kısım b) | onaylandı |
| ck0220_dortIslemFormatli | Dört işlemi (`+ - * /`) aynı programda art arda, `"x+y=sonuç"` biçiminde formatlı yazdırma | Console | operatör (`+ - * /`) pekiştirme | Console | arsiv/05cSharpÇekirdekKodlar.txt (madde 2) | onaylandı |
| ck0230_notOperatoru | `!` (NOT/DEĞİL) operatörü — bir koşulun sonucunu tersine çevirme | Console | operatör (`!`) — zincire yeni halka | Console | arsiv/05cSharpÇekirdekKodlar.txt (madde 3, 10 ifadelik script'ten sadece `!` işlendi, gerisi SEN YAP'a taşındı) | onaylandı |
| ck0240_icIceIf | İç içe if (nested if) — dıştaki if false ise içteki hiç çalışmaz | Console | karar yapısı (iç içe if) — zincire yeni halka | Console | arsiv/05cSharpÇekirdekKodlar.txt (madde 4, kullanıcı adı/şifre gerçek isim yerine kurgusal `ogrenci`/`kalfa123` ile değiştirildi — gerçek isim/parola repo'ya girmez kuralı) | onaylandı |
| ck0250_loginTekIf | Aynı iç içe if mantığının `&&` ile tek if'e indirgenmesi | Console | operatör (`&&`) pekiştirme, ck0240 ile denklik | Console | arsiv/05cSharpÇekirdekKodlar.txt (madde 5, aynı isim değişikliği + ck0240'la birebir denklik için koşul ck0240'daki 3 varyantlı hâliyle eşitlendi) | onaylandı |
| ck0260_forDonguGiris | `for` döngüsüne giriş (sayaçlı azalan sayaç, `break` ile erken çıkış) — sınırlı deneme hakkı | Console | döngü (`for`, `break`) — zincirin yeni ANA halkası | Console | arsiv/06cSharpÇekirdekKodlar.txt (madde 1, isim değişikliği ck0240/250 ile aynı gerekçeyle) | onaylandı |
| ck0270_tekCiftKontrolu | `%` (mod) ile tek/çift kontrolü | Console | operatör (`%`) — zincire yeni halka | Console | arsiv/06cSharpÇekirdekKodlar.txt (madde 2+3 birleştirildi, kullanıcıdan sorulan `bolen` kaldırılıp sabit 2 yapıldı — orijinalde herhangi bir bölen girilebildiği için "tektir/çifttir" sonucu genel olarak yanlış çıkabiliyordu; `kalan==1` yerine `kalan==0` kontrolü negatif sayılarda da doğru sonuç verir) | onaylandı |
| ck0280_gecerliMenu | Çok seçenekli menüde önce geçerlilik kontrolü, sonra işlem — doğrulama sarmalayıcısı deseni | Console | karar yapısı (sarmalayıcı desen) pekiştirme | Console | arsiv/06cSharpÇekirdekKodlar.txt (madde 5, `ToInt16`→`ToInt32`) | onaylandı |
| ck0290_sembolIleSecim | Sembol tabanlı seçim — `char` ile `+ - * /` karşılaştırma, hesap makinesi zincirinin doğal hâli | Console | veri tipi (`char`) + karar yapısı pekiştirme | Console | arsiv/06cSharpÇekirdekKodlar.txt (madde 6, geçersiz seçimde hata mesajı "1-4 arası rakam" yerine sembollere uyarlandı) | onaylandı |
| ck0300_kdvHesaplama | KDV hesaplama — yüzde formülü `(oran/100)*sayı`, dallanma yok | Console | operatör (yüzde formülü) pekiştirme | Console | arsiv/07cSharpÇekirdekKodlar.txt (madde 2) | onaylandı |
| ck0310_maasKesinti | Maaş kesinti hesaplama — çok dallı yüzde, ck0300'ün üstüne biner | Console | operatör (yüzde formülü) + karar yapısı pekiştirme | Console | arsiv/07cSharpÇekirdekKodlar.txt (madde 1) | onaylandı |
| ck0320_birlerBasamagi | Birler basamağını bulma (`sayi % 10`) | Console | operatör (`%`) pekiştirme, bağımsız yeni teknik | Console | arsiv/07cSharpÇekirdekKodlar.txt (madde 5, `ToInt16`→`ToInt32`) | onaylandı |
| ck0330_onBeseBolunebilirlik | 15'e bölünebilirlik — `%3` + `%5` + `&&`, sonsuz döngü (`for(;;)`, break yok) | Console | operatör (`%`, `&&`) + döngü (`for(;;)`) pekiştirme | Console | arsiv/07cSharpÇekirdekKodlar.txt (madde 6, `ToInt16`→`ToInt32`) | onaylandı |
| ck0340_bankaHesabi | Banka hesabı — sonsuz döngü, kalıcı `bakiye` durumu, yatır/çek, hiç `break` içermeyen ilk örnek | Console | döngü (kalıcı durum) — zincire yeni halka | Console | arsiv/07cSharpÇekirdekKodlar.txt (madde 3, `ToInt16`→`ToInt32`; "Durdur butonu" notu açıkça eklendi) | onaylandı |
| ck0350_toplamBiriktirme | Toplam biriktirme (`+=`), 0 girilince çıkış — kırılgan (`Convert.ToInt32`, hatalı girdide çöker) | Console | döngü (biriktirici desen) — zincire yeni halka | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 1, `ToInt16`→`ToInt32`) | onaylandı |
| ck0360_tryParseIleSaglam | Aynı program, `int.TryParse` (`out` parametresi) ile hatalı girdiye dayanıklı hâle getirme | Console | metot (`TryParse`, `out`) — ck0350'nin doğrudan devamı | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 2) | onaylandı |
| ck0370_forAdimliArtis | `for` ile adım/artış belirleme (`i += 2`), aralık yazdırma | Console | operatör (`+=`) pekiştirme | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 3) | onaylandı |
| ck0380_tekrarGirdiDeseni | Döngü içinde tekrar girdi isteme deseni (pozitif/negatif/sıfır, 0'da çıkış) | Console | döngü (tekrar-sor deseni) pekiştirme | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 4, `ToInt16`→`ToInt32`) | onaylandı |
| ck0390_faktoriyel | Çarpımsal biriktirici (faktöriyel) + `i++` operatörü ilk kez | Console | operatör (`i++`) + döngü (çarpımsal biriktirici) pekiştirme | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 5, `ToInt16`→`ToInt32`; çıktı metni `"!= "` → `"! = "` düzeltildi, "!=" değil-eşittir gibi okunuyordu) | onaylandı |
| ck0400_periyodikBicimlendirme | Döngü içinde periyodik biçimlendirme (`i%5==1` ile satır atlama) | Console | operatör (`%`) pekiştirme — ünite 03'ü bitirip ünite 04'e taşıyor | Console | arsiv/08cSharpÇekirdekKodlar.txt (madde 6) | onaylandı |
| ck0410_dinamikAralik | Kullanıcının verdiği iki sayı arasını `for` ile yazdırma — dinamik aralık | Console | döngü (`for`, dinamik sınır) pekiştirme | Console | arsiv/09cSharpÇekirdekKodlar.txt (madde 1, `ToInt16`→`ToInt32`) | onaylandı |
| ck0420_birdenXeToplam | 1'den X'e toplam — biriktirici + kullanıcı sınırı | Console | döngü (biriktirici) pekiştirme | Console | arsiv/09cSharpÇekirdekKodlar.txt (madde 2, `ToInt16`→`ToInt32`) | onaylandı |
| ck0430_aralikCiftSayilar | Aralıkta çift sayılar + geçersiz girişte tekrar sorma — retry-on-invalid deseni | Console | döngü (iç içe `for`, tekrar-sor deseni) — zincire yeni halka | Console | arsiv/09cSharpÇekirdekKodlar.txt (madde 3, `ToInt16`→`ToInt32`) | onaylandı |
| ck0440_aralikTekSayilar | Aralıkta tek sayılar + başlangıcı ayarlama tekniği (`s1++` çiftse) — ck0430'un varyantı | Console | döngü pekiştirme | Console | arsiv/09cSharpÇekirdekKodlar.txt (madde 4, `ToInt16`→`ToInt32`) | onaylandı |
| ck0450_qIleCikis | Pozitif/negatif/sıfır analizi, çıkış `"q"` harfiyle — ck0380 ile aynı egzersiz, farklı çıkış mekanizması | Console | döngü (harf tabanlı çıkış) pekiştirme | Console | arsiv/09cSharpÇekirdekKodlar.txt (madde 5, `ToInt16`→`ToInt32`; ck0380 ile yapısal paralellik için sonuna `"Programdan çıkıldı"` + `ReadKey` eklendi) | onaylandı |

Faz talimatı (`D:\zihinEv\🏰 300-Projects\Gorev\10is-emri-ck-faz-talimati.md`) burada
tamamlandı — ck0220'den ck0450'ye 24 ders. Ünite 04'te ck0460-ck0490 arası 4 slot boş
kaldı (Özgür'ün dolduracağı `10cSharpÇekirdekKodlar.txt` ve olası araya-ekleme konuları
için pay, faz talimatının kendi notu).
| ck0460_tekSatirYildiz | Tek for döngüsüyle Console.Write ile aynı satıra yıldız yazdırma (WriteLine farkı) | Console | döngü + Console.Write pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 8) | onaylandı |
| ck0465_sabitDikdortgen | İç içe `for` ile sabit dikdörtgen çizme — zincirin yeni ANA halkası | Console | döngü (`for` içinde `for`) — yeni halka | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 1) | onaylandı |
| ck0470_bosSatirDeseni | Dış döngü sayacına bağlı karar ile bir satırı tamamen boş bırakma | Console | iç içe döngü + karar (satır bazlı) pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 3) | onaylandı |
| ck0475_dikdortgenBosluk | İç döngü sayacına bağlı karar ile her satırda aynı sütuna boşluk bırakma | Console | iç içe döngü + karar (sütun bazlı) pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 2) | onaylandı |
| ck0480_dortgendeDelik | Satır ve sütun koşulunu `&&` ile birleştirip desende tek bir konumu boş bırakma | Console | iç içe döngü + birleşik koşul (`&&`) pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 4; sayaç içindeki ek artırma koşullu yazımla düzeltildi) | onaylandı |
| ck0485_metindeYildizBiriktirme | Her satırın yıldızlarını metinde biriktirip satır bitince sıfırlama | Console | string birleştirme + iç içe döngü pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 5) | onaylandı |
| ck0490_artanUcgenFor | İç döngü sınırını dış sayaca bağlayarak artan üçgen çizme — yeni halka | Console | iç içe döngü, bağımlı sayaç sınırı — yeni halka | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 6) | onaylandı |
| ck0495_artanUcgenString | Aynı artan üçgeni tek döngü + string biriktirme ile çizme (ck0490 ile karşılaştırma) | Console | string birleştirme + döngü, ck0490 ile denklik | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 7) | onaylandı |
| ck0499_azalanUcgen | Azalan sayaçla (`k--`) ters üçgen çizme — ünite 04'ün kapanışı | Console | iç içe döngü, azalan bağımlı sayaç sınırı pekiştirme | Console | arsiv/11cSharpÇekirdekKodlar.txt (madde 9) | onaylandı |

**arsiv/12 bloğu başlıyor (2026-09-19, numara alanı ck0000-ck0999'a genişledikten sonra).**
Dizi zinciri: desen pekiştirme (ck0500-0525) → Random'a giriş (ck0530) → while/do-while
(ck0535-0580) → switch (ck0585-0600) → Random pekiştirme (ck0605-0620) → zamanlama
(ck0625-0645) → renk (ck0650-0655) → dizi (ck0660-0750) → fonksiyon (ck0755-0785) →
cast pekiştirme (ck0790). Not: `(Tip)değer` (cast) yazımı ilk kez ck0650'de (renk
dersinde) açık öğretildi — ck0790 artık bir pekiştirme, ilk tanıtım değil (üretim
sırasında fark edilen bir sıralama iyileştirmesi, plan tablosunda "kapanış" olarak
geçiyordu, hâlâ öyle ama "ilk tanıtım" değil). Kaynak: `arsiv/12cSharpÇekirdekKodlar.txt` (61 madde,
`arsiv/TALIMAT-12-icin-ck.md`). Atlanan: madde [06] 48forKactanKacaKadarYazdir (ck0410 ile
birebir aynı konu, duplicate). İşlenmeyen: `İNCELE: 303karekökMetodunuÖğrencilerYazsın`
(kaynak kod arşivde yok). **Blok 1/10 — desen ailesi devamı:**

| ck0500_carpimTablosuIcIce | İç içe `for` ile çarpım tablosu, kullanıcıdan sınır alma | Console | döngü (iç içe `for`) pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 5) | onaylandı |
| ck0505_usluSayiDongu | `for` ile üslü sayı hesaplama (çarpımsal biriktirici) | Console | döngü (çarpımsal biriktirici) pekiştirme, ck0780 ile eşleşir (fonksiyon versiyonu) | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 7) | onaylandı |
| ck0510_bosluklaHizalanmisUcgen | ck0490'daki artan üçgeni string biriktirmeyle (iki ayrı biriktirici) çizme | Console | string birleştirme + iç içe döngü, desen ailesi devamı | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 1, `42ciftUcgen`) | onaylandı |
| ck0515_simetrikPiramit | ck0510'a ikinci bir yıldız bloğu ekleyip simetrik piramit çizme | Console | string birleştirme pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 2, `43piramitUcgen-ss`; kod içi soru SEN YAP'a taşındı) | onaylandı |
| ck0520_acilanIkizUcgen | Aynı yıldız bloğunu iki kez yazdırıp aradaki boşluğu büyüterek "açılan" desen | Console | string birleştirme pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 3, `44piramitUcgenZor`) | onaylandı |
| ck0525_baklavaDeseni | ck0520'nin simetriğini ekleyip baklava (elmas) şekli oluşturma — desen ailesi kapanışı | Console | string birleştirme, iki blok birleşimi pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 4, `45ücgenBaklava`) | onaylandı |

**Blok 2/10 — Random'a giriş + while/do-while ailesi:**

| ck0530_randomaGiris | `Random` ile rastgele sayı üretme (`new`, `.Next(min,max)`) — yeni ANA halka | Console | nesne kullanımı (`new`) girişi | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 52, `100rasgeleSayiTut`) | onaylandı |
| ck0535_whileGiris | `while` döngüsüne giriş — 'q' harfiyle çıkış, belirsiz sayıda tekrar | Console | döngü (`while`) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 8, `160while01qYaBasanaKadar...`; `ToInt16`→`ToInt32`) | onaylandı |
| ck0540_doWhileGiris | `do-while`'a giriş — gövde önce çalışır, şart sonra kontrol edilir | Console | döngü (`do-while`) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 9, `168while100eKadarYazdir`; `++i` yerine `i++`+ayrı satır ile sadeleştirildi, prefix/postfix farkı henüz açılmadı) | onaylandı |
| ck0545_whileKiraSabit | `while` ile kira hesabı (sabit değerler, yüzde artış) | Console | döngü (`while`) pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 10, `163whileKira`) | onaylandı |
| ck0550_whileKiraKlavyeden | Aynı kira hesabı, kira ve zam klavyeden alınarak | Console | döngü (`while`) pekiştirme, ck0545'in devamı | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 11, `163verilerKlavyedenAlinsin`; `ToInt16`→`ToInt32`) | onaylandı |
| ck0555_doWhileBiriktirici | `do-while` ile biriktirici — 0 girilene kadar toplama | Console | döngü (`do-while`) + biriktirici pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 12, `162doWhile_sifirGirileneKadar`) | onaylandı |
| ck0560_doWhileCiftSayiFiltre | `do-while` + `if` süzgeci — sadece çift sayılar toplanır, tek girilince durur | Console | döngü (`do-while`) + karar pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 13, `163doWhileSonsuzTekCift`; kaynaktaki dizi kısmı çıkarıldı — diziler henüz öğretilmedi, ck0660'ta ayrı ders) | onaylandı |
| ck0565_doWhileFarkliSentinel | `do-while` ile farklı bir çıkış (sentinel) değeri — 0 yerine 10 | Console | döngü (`do-while`) pekiştirme, ck0555 ile yakın akraba | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 14, `165doWhile_besinKatiOlanBirSayiGirileneKadar`) | onaylandı |
| ck0570_doWhileLogin | `do-while` + `\|\|` ile giriş doğrulama | Console | döngü (`do-while`) + operatör (`\|\|`) pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 15, `164doWhile_KullaniciAdiSifre`; gerçek isim/parola yerine ck0240'taki kurgusal `ogrenci`/`kalfa123` kullanıldı) | onaylandı |
| ck0575_doWhileRandomTahmin | `do-while` + `Random`: sınırlı hakla sayı tahmin oyunu | Console | döngü (`do-while`) + nesne kullanımı pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 16, `162doWhileSayiTahminOyunu`; tutulan sayıyı ekrana yazdıran satır (oyunu bozan sızıntı) kaldırıldı, `ToInt16`→`ToInt32`) | onaylandı |
| ck0580_whileTekrarOyna | `while` ile "tekrar oyna" döngüsü — oyunun tamamı baştan tekrarlanır | Console | döngü (`while`) — ck0575 ile karşılaştırma | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 17, `166whileSayiTahminOyunu`; kaynak kod ciddi ölçüde sadeleştirildi — orijinalde 3 kez elle kopyalanmış, döngüsüz bir "hak" mantığı vardı, asıl değerli fikir olan "tekrar oyna" while döngüsü korunup gerisi temizlendi) | onaylandı |

**Blok 3/10 — switch-case ailesi + do-while/switch kapanışı:**

| ck0585_switchGiris | `switch`'e giriş — ck0180'deki else-if zincirinin `switch` ile yazımı | Console | karar yapısı (`switch`) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 19, `150switchCase`) | onaylandı |
| ck0590_switchHesapMakinesiChar | `switch` ile hesap makinesi (char seçim, `+ - * /`) | Console | karar yapısı (`switch`) + veri tipi (`char`) pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 20, `151switchCaseHesapMakinesi`; kaynakta `case '3'`/`'4'` yazılmıştı ama menü 1-4 numaralı gösteriliyordu — tüm case'ler `'1'-'4'`'e çevrilip menüyle tutarlı hale getirildi) | onaylandı |
| ck0595_switchHesapMakinesiString | Aynı hesap makinesi, `string` seçimle (`"1"-"4"`) | Console | karar yapısı (`switch`) + veri tipi (`string`) — ck0590 ile karşılaştırma | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 21, `151switchCaseHesapMakinesi2`) | onaylandı |
| ck0600_doWhileSwitchSayininOkunusu | `do-while` (retry-on-invalid) + dört ayrı `switch` ile sayının Türkçe okunuşu — döngü/karar ailesinin kapanışı | Console | döngü (`do-while`) + karar (`switch`) birleşimi, kapanış | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 18, `167doWhile_Switch_sayininOkunusu`; kaynaktaki `while (i==1)` şartı hiçbir zaman gerçek doğrulamayı yapmıyordu (`i` hiç değişmiyordu, döngü her zaman tek seferde bitiyordu) — gerçek retry şartına (`sayi>9999 \|\| sayi<0`) düzeltildi, gereksiz `i` değişkeni ve `break` kaldırıldı) | onaylandı |

**Blok 4/10 — Random pekiştirme + zamanlama + renk ailesi:**

| ck0605_forSonsuzRandomTahmin | `for(;;)` + `break` ile sınırsız hakla sayı tahmin oyunu — ck0575 ile karşılaştırma | Console | döngü (`for(;;)`+`break`) + Random pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 53, `101rasgeleSayiyiBul`; tutulan sayıyı ekrana yazan sızıntı satırı yoktu zaten, kalanı sadeleştirildi) | onaylandı |
| ck0610_besRastgeleSayi | Döngüde N adet rastgele sayı üretme | Console | döngü + Random pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 54, `102rasgeleBesSayiTut`) | onaylandı |
| ck0615_farkliArdisikSayi | Ardışık aynı sayıyı engelleme (`for` içinde `while` ile "tekrar dene") | Console | döngü içi döngü + Random pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 55, `103rasgeleBesFarkliSayiTut`; kaynakta `gecici` değişkeni hiç güncellenmiyordu, "farklı sayı" kontrolü fiilen çalışmıyordu — dizi kullanmadan (henüz öğretilmedi) sadece ARDIŞIK tekrarı engelleyen çalışan bir mantıkla yeniden yazıldı) | onaylandı |
| ck0620_randomAralikKlavyeden | Random aralığını ve adedini klavyeden alma — Random pekiştirme ailesinin kapanışı | Console | döngü + Random pekiştirme kapanışı | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 56, `104rasgeleIcinVerilerKlavyedenGirilsin`) | onaylandı |
| ck0625_zamanlamaGiris | `Thread.Sleep` ile zamanlanmış sayaç — yeni ANA halka (`using System.Threading;` gerekli) | Console | zaman kontrolü (`Thread.Sleep`) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 48, `090zamanlama`) | onaylandı |
| ck0630_zamanlamaHizlanan | Giderek hızlanan sayaç — bekleme süresi her turda azalıyor, sonsuz döngü | Console | zaman kontrolü pekiştirme, sonsuz döngü | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 49, `090zamanlama1`) | onaylandı |
| ck0635_zamanlamaIleriGeri | Sonsuz döngüde ileri-geri sayma (iç içe `for` + zamanlama) | Console | zaman kontrolü + döngü pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 50, `091zamanlama`; kod içi "10'ar 10'ar" görevi SEN YAP'a taşındı) | onaylandı |
| ck0640_zamanlamaSonsuzSayma | En sade sonsuz sayaç (`Console.Clear` yok, sayılar birikiyor) | Console | zaman kontrolü pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 51, `092sonsuzaKadarSayilariYazdir`) | onaylandı |
| ck0645_zamanlamaBaklava | ck0525 baklava deseni + zamanlama — desen ve zamanlama ailelerinin kapanışı | Console | desen + zaman kontrolü birleşimi, kapanış | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 58, `46baklavaThreading`) | onaylandı |
| ck0650_renkGiris | `ConsoleColor`'a giriş — `(Tip)değer` dönüşümünün (cast) ilk açık öğretimi (ck0060'taki ipucunun devamı) | Console | veri tipi dönüşümü (cast) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 59, `99rengarenkKodSatiri`; çift Clear+Sleep tekrarı tek sadeleştirilmiş renk döngüsüne indirgendi) | onaylandı |
| ck0655_renkVeIf | `ConsoleColor` + `if`: tek/çift sayıya göre renk — Random/zamanlama/renk ailesinin kapanışı | Console | cast + karar yapısı pekiştirme, kapanış | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 60, `99_1ConsoleColorVEif`) | onaylandı |

**Blok 5/10 — dizi ailesi (en büyük blok):**

| ck0660_diziyeGiris | Diziye giriş — `int[] sayilar = new int[2]`, indisle erişim | Console | dizi (`[]`, indis) — yeni ANA halka | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 22, `200dizi`; gereksiz `i` ofset değişkeni kaldırıldı, sadeleştirildi) | onaylandı |
| ck0665_diziLiteralBaslatma | Dizi literal ile başlatma (`{ "ali", "veli", ... }`) | Console | dizi pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 23, `201dizi`) | onaylandı |
| ck0670_diziForIleGirOku | `for` ile 3 elemanlı diziye giriş/okuma | Console | dizi + döngü pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 24, `205diziUcElemanli`; ara `Console.ReadKey()` kaldırıldı, tek sonda bırakıldı) | onaylandı |
| ck0675_diziFarkliSayiZorlama | Farklı sayı girmeye zorlama (`i--`/`k--` ile "geri sarma" — bilerek kusurlu, ck0680 ile karşılaştırma) | Console | dizi + iç içe döngü, kasıtlı hata inceleme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 25, `210diziFarkliUcSayiHatali`; format string eksik `{0}` cosmetic hatası düzeltildi, retry-mantığı hatası BİLEREK korundu — ck0680 ile çift oluşturuyor) | onaylandı |
| ck0680_diziFarkliSayiDuzeltilmis | Aynı problem, `tekrar` bayrağı + `k=-1` ile düzeltilmiş hâli | Console | dizi + iç içe döngü pekiştirme, ck0675 ile karşılaştırma | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 26, `210diziFarkliUcSayiDuzeltilmis`) | onaylandı |
| ck0685_diziRandomBasit | Dizi + Random: 3 rastgele sayı üretip diziye doldurma | Console | dizi + Random pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 28, `215diziRasgele`; gereksiz `(int)` cast kaldırıldı) | onaylandı |
| ck0690_diziRandomKosulluFiltre | Dizi + Random + koşullu filtre: sadece tek sayıları doldurma (`for` artışı boş) | Console | dizi + döngü içi koşullu artış pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 27, `215diziRasgeleTek`) | onaylandı |
| ck0695_diziRandomBiriktirme | Dizi + Random + biriktirme: toplamı son elemana koyma | Console | dizi + biriktirici pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 29, `220rasgeleDiziToplat`; gereksiz `(int)` cast kaldırıldı) | onaylandı |
| ck0700_dinamikBoyutluDizi | Dinamik boyutlu dizi — boyut klavyeden, `.Length` ile okuma | Console | dizi (`.Length`) pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 30, `221dinamikDizi`; `int.Parse`→`Convert.ToInt32` tutarlılık) | onaylandı |
| ck0705_diziArama | Dizide arama — `bool` bayrak + `break` ile doğru "bulunamadı" mesajı | Console | dizi + karar/döngü birleşimi, bug fix | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 31, `222dizideArama`; kaynakta `else` her adımda "bulunamadı" basıyordu, döngü bitince tek mesaj verecek şekilde düzeltildi) | onaylandı |
| ck0710_diziSilme | Dizide silme (`Array.Clear`) | Console | dizi — hazır metot | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 32, `223dizideSilme`) | onaylandı |
| ck0715_diziyeElemanEkleme | Diziye eleman ekleme (`Array.Resize`, `ref`) | Console | dizi — hazır metot + `ref` | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 33, `224diziyeElemanEkleme`) | onaylandı |
| ck0720_diziyiPozitifYapma | Diziyi pozitif yapma — mutasyon, `*=` pekiştirme | Console | dizi + operatör pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 34, `225diziyiPozitifYap`; ikinci döngüdeki sabit `6` yerine `.Length` kullanıldı, format string yerine `+` birleştirme) | onaylandı |
| ck0725_diziTersleme | Diziyi tersleme (`Array.Reverse`) | Console | dizi — hazır metot | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 35, `226diziyiTerstenSirala`) | onaylandı |
| ck0730_rastgeleDiziSiralama | Rastgele diziyi küçükten büyüğe sıralama (takas/swap ile) | Console | dizi + iç içe döngü, kendi sıralama mantığı | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 36, `239rasgeleDiziyiSirala`) | onaylandı |
| ck0735_ikiDiziRastgeleVeri | İki diziden AYNI rastgele indisle eşleşen veri çekme | Console | dizi + Random pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 37, `227stringDizidenRasgeleVeriCekme`; kaynakta `Next(1,6)` dizinin ilk/son elemanını hiç seçmiyordu, `Next(0, dizi.Length)` olarak düzeltildi) | onaylandı |
| ck0740_stringSesliHarfSayma | String'te sesli harf sayma — `string` indisle `char[]` karşılaştırma | Console | string/dizi köprüsü | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 39, `211stringtekiSesliHarfAdediniBul`) | onaylandı |
| ck0745_stringTerstenYazdirma | String'i tersten yazdırma — `.Length-1`'den azalan indis | Console | string indeksleme pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 40, `212StringiTerstenYazdir`) | onaylandı |
| ck0750_diziFonksiyonKoprusu | Dizi + fonksiyon köprüsü (`elemanEkle`/`listele`, class alanları) — dizi ailesinin kapanışı, fonksiyona geçiş | Console | dizi + fonksiyon (ilk kendi metodumuz) | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 38, `240Dizifonksiyon`; kaynakta zaten elle tamamlanmıştı) | onaylandı |

**Blok 6/6 — fonksiyon ailesi + cast pekiştirme kapanışı (arsiv/12'nin SON bloğu):**

| ck0755_fonksiyonStringTersCevirme | Fonksiyon ile string ters çevirme (`ToCharArray`, `return`) | Console | dizi/fonksiyon köprüsü devamı | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 41, `241stringiTerstenSirala`; kaynaktaki gereksiz karmaşık iç içe döngü [tek etkili adımı olan] doğrudan yarı-uzunluk swap döngüsüne sadeleştirildi) | onaylandı |
| ck0760_fonksiyonaGiris | Fonksiyona giriş — parametre ve `return` genel kuralı | Console | fonksiyon — yeni ANA halka (genel açıklama) | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 42, `299ikiSayiyiToplayanMetod`; `ToInt16`→`ToInt32`) | onaylandı |
| ck0765_fonksiyonDonguToplam | Fonksiyon + döngü: 1'den N'e toplam | Console | fonksiyon + döngü pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 43, `301metodToplam`; `ToInt16`→`ToInt32`) | onaylandı |
| ck0770_fonksiyonCarpmaPekistirme | Fonksiyon pekiştirme: çarpma (sabit değerlerle) | Console | fonksiyon pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 44, `298metodCarpma`; kaynakta metot adı `topla` idi ama gövde ÇARPMA yapıyordu — isim `carp` olarak düzeltildi) | onaylandı |
| ck0775_fonksiyonFaktoriyel | Fonksiyon ile faktöriyel | Console | fonksiyon + çarpımsal biriktirici pekiştirme | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 45, `300metodFaktoriyel`; `ToInt16`→`ToInt32`, çıktı `"!= "` → `"! = "` düzeltildi — ck0390 ile aynı gerekçe) | onaylandı |
| ck0780_fonksiyonUsluSayi | Fonksiyon ile üslü sayı — ck0505 ile aynı problem, fonksiyonlu çözüm karşılaştırması | Console | fonksiyon pekiştirme, ck0505 ile karşılaştırma | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 47, `49usluSayiHesaplaMetod`) | onaylandı |
| ck0785_hazirMetotKarekok | Hazır kütüphane metodu (`Math.Sqrt`) — kendi yazdığın vs hazır metot, fonksiyon ailesinin kapanışı | Console | fonksiyon kapanışı (hazır metot) | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 46, `302karekok_hazırMetot`; `double sayi = Convert.ToInt32(...)` yerine `Convert.ToDouble(...)` kullanıldı) | onaylandı |
| ck0790_castPekistirme | Cast operatörü pekiştirmesi — `(Tip)değer` konumunun sonucu değiştirmesi, ck0060'a geri dönüş — **arsiv/12'nin genel kapanışı** | Console | veri tipi dönüşümü (cast) pekiştirme, kapanış | Console | arsiv/12cSharpÇekirdekKodlar.txt (madde 57, `199farkliBirYazimKurali`; composite format string yerine `+` birleştirme) | onaylandı |

**arsiv/12 tamamlandı (2026-09-19).** 59 ders (ck0500-ck0790), 6 blok, hepsi
`dotnet run`/`dotnet build` ile doğrulandı. Atlanan 1 madde (duplicate), işlenmeyen
1 madde (kaynak yok) — toplam 61 madde ile tutarlı.

**arsiv/13 bloğu başlıyor (2026-09-19).** 29 madde, kaynak `0001lunaveriTemizleTest`
(arsiv/12'nin kaynağından ayrı). Atlanan 3 madde: [03] negatifPozitifSifir (kod "q"
çıkışını hiç implemente etmemiş, zaten ck0535'te düzgün işlenmiş), [09] ssUcTekSayiTut
(ck0690'ın dizisiz/daha basit hâli, yeni bir şey katmıyor), [21] DecimalBinary_for
([17] ile aynı ters-sıra sorununu taşıyor, daha karmaşık, ek değer yok). 26 ders,
ck0795-ck0920 (5'lik artış). Yeni ANA halkalar: `foreach`, `List<int>`,
`ConsoleKeyInfo`/tek tuş okuma. **Blok 1/6:**

| ck0795_ondalikliSayiGirisi | Ondalıklı sayı girişi — Türkçe ayraç virgül, nokta sessizce yanlış okunur | Console | veri tipi (`double`) girdi pekiştirme, kültür/yerelleştirme farkındalığı | Console | arsiv/13cSharpÇekirdekKodlar.txt (madde 1, `klavyedenOndalikliSayiAlma`) | onaylandı |
| ck0800_doWhileBosGirdiKontrolu | `do-while` + `string.IsNullOrWhiteSpace` ile boş/geçersiz girdi engelleme | Console | döngü (`do-while`) + hazır metot pekiştirme | Console | arsiv/13cSharpÇekirdekKodlar.txt (madde 2, `veriGirisindeSadeceEnteraBasilirsa`) | onaylandı |
| ck0805_forNoktaliVirgulTuzagi | Tuzak: `for(...);` sonrası fazladan noktalı virgül — bilerek hatalı, gerçek bir sınıf hatası | Console | döngü sözdizimi, kasıtlı hata inceleme | Console | arsiv/13cSharpÇekirdekKodlar.txt (madde 4, `sinavSorusuforFarkli`, "10B'nin takıldığı kod") | onaylandı |
| ck0810_baslangicAdimBitisKlavyeden | Başlangıç, adım ve bitiş hepsi klavyeden — ck0370 + ck0410 birleşimi | Console | döngü (adımlı + dinamik aralık) birleşimi pekiştirme | Console | arsiv/13cSharpÇekirdekKodlar.txt (madde 5, `ssfor`; kaynakta sadece görev tanımı (yorum) vardı, kod hiç yazılmamıştı — ck tarafından uygulandı) | onaylandı |

## Kara kutu takip tablosu

Hangi yapı hangi derste ilk göründü, nerede tam açılacak. "Merak Köşesi günlüğü" —
hangi derste o kutuya dair ne söylendi, rotasyon kaybolmasın diye tutulur. Rotasyon
sırası: `using` → `namespace` → `class Program` → `static Main` → `Console.ReadKey` →
(başa dön). ck0010 kendi Merak Köşesi'ni kullanmaz (sadece çerçeve notunu taşır),
rotasyon ck0020'den başlar. ck0070 kendi yeni fikri (metot/sınıf terimleri) ağır
olduğu için Merak Köşesi'ni atlar — rotasyon kaymaz, sıradaki kutu ck0080'e geçer.
ck0100 de kendi yeni fikri (aynı derste byte/bool/char — üç yeni tip) ağır olduğu
için Merak Köşesi'ni atlar; rotasyon kaymaz, sıradaki kutu (`class Program`, 2. tur)
bir sonraki derse geçer. ck0110=`class Program` (2. tur), ck0120=`static Main` (2. tur),
ck0130=`Console.ReadKey` (2. tur) — 2. tur tamamlandı. ck0140 ve ck0150 (if/else girişi
ve çok dallı karar — karar yapısı zincirine yeni halka) yük freniyle Merak Köşesi'ni
atlıyor; rotasyon kaymıyor, sıradaki kutu `using` (3. ve **son** tur, sonra emekli)
bir sonraki yüksüz derste kullanılacak. ck0160 (pekiştirme, yüksüz) bu kutuyu kullandı —
`using` artık **emekli**. Sıradaki kutu `namespace` (3. ve son tur) ck0170'te (pekiştirme,
yüksüz) kullanıldı — `namespace` de **emekli**. ck0180 (sıralı aralık kontrolü), ck0190
(`\|\|`), ck0200 (Convert.ToChar) ve ck0210 (`&&`) kendi yeni fikirleri ağır olduğu için
Merak Köşesi'ni atladı (yük freni); rotasyon kaymadı, sıradaki kutu `class Program`
(3. tur) bir sonraki yüksüz derste kullanılacak. ck0220 (dört işlem, pekiştirme, yüksüz)
bu kutuyu kullandı — `class Program` artık **emekli**. Sıradaki kutu `static Main`
(3. ve son tur) bir sonraki yüksüz derste kullanılacak. ck0230 (`!`) ve ck0240 (iç içe if)
kendi yeni fikirleri ağır olduğu için (zincire yeni halka) Merak Köşesi'ni atladı; rotasyon
kaymadı. ck0250 (login && indirgeme, ck0240'ın doğrudan pekiştirme companion'ı, yüksüz) bu
kutuyu kullandı — `static Main` da **emekli**. ck0260 (`for` döngüsü, zincirin yeni ANA
halkası) ağır olduğu için Merak Köşesi'ni atladı. Sıradaki ve **son** kutu `Console.ReadKey`
(3. ve son tur) ck0270'te (`%` ile tek/çift, yüksüz) kullanıldı — `Console.ReadKey` de
**emekli**. **Beş iskelet kutusunun hepsi artık emekli** — ünite 07'ye (`02_cSharpForm_ck`)
kadar Merak Köşesi bu beş kutudan hiçbirini bir daha kullanmayacak; ck0280'den itibaren
yeni dersler kendi yeni fikirleri ağırsa zaten, hafifse de artık gösterecek bir iskelet
kutusu kalmadığı için Merak Köşesi bölümünü hiç içermeyebilir — bu normaldir, kural
ihlali değildir.

**Açılış yeri ünite 07 (2026-09-05, Özgür onayladı — Karar 16).** Beş iskelet kutusu
(`using`, `namespace`, `class Program`, `static Main`, `Console.ReadKey`) WinForms
ünite 07'de (nesne tabanlı programlama girişi) kapanacak — ayrıntı `winforms-plan.md`
"Kara kutu takvimi". Eski "ünite 03" ibaresi bu yüzden "ünite 07" olarak düzeltildi.

**Rotasyon freni (Karar 17).** Bir kutu **3 tur** Merak Köşesi'ne konu olduysa
`emekli` sayılır, ünite 07'ye kadar bir daha yazılmaz — "tur/emekli" sütunu bunu
izler. Köşenin asıl işi dersin **kendi yeni** kara kutusu; iskelet rotasyonu yalnız
kendi yeni kutusu olmayan derslerde yedek olarak devreye girer.

| yapı | ilk göründüğü ders | açılacağı yer | tur / emekli | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------|----------------------|-----|
| `using System;` / `using System.Collections.Generic;` / `using System.Linq;` / `using System.Text;` / `using System.Threading.Tasks;` | ck0010 | ünite 07 (nesne tabanlı programlama) | 3 tur — **emekli** | ck0020: hazır kütüphaneleri projene dahil eder; ck0080: neden 5 ayrı satır var, her biri ayrı bir "araç kutusu" (2. tur, yeni açı); ck0160: hepsi her programda kullanılmaz, bu derste sadece System işe yaradı (3. tur, yeni açı) | [iskelet-bağımlı] — VS'in her yeni Console projesine otomatik eklediği satırlar |
| `namespace <proje adın>` | ck0010 | ünite 07 (nesne tabanlı programlama) | 3 tur — **emekli** | ck0030: kodları isim altında gruplayan "klasör" gibidir, proje adından VS'in ürettiği isim; ck0090: her yeni projede namespace'in neden değiştiği (2. tur, yeni açı); ck0170: her yeni proje kendi namespace'ini alır (3. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `class Program` | ck0010 | ünite 07 (nesne tabanlı programlama) | 3 tur — **emekli** | ck0040: namespace'in içindeki kutulardan biri, yazdığın her satır bu kutuda durdu; ck0110: adı hep aynı kalır (VS otomatik verir), namespace proje adına göre değişir (2. tur, yeni açı); ck0220: kaç satır yazarsan yaz kutu büyümüyor, sadece içi doluyor (3. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `static void Main(string[] args)` | ck0010 | ünite 07 (nesne tabanlı programlama) | 3 tur — **emekli** | ck0050: class Program'ın içinde, programın başladığı satır; ck0120: başladığı satırdan itibaren kod yukarıdan aşağı sırayla çalışır (2. tur, yeni açı); ck0250: iki farklı yazım (ck0240/ck0250) aynı işi yapsa da ikisi de yine bu satırdan başladı — yazım değişir, başlangıç değişmez (3. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `Console.ReadKey();` | ck0010 | ünite 07 (nesne tabanlı programlama) | 3 tur — **emekli** | ck0060: Main'den sonraki son satır, o olmasa pencere anında kapanır; ck0130: iki sonuç hesaplanan derste neden en sonda durması gerektiği (2. tur, yeni açı); ck0270: if/else'in sadece bir dalı çalışsa da hangi yoldan gidilirse gidilsin en sonunda hep bu satıra gelinir (3. tur, yeni açı — kapanış) | rotasyona ck0060'ta katıldı; ünite 07'ye kadar burada bir daha görünmeyecek |
| `Console.WriteLine`/`Write` (metot), `Console` (sınıf) terimleri | ck0010 | ck0070 (üretildi) | rotasyon dışı | ck0070: void ile başlayan her şey metot, Console bir sınıf | rotasyon dışı — VS iskeletinden bağımsız, Console zaten var olan hazır bir sınıf |
| `new` (nesne oluşturma) | ck0530 | ünite 07 (nesne tabanlı programlama) | rotasyon dışı, tekrar edecek | ck0530: Random tarifinden gerçek bir üretici oluşturmak için kullanılıyor, kendi tariflerimizi (sınıf) yazınca daha sık göreceğiz | 5 iskelet kutusundan farklı, ayrı takip edilen yeni bir kutu — dizi bölümünde (`new int[]`, ck0660 civarı) tekrar görülecek, o zaman "tekrar değil yeni açı" kuralına göre değerlendirilecek |
