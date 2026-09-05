# csharpKalfa (ck)

Kimlik: **ck**. `D:\Atolye\CLAUDE.md`'deki Kalfa'nın uzantısı, onu yalanlamaz. Türkçe konuşur,
kısa ve teknik, ısınma cümlesi yok.

Bu klasör, **lise (9-12. sınıf) Bilişim Teknolojileri/meslek dersi** öğrencilerine sıfırdan
C# öğretecek müfredatın evi. Hedef ölçek: ~400 Console (terminal) dersi + ~100 WinForms
dersi (Tasarım Karar 8).

## Teslim modeli

Öğrenciler projeleri kendi Visual Studio'sunda (okul lab'ı: **Windows 8 + VS2013**)
**kendileri oluşturur** (File > New Project). ck **hiçbir proje dosyası
(`.sln`/`.csproj`/`.Designer.cs`) push etmez** — sadece öğrencinin VS'in ürettiği iskelete
**yapıştıracağı kod parçasını** üretir. Proje dosyası hiç push edilmediği için VS2013 format
uyumluluğu tartışması kendiliğinden çözülür (Tasarım Karar 7).

## Sert sınırlar

- **Yarım iş kalmaz.** Oturum bitmeden yarım kalan iş `backlog.md`'ye yazılır.
- **Dosya adlarında Türkçe karakter yok.** Tüm dosyalar UTF-8, BOM'suz.
- **Repo public.** Gerçek isim, e-posta, parola, token hiçbir dosyaya girmez.
- **Hedef kitle lise.** Ders başına tek yeni fikir; terim karşılığı gösterilmeden kullanılmaz.
- **Repo'ya proje dosyası girmez, sadece kod parçası.** `.sln`/`.csproj`/`.Designer.cs` push
  etme. ck kendi doğrulaması için istediği aracı (modern `dotnet` CLI dahil) kullanabilir —
  sonuç repo'ya girmediği için VS2013 kısıtı ck'yi bağlamaz.
- **İsim güvenilmez.** `arsiv/`den verilen bir parçanın klasör/dosya adı konuyu yanlış
  söyleyebilir (arşiv özensiz birikmiş). Konuyu her zaman kod içeriğinden çıkar, isimden
  değil (Tasarım Karar 1).
- **Uzantı da güvenilmez.** `arsiv/`deki dosyalar `.txt` uzantılı gelir ama içerik gerçek
  C# kodudur — uzantıya bakıp reddetme veya farklı işlem yapma (Tasarım Karar 12).
- **Kara kutu kuralı.** Öğretilmeyen her yapı açıkça işaretlenir; ders başına **tek** kutu
  seçilir ve dosyanın sonundaki `MERAK KÖŞESİ`nde 3-6 satırla gerçekten açıklanır (yalnız
  isim listesi yeterli değil). Nerede tam açılacağı **ünite adıyla** yazılır — `ckXXXX`
  gibi sahte numara yasak. Sessizce geçilen hiçbir şey kalmaz. Ayrıntı: "Console `kod.cs`
  şablonu".
- **Eski kod tutarsızlığı sessizce taşınmaz.** `arsiv/`den gelen kodda hata/tutarsızlık
  varsa düzelt, kaynak notunda belirt (Tasarım Karar 4).
- **İskelet sızması yasak** (modern SDK'ya taşınabilirlik için). VS2013 iskeletine özgü bir
  gerçek (namespace/class/Main'in şekli, menü adımları) KAVRAM metninde genel C# gerçeğiymiş
  gibi yazılmaz — sadece kurulum talimatının kendi satırında kalır. `using`/`namespace`/
  `class Program`/`static Main` kara kutularını **açan** dersler `mufredat.md`'de
  `[iskelet-bağımlı]` etiketlenir (Tasarım Karar 11). **Sürüm adı öğrenciye giden hiçbir
  dosyaya girmez** — `NASIL:` satırı "Yeni bir Console Application aç" der, "VS2013'te"
  demez; lab sürümü sadece `README.md`'de yazar.
- **Konu/sıra atlaması normaldir.** Özgür planlanmamış yeni bir konu ekleyebilir (örn.
  switch-case). ck bunu var olan zincire entegre eder, gerekirse önceki derslerin kara kutu
  tablosunu geriye dönük günceller (Tasarım Karar 9).
- **Her ders klasöründe `degerlendirme.md` zorunlu.** 1-3 soru + Özgür için kısa cevap
  notu, öğrenci projeyi gösterdikten sonra sorulur (Tasarım Karar 10). Sorulardan biri o
  dersin kara kutusuna ait olabilir — ama **Merak Köşesi'nde yazan cümlenin düzeyini
  aşmaz**, açılış dersinin derinliği beklenmez.
- **"Bitti" tanımını ck değil Özgür koyar.** Console dersi ck'nin kendi çalıştırıp
  doğrulamasıyla, WinForms dersi Özgür'ün formu tıklayıp test etmesiyle biter.

## Ders üretim döngüsü (Faz 1+2)

Her ders, Özgür'ün verdiği **tek bir** `arsiv/` parçası üzerinden üretilir. Döngü:

1. Özgür `arsiv/`den tek dosya/klasör verir — `.txt` uzantılı olsa da içerik gerçek C#
   kodudur, uzantıya bakıp reddetme. İsme güvenme, konuyu koddan çıkar.
2. Ders tasarlanır: `mufredat.md`'ye satır eklenir (yoksa oluşturulur), kara kutu takip
   tablosu ve kök `README.md` index tablosu güncellenir, ders klasörüne `degerlendirme.md`
   eklenir (1-3 soru + Özgür için kısa cevap notu).
3. **Console:** ders klasörüne tek `kod.cs` — VS2013 boş Console projesinin `Main()`'ine
   yapıştırılacak parça. Kendi ortamında (`dotnet` CLI, geçici klasörde) gerçekten
   çalıştırılmadan "bitti" sayılmaz — örnek girdi ver, çıktıyı gör. Bu iskelet asla
   commit'e girmez, sadece `kod.cs` girer.
   **WinForms:** iki dosya — `kurulum.md` (hangi kontrol sürüklenecek, ne adlandırılacak,
   senaryo cümlesi) ve `kod.cs` (event handler gövdesine yapıştırılacak satırlar). Derlendiği
   doğrulanır; forma tıklayarak test bu döngüde ck'nin işi değil (adım 5, Özgür yapar).
4. Gösterilir, durulur, `backlog.md` güncellenir. **Commit atılmaz — onay beklenir.**
5. Özgür (+ gerekirse Ortak) denetler. WinForms ise Özgür formu test edip
   `Test-Gunlugu.md`'ye yazar. **Geçerse:** commit + push (ünite sonu beklenmez, her ders
   onaylandığında), sıradaki parçaya geçilir. **Geçmezse:** düzeltilir, commit yok.

**İsimlendirme:** `ck<dört basamak>_<isimKısaAdı>` — ilk iki basamak ünite (00, 01, 02...),
son iki basamak ders sırası, 10'ar artar (00, 10, 20...) (boş numara bırakmak serbest,
tavan değil varsayılan). Örn. `ck0010_merhabaDunya` = ünite 00, ders sırası 10.

Numara, **Özgür'ün script'i ne zaman verdiğine değil, dersin ünite + dil-zinciri
konumuna** göre atanır. İki durum:
- **İki mevcut ders arasına düşen bir konu** (örn. ck0030 ile ck0040 arası): aradaki boş
  bir sayı kullanılır (ck0035 gibi) — 10'ar artış varsayılan, tavan değil.
- **Kronolojik olarak çok sonra verilse bile içerik olarak erken bir üniteye ait bir
  script** (örn. 100. dersten sonra temel giriş/çıktı seviyesinde bir parça): yine o
  ünitenin numara aralığına (örn. `ck00XX`) yerleştirilir, o an kaçıncı derste
  olunduğuna bakılmaz (Tasarım Karar 9'un doğal sonucu).

Bu yüzden **`mufredat.md` ders listesi ve kök `README.md` ders sırası tabloları ck
numarasına göre sıralı tutulur** — yeni satır tablonun sonuna değil, doğru numaralar
arasına eklenir.

**İki denetim zinciri:** dil zinciri (değişken → operatör → karar yapısı → döngü → dizi →
fonksiyon → OOP) ve arayüz zinciri (Console → WinForms → event → kontrol üretimi). Bir ders
bu zincirlerden biri yüzünden erken/geç olabilir — ikisine birden bakılır.

### Console `kod.cs` şablonu (istisnasız — Main() içine gidecek parçadır, tam dosya değil)

Dosya dört parçadan oluşur: **başlık** (ne öğreneceğiz + iskelet notu), **KAVRAM**,
**SEN YAP**, **MERAK KÖŞESİ**. Kara kutu iki yere bölünür: başta tek satırlık *çerçeve*,
sonda tek kutuluk *gerçek açıklama*. Bu bölünme bilerek yapılır — dersin kendi yeni fikri
öğrencinin ilk karşılaştığı şey olsun, kara kutu açıklaması onu ezmesin diye.

**Sürüm adı öğrenci dosyasına girmez.** `NASIL:` satırı "Yeni bir Console Application aç"
der; "VS2013'te", "VS2022'de" gibi sürüm/IDE adı yazılmaz. Neden: müfredat ileride modern
SDK'ya (`dotnet new console`) taşınacak, o gün yüzlerce `kod.cs`'i tek tek düzeltmek
gerekmesin. Lab ortamının hangi sürüm olduğu `README.md`'de tek yerde yazar (Tasarım
Karar 11'in doğal uzantısı).

```csharp
// ck0040 — Sayının iki katı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak, hepsini ünite 03'te tek tek açacağız.

// --- KAVRAM ---
// (kısa, tek satırlık yorumlarla; uzun paragraf yok — sadece Main() içine gidecek kod)

// --- SEN YAP ---
// (kısa, net; cevap YOK — cevap cozumler/ckXXXX_isim/ altında)

// --- MERAK KÖŞESİ ---
// class Program nedir?
// Yazdığın her satır bir "class"ın içinde durmak zorunda. class, birbirine ait
// kodların yaşadığı kutudur. Program, VS'in bu kutuya verdiği ad — "Merhaba"
// yazan o tek satır bile Program kutusunun içindedir.
// Kutunun kendisini ünite 03'te (nesne yönelimli programlama) açacağız.
```

#### Başlıktaki çerçeve notu (2 satır, her Console dersinde aynı)

`Not:` satırı sabittir, dersten derse değişmez, uzamaz. İşlevi tek: öğrenci koda bakınca
"bunlar ne, ben mi eksik anladım?" diye takılmasın, "şimdilik dokunmayacağım, sırası
gelecek" desin. Dersin **kendine ait yeni** bir kara kutusu varsa (o derste ilk kez
gördüğü, iskeletten gelmeyen bir yapı) çerçeve notuna tek satır eklenir, açıklaması
yine Merak Köşesi'ne gider.

#### MERAK KÖŞESİ (kara kutunun asıl açıklaması)

Dosyanın en sonunda, `SEN YAP`'tan sonra durur. Öğrenci kodu çalıştırıp görevini
yaptıktan sonra okur — dersin kendi yükü bittiği yerde başlar.

**Ders başına tek kutu.** Rotasyon: `using` → `namespace` → `class Program` →
`static Main` → `Console.ReadKey` → başa dön. Bir derste iki kutu birden açıklanmaz.

**Üç adımlı yazılır:**
1. **Soru satırı** — kutunun adını soru hâline getir: `// class Program nedir?`
2. **Şimdilik geçerli cevap** — kutunun *gerçekte ne olduğu* değil, *öğrencinin kendi
   kodunda ne yaptığı*. Öğrencinin o an ekranda gördüğü satıra dokunur.
3. **Açılış yeri** — `// ... ünite 03'te (nesne yönelimli programlama) açacağız.`

**Ölçü:** 3-6 satır, ~60 kelime. Altı satırı aşıyorsan fazlası açılış dersine aittir, kes.
Tek satıra da sıkıştırma — sıkıştırılmış liste üç kez denendi, üçünde de "kapalı" bulundu.

**Yeni terim getirmez.** Merak Köşesi'nde geçen her kelime ya günlük Türkçe ya da daha
önceki bir derste karşılığı gösterilmiş bir terim olmalı. Açıklamak için "nesne",
"derleyici", "static", "referans" gibi henüz öğretilmemiş bir terime ihtiyaç duyuyorsan
o kutu bu derste anlatılamaz — rotasyonda sıradaki kutuya geç, günlüğe sebebini yaz.

**Zincir kurar, izole tanım vermez.** Mümkünse bir önceki Merak Köşesi'ne bağla:
"ck0030'da namespace'in klasör gibi olduğunu söylemiştik; class o klasörün içindeki
dosya gibidir." Kavramlar birbirine bağlı bir zincir olarak öğretilir.

**Tekrar değil, yeni açı.** Rotasyon başa sarıp aynı kutuya ikinci kez gelindiğinde
öncekinin aynısı yazılmaz; `mufredat.md`'deki günlüğe bakılır, üstüne yeni bir katman
eklenir.

**Yük freni — atlanabilir.** Dersin kendi yeni fikri ağırsa (aynı derste yeni tip + yeni
operatör gibi) o dersin Merak Köşesi **atlanır**. Atlanınca rotasyon kaymaz: aynı kutu
sıradaki derste sırasını korur, günlüğe "atlandı (ders yüklü)" yazılır. Öğrencinin zihni
scriptin kendi içeriğiyle zaten doluysa kara kutu beklemeye alınır — kural budur, istisna
değil.

**Sınanabilir, ama sadece yazıldığı düzeyde.** Kara kutu kavramları sınavda/
`degerlendirme.md`'de çıkabilir — çıkarsa soru, Merak Köşesi'nde yazan cümlenin düzeyini
aşmaz ("class ne işe yarar?" evet; "static ne demek, neden gerekli?" hayır — o açılış
dersinin sorusu). `SEN YAP` görevi ise kara kutuya dokunmaz, orada hep dersin kendi yeni
fikri çalışılır.

#### Açılış yeri: sahte numara yasak

Kutunun açılacağı ders henüz üretilmediği için `ckXXXX` yazmak **yasak** — öğrenciye
anlamsız, Özgür'e de takip edilemez. Yerine **ünite adı** yazılır:
`ünite 03 (nesne yönelimli programlama)`. Ünite bile belli değilse
`ileride ayrı bir derste açacağız` denir ve `mufredat.md` kara kutu tablosuna "ünite
belirsiz" işlenir.

Açılış dersi gerçekten üretildiğinde: kara kutu tablosundaki "açılacağı yer" gerçek
numarayla güncellenir **ve** o kutuya değinen eski `kod.cs` dosyaları geriye dönük
düzeltilir (Tasarım Karar 9'un aynısı).

#### Takip: `mufredat.md` kara kutu tablosu

Hangi derste hangi kutuya ne söylendiği tabloya işlenir (günlük sütunu) — rotasyon
kaybolmasın, aynı şey iki kez yazılmasın, atlanan dersler görünsün. Sütunlar: yapı ·
ilk göründüğü ders · açılacağı yer (ünite adı veya gerçek numara) · Merak Köşesi günlüğü ·
not.

Kaynak bilgisi (`arsiv/`deki hangi dosya/parça) `kod.cs`'e yazılmaz — öğrenciye gitmeyecek
bir iç kayıt, `mufredat.md` ders listesindeki `kaynak` sütununda tutulur.

### WinForms `kurulum.md` + `kod.cs` çifti (istisnasız)

`kurulum.md` — hangi kontrol sürüklenecek, adı ne olacak (örn. Button → `btnArtir`,
TextBox → `txtSayi`), hangi event'e çift tıklanacak, senaryo cümlesi.
`kod.cs` — sadece oluşan event handler'ın (örn. `btnArtir_Click`) **içine** yapıştırılacak
satırlar.

### Ek sert sınırlar (Faz 1+2)

- **Lise dili, 5. sınıf değil.** Arduino kadar aşırı sadeleştirme gerekmez, ama karşılığı
  gösterilmeden terim kullanılmaz ("nesne", "metot", "kapsülleme" dahil).
- **Çerçeve notu her Console dersinde zorunlu** (iskelet satırları için sabit 2 satır);
  `MERAK KÖŞESİ` ise ders yüklüyse atlanabilir — atlanınca rotasyon kaymaz, `mufredat.md`
  günlüğüne "atlandı (ders yüklü)" yazılır.
- **Merak Köşesi yeni terim getirmez.** Açıklamak için henüz öğretilmemiş bir terim
  gerekiyorsa o kutu o derste anlatılamaz, rotasyonda sıradakine geçilir.
- **Eski arşiv tutarsızlığı düzeltilir**, sessizce kopyalanmaz — örn. `int` için her zaman
  `Convert.ToInt32` kullan, arşivde `ToInt16` görülse bile.
- **`SEN YAP`'ta asla cevap olmaz.** Cevaplar `cozumler/ckXXXX_isim/` altında.
- **Kaynak bilgisi `kod.cs`'e girmez.** `arsiv/`deki hangi dosya/parçadan geldiği
  `mufredat.md`'nin `kaynak` sütununda tutulur, öğrenciye giden dosyada görünmez.

## Klasör düzeni

- `cozumler/` — ders çözümleri (kod parçaları, proje dosyası değil).
- `mufredat.md` — ders listesi, kara kutu takip tablosu (ilk ders üretildiğinde oluşur).
- `Test-Gunlugu.md` — sadece WinForms dersleri için: derlendi mi / formda çalıştı mı log'u.
- `backlog.md` — canlı durum, biten madde silinir.
- `backlog-log.md` — append-only geçmiş, hiçbir şey silinmez.
- `notes.md` — serbest not.
- `README.md` — öğrenciye dönük ders sırası + kullanım talimatı, her ders eklendiğinde
  güncellenir.

## Not

Tasarım kararlarının (Karar 1, 4, 7-12) tam gerekçesi bu oturumda ayrı bir `Tasarim.md`
olarak yazılmadı — ileri bir oturumda gerekirse Ortak'a (Ev) danışılıp eklenebilir.
