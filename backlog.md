# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **ck0220-ck0450 onay bekliyor (24 ders, hepsi tek oturumda üretildi).**
  `D:\zihinEv\🏰 300-Projects\Gorev\10is-emri-ck-faz-talimati.md` (Ortak'ın faz talimatı)
  baştan sona uygulandı — Özgür "0230 ve sonrasında sonuna kadar sırayla devam et, durma"
  dedi, onay durakları atlanıp tek seferde üretildi. Her ders kendi geçici klasöründe
  (`dotnet run`, çoğunda `ReadKey` gerçek klavye beklediği için yorumda/pipe'lı girdiyle)
  gerçekten çalıştırıldı, çıktılar doğrulandı — istisna: ck0330 ve ck0340 sonsuz döngü
  (`for(;;)`, break yok) içerdiği için `timeout`/pipe ile sınırlı girdi sonrası doğal
  şekilde durduruldu (bir kere arka plan görevi EOF'ta `Convert.ToInt32(null)`'ın 0
  dönmesi yüzünden gerçekten sonsuza koştu, `TaskStop` ile durduruldu — kod hatası değil,
  headless test ortamının EOF davranışı).
  - **Blok05 (ck0220-ck0250, arsiv/05):** ck0220 dört işlem formatlı yazdırma; ck0230 `!`
    operatörü (10 ifadelik script'ten sadece `!` işlendi, gerisi SEN YAP'a taşındı);
    ck0240 iç içe if; ck0250 aynı mantığın `&&` ile tek if'e indirgenmesi (ck0240'la
    art arda, aynı 3 test senaryosuyla denklik gösteriliyor).
  - **Blok06 (ck0260-ck0290, arsiv/06):** ck0260 `for` döngüsüne giriş (sayaçlı azalan,
    `break`) — zincirin yeni ANA halkası; ck0270 `%` ile tek/çift (madde 2+3 birleşti,
    kullanıcıdan sorulan `bolen` kaldırılıp sabit 2 yapıldı — orijinal herhangi bir bölen
    girilebildiği için "tektir/çifttir" sonucunu genel olarak yanlış hale getiriyordu);
    ck0280 doğrulama sarmalayıcısı deseni; ck0290 sembol tabanlı seçim. **Ünite 02
    tamamlandı (ck0210-ck0290).**
  - **Blok07 (ck0300-ck0340, arsiv/07):** basitten karmaşığa yeniden sıralandı — ck0300
    KDV, ck0310 maaş kesinti, ck0320 birler basamağı, ck0330 15'e bölünebilirlik
    (sonsuz döngü ilk kullanımı, kod içi not eklendi), ck0340 banka hesabı (hiç `break`
    içermeyen ilk örnek — "VS'in kırmızı Durdur butonuyla kapat" notu header'a açıkça
    eklendi, faz talimatının özel talebiydi).
  - **Blok08 (ck0350-ck0400, arsiv/08):** ck0350 toplam biriktirme (kırılgan,
    `Convert.ToInt32` hatalı girdide çöker); ck0360 `int.TryParse`/`out` ile sağlamlaştırma
    (ck0350'nin doğrudan devamı); ck0370 `i+=2` adımlı for; ck0380 tekrar-girdi-isteme
    deseni; ck0390 faktöriyel + `i++` (çıktı metni `"!= "` → `"! = "` düzeltildi, "eşit
    değil" gibi okunuyordu); ck0400 periyodik satır atlama. **Ünite 03 tamamlandı
    (ck0300-ck0390).**
  - **Blok09 (ck0410-ck0450, arsiv/09):** ck0410 dinamik aralık; ck0420 1'den X'e toplam;
    ck0430 aralıkta çift + retry-on-invalid; ck0440 aralıkta tek + `s1++` başlangıç ayarı;
    ck0450 pozitif/negatif/sıfır, çıkış `"q"` ile (ck0380 ile karşılaştırma için sonuna
    `"Programdan çıkıldı"` + `ReadKey` eklendi, yapısal paralellik).
  - **Kara kutu rotasyonu tamamen bitti:** ck0220 `class Program` (3.tur, emekli), ck0250
    `static Main` (3.tur, emekli), ck0270 `Console.ReadKey` (3.tur, emekli) — beş iskelet
    kutusunun hepsi artık emekli, ünite 07'ye kadar Merak Köşesi'nde bir daha görünmeyecek.
    ck0280'den itibaren hiçbir derste Merak Köşesi bölümü yok, bu normal (mufredat.md'de
    açıklandı).
  - **Spec dışı karar — isim/parola değişikliği (flag, onay bekliyor):** arşivde
    ck0240/ck0250/ck0260'ın kaynağı olan login örnekleri gerçek kullanıcı adı ("Özgür")
    ve gerçek görünümlü bir parola ("öz123") içeriyordu. Repo public olduğu ve kural
    "gerçek isim/parola hiçbir dosyaya girmez" dediği için (üst CLAUDE.md, istisnasız)
    ck bunları sessizce **kurgusal** `ogrenci`/`kalfa123` ile değiştirdi. Bu, faz
    talimatında yazmayan bir karardı — Özgür onaylamalı ya da başka bir kurgusal
    değer istiyorsa söylemeli.
  - **mufredat.md** (ders listesi + kara kutu tablosu + rotasyon anlatımı) tamamen
    işlendi. Ünite 04'te ck0460-ck0490 arası 4 slot bilerek boş bırakıldı (faz
    talimatının kendi notu — Özgür'ün `10cSharpÇekirdekKodlar.txt`'yi dolduracağı pay).
- **ck0160-ck0210 onay bekliyor.** `arsiv/04cSharpÇekirdekKodlar.txt` (madde 16-20) altı
  derse bölündü: ck0160 (if/else sayısal <, pekiştirme), ck0170 (if/else sayısal ==,
  pekiştirme, ck0110 dörtgen temasına bağlı), ck0180 (else if sıralı aralık kontrolü —
  yeni halka), ck0190 (`||` mantıksal VEYA — yeni halka), ck0200 (Convert.ToChar ile char
  okuma — yeni halka), ck0210 (`&&` mantıksal VE, `||`+`&&` bir arada, parantez önceliği —
  yeni halka). Madde 20 tek arşiv maddesiyken iki yeni fikir (ToChar + `&&`) taşıdığı için
  ck0200/ck0210 olarak ikiye bölündü. Hepsi kendi ortamında (`dotnet run`, geçici klasör)
  gerçek girdilerle test edildi, sonuçlar doğrulandı. Kara kutu rotasyonunda `using` ve
  `namespace` bu ders grubunda 3. turlarını tamamlayıp emekliye ayrıldı (mufredat.md'de
  işlendi); ck0180/190/200/210 yük freniyle Merak Köşesi'ni atladı. **İstisna:** Özgür
  bu 6 dersin kod.cs'inde sabit "Not:" çerçeve notu satırını elle kaldırdı, ck0160/ck0170
  Merak Köşesi kapanışını "ünite 07" yerine belirsiz "İleride"ye çevirdi — sadece bu 6
  ders için geçerli, kural değişmedi; ck0010-0150 ve sonraki yeni dersler eski formatta
  (Not: satırı + ünite 07) devam eder. mufredat.md'deki "açılacağı yer: ünite 07" kaydı
  (Karar 16) hâlâ geçerli, sadece bu 6 dersin öğrenciye giden metni daha belirsiz.
- **`arsiv/03cSharpÇekirdekKodlar_bitti.txt` zaten işlenmiş arşiv kopyası** — eski
  "03cSharpÇekirdekKodlar - Kopya.txt" ile aynı içerik, "_bitti" adıyla tekrar geldi,
  yeni bir işlem gerektirmiyor.

- **ck0460-ck0499 onay bekliyor (9 ders, pedagojik sıraya göre üretildi).**
  `arsiv/11cSharpÇekirdekKodlar.txt` içindeki dokuz örnek, arşivdeki ham madde sırası (1→9)
  yerine dil zincirine göre yeniden sıralandı: ck0460 tekSatirYildiz (madde 8, Write/WriteLine
  farkı) → ck0465 sabitDikdortgen (madde 1, iç içe for — yeni ana halka) → ck0470
  bosSatirDeseni (madde 3, dış döngü kararı) → ck0475 dikdortgenBosluk (madde 2, iç döngü
  kararı) → ck0480 dortgendeDelik (madde 4, `&&` birleşik koşul + sayaç manipülasyonu) →
  ck0485 metindeYildizBiriktirme (madde 5, string biriktirme) → ck0490 artanUcgenFor (madde 6,
  bağımlı sayaç sınırı — yeni halka) → ck0495 artanUcgenString (madde 7, aynı sonucun tek
  döngülü versiyonu, ck0490 ile karşılaştırma) → ck0499 azalanUcgen (madde 9, azalan sayaç
  pekiştirmesi, ünite 04 kapanışı). Numara slotları (460/465/470/475/480/485/490/495/499)
  aynı kaldı, sadece hangi arşiv maddesinin hangi numaraya gittiği değişti — önceki oturumda
  README.md/mufredat.md'ye ham sırayla (madde 1→9) taslak satır girilmiş ama `kod.cs`
  dosyaları hiç yazılmamıştı; bu oturumda hem yeniden sıralandı hem gerçekten üretildi.
  Kaynak madde 4'teki sayaç artırma yan etkisi (i++ + sonraki Write) koşullu yazımla aynen
  korundu. Dokuz kodun tamamı geçici bir Console projesinde (`dotnet run`, hepsi sabit
  literal döngü sınırları kullandığı için girdi gerekmedi) gerçekten çalıştırıldı, çıktılar
  (dikdörtgen/üçgen/delik desenleri) doğrulandı — `ReadKey` headless kısıtı yüzünden her
  çalıştırmanın sonunda beklenen `InvalidOperationException` görüldü, kod hatası değil.
  Her ders `kod.cs` + `degerlendirme.md` (2 soru) ve `cozumler/` altında SEN YAP çözüm
  yorumuyla üretildi. 10. kaynağın neden boş geldiğine dair bilgi yok. mufredat.md ve
  README.md güncellendi; commit yok, onay bekliyor.
