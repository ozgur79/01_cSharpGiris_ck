# Backlog Log

Append-only. Hiçbir şey silinmez, sadece eklenir.

## 2026-09-04

- Faz 0 (kurulum) tamamlandı: CLAUDE.md, AGENTS.md, backlog.md, backlog-log.md, notes.md,
  cozumler/, Test-Gunlugu.md, README.md, .gitignore oluşturuldu; git init + GitHub public
  repo + ilk commit/push yapıldı.
- Faz 1+2 (ders üretim döngüsü) başladı. `dotnet` SDK 10.0.400 winget ile kuruldu.
  `arsiv/01cSharpÇekirdekKodlar.txt`'nin 5 parçası işlenip onaylandı: ck0010_merhabaDunya
  (Write/WriteLine), ck0020_adinizNedir (string girdi), ck0030_ikiSayiToplam (int toplama,
  `ToInt16`→`ToInt32` düzeltildi), ck0040_sayininIkiKati (çarpma, aynı düzeltme),
  ck0050_sayininKaresi (kare alma, pekiştirme dersi). Bu dosyada başka parça kalmadı.
- Kara kutu bloğu tekrarı kısaltıldı: ck0010'da tam açıklama, sonrasında kısa referans.
  Sonra Özgür'ün talebiyle "kademeli ön izleme" eklendi — her ders henüz açılmamış bir
  kara kutuya (rotasyon: using→namespace→class Program→static Main) dair tek cümlelik
  ipucu taşıyor; yeni dil kavramı içermeyen (pekiştirme) dersler ipucuyu derinleştiriyor.
  Rotasyon durumu `mufredat.md` kara kutu tablosunun "ön izleme günlüğü" sütununda.
- İsimlendirme kuralı netleştirildi: ck numarası içeriğin ünite/dil-zinciri konumuna göre
  atanır, script'in verildiği sıraya göre değil (iki ders arasına düşen konu → aradaki
  boş sayı, ör. ck0035; kronolojik geç ama içerik erken → yine erken ünite aralığı).
  mufredat.md/README.md ders tabloları ck numarasına göre sıralı tutulacak.

## 2026-09-05

- Kara kutu formatı Özgür ile (Ortak üzerinden) netleşti — 4. turda çözüldü. Yeni format:
  başta sabit 2 satırlık çerçeve notu (VS iskeleti, "şimdilik bırak" der), asıl açıklama
  dosya sonunda tek kutuluk `MERAK KÖŞESİ` (3-6 satır, soru/cevap/açılış-yeri üçlüsü).
  `ckXXXX` sahte numarası yasaklandı, açılış yeri ünite adıyla yazılıyor. CLAUDE.md/
  AGENTS.md güncellendi (bkz. "Console kod.cs şablonu"). Memory `feedback_kara_kutu_kisa.md`
  kapatıldı.
- Geriye dönük iş yapıldı (Özgür onayıyla, "ortağın dediklerini yap"): ck0010-ck0080'in
  sekizi de yeni formata geçirildi — `NASIL:` satırından "VS2013'te" kalktı, eski
  "Ön izleme" satırları Merak Köşesi'ne dönüştü. Rotasyona `Console.ReadKey` da eklendi
  (using→namespace→class Program→static Main→Console.ReadKey→başa dön); bu yüzden
  ck0060/ck0080'in içeriği eski ön izleme metninden farklı, rotasyonun yeni 5-kutuluk
  hâline göre yeniden dağıtıldı: ck0020=using, ck0030=namespace, ck0040=class Program,
  ck0050=static Main, ck0060=Console.ReadKey, ck0070=atlandı (ders yüklü — metot/sınıf),
  ck0080=using (2. tur). ck0010 rotasyona girmiyor, sadece çerçeve notu taşıyor.
  mufredat.md kara kutu tablosu güncellendi (sütun adı "Merak Köşesi günlüğü", hücreler
  ünite adına çevrildi).
- Özgür ck0010-ck0080'i inceledi, bazı kod.cs dosyalarında elle düzeltme yaptı (çerçeve
  notundaki "ünite 03'te" ifadesi bazı derslerde "ileride"ye çevrildi, bazı derslerde
  `Not:` çerçeve notu tamamen kaldırıldı — ck ayarlamayı yeniden yapmadı, olduğu gibi
  bırakıldı). ck0080_stringToplamaTuzagi onaylandı, mufredat.md/README.md durumu
  "onaylandı"/"yayında" yapıldı, commit+push edildi.
- ck0090_tekKarakterOkuma (Console.Read, ASCII kod) taslak olarak üretildi, `dotnet run`
  ile doğrulandı (bkz. bu tarihli backlog girişi öncesi).
- Ortak üzerinden Özgür'ün 4 WinForms kararı geldi (Karar 14-18): ünite haritası
  (00-04 Console, 05 form/nesne, 06 hesap/karar, 07 OOP girişi — kara kutular burada
  kapanır, 08 zaman/olay, 09 liste/görsel/çok form), ünite başına tek proje, kara kutu
  açılışı ünite 03'ten ünite 07'ye taşındı, rotasyon freni (bir kutu 3 tur Merak
  Köşesi'ne konu olunca emekli olur). CLAUDE.md/AGENTS.md + yeni `winforms-plan.md`
  Ortak tarafından yazılmıştı; ck bu oturumda mevcut ck0010-ck0090'daki "ünite 03"
  metinlerini "ünite 07"ye çevirdi (Console.ReadKey kutusunun açılış yeri de "ileride
  ayrı bir derste"den "ünite 07"ye taşındı — winforms-plan.md'nin 5 iskelet kutusunu
  birlikte andığı cümleyle tutarlı olsun diye), mufredat.md kara kutu tablosuna
  "tur / emekli" sütunu eklendi, mufredat.md başına winforms-plan.md'ye işaret eden
  bir not eklendi. Commit atılmadı, onay bekleniyor.

## 2026-09-05 (devam) — repo bölünmesi, arşiv tükendi

- Ortak üzerinden: WinForms ders şablonu onaylandı (`ornek/ck0530_butonuBuyutSakla/`
  numunesi), sonra proje ikiye bölündü. `D:\Atolye\cSharp\CLAUDE.md`/`AGENTS.md` (üst
  klasör, YENİ) ortak kimliği ve kara kutu doktrinini taşıyor; bu repo (`01_cSharpGiris_ck`)
  artık sadece Console (ck0000-0499, ünite 00-04); `02_cSharpForm_ck` (YENİ kardeş klasör)
  WinForms+OOP (ck0500-0999, ünite 05-09). `winforms-plan.md` ve `ornek/` 02'ye taşındı,
  `Test-Gunlugu.md` de (01'de WinForms dersi yok). Numaralandırma sıfırlanmadı — 02 ck0500'den
  başlıyor, "ünite 07'de açacağız" sözü hâlâ geçerli.
- ck0100_veriTipleriTanisma üretildi (madde 10, arşivin son maddesi): byte/bool/char
  tanıtımı, int/double/string recap. Arşivdeki örnekte geçen gerçek isim ("Özgür") repo
  public olduğu için "Ahmet" ile değiştirildi. Merak Köşesi bu derste atlandı (üç yeni tip
  aynı anda — ders yüklü, günlüğe işlendi). `dotnet run` ile çıktı doğrulandı.
  `arsiv/01cSharpÇekirdekKodlar.txt` ve `arsiv/02cSharpÇekirdekKodlar.txt` bu maddeyle
  tamamen tükendi.
- Özgür ck0090 ve ck0100'ü onayladı. mufredat.md/README.md durumu "onaylandı"/"yayında"
  yapıldı, commit+push edildi.

## 2026-09-06 — ck0160-ck0210 onaylandı

- `arsiv/04cSharpÇekirdekKodlar.txt` (madde 16-20) altı derse bölündü: ck0160 (if/else
  sayısal `<`, pekiştirme), ck0170 (if/else sayısal `==`, ck0110 dörtgen temasına bağlı),
  ck0180 (else if sıralı aralık kontrolü — yeni halka), ck0190 (`||` — yeni halka), ck0200
  (Convert.ToChar ile char okuma — yeni halka), ck0210 (`&&`, `||`+`&&` bir arada, parantez
  önceliği — yeni halka). Madde 20 iki yeni fikir taşıdığı için ck0200/ck0210 olarak ikiye
  bölündü. Hepsi `dotnet run` ile gerçek girdilerle test edildi. `using`/`namespace` bu
  grupta 3. turlarını tamamlayıp emekliye ayrıldı. Özgür onayladı, `338c787` ile
  commit+push edildi. (mufredat.md/README.md durum sütunları o an güncellenmemiş kalmıştı,
  2026-09-19'da arsiv/12 işlenirken fark edilip senkronize edildi.)

## 2026-09-16 — ck0220-ck0450 onaylandı (24 ders)

- `D:\zihinEv\...\10is-emri-ck-faz-talimati.md` (Ortak'ın faz talimatı) baştan sona
  uygulandı — Özgür "sırayla devam et, durma" dedi, ara onay durakları atlanıp tek
  oturumda üretildi: Blok05 (ck0220-0250, `!`/iç içe if/`&&` indirgeme), Blok06
  (ck0260-0290, `for` girişi/`%`/doğrulama sarmalayıcısı/sembol seçim — ünite 02
  tamamlandı), Blok07 (ck0300-0340, KDV/maaş kesinti/banka hesabı), Blok08 (ck0350-0400,
  toplam biriktirme/`TryParse`/faktöriyel — ünite 03 tamamlandı), Blok09 (ck0410-0450,
  dinamik aralık/retry-on-invalid/`"q"` ile çıkış). Kara kutu rotasyonu bu grupta bitti:
  beş iskelet kutusu da emekli oldu. Spec dışı bir karar da uygulandı: arşivdeki gerçek
  isim/parola ("Özgür"/"öz123") repo public olduğu için kurgusal `ogrenci`/`kalfa123` ile
  değiştirildi. Her ders `dotnet run` ile gerçekten çalıştırılıp doğrulandı. Özgür onayladı,
  `fd8c731` ile commit+push edildi. (mufredat.md durum sütunu o an güncellenmemiş kalmıştı,
  2026-09-19'da senkronize edildi.)

## 2026-09-19 — arsiv/11 (taslak notu, sonradan gerçek durumla değiştirildi)

- İlk taslak: `11cSharpÇekirdekKodlar.txt`'nin dokuz maddesi ck0460-ck0499 aralığına
  (5'lik ara numaralarla) dokuz ayrı ders olarak uyarlandı — iç içe for döngüleriyle
  dikdörtgen/üçgen/desen zinciri. ck0470 kaynak madde 4'teki `i++` sayaç yan etkisi
  daha açık koşullu yazımla değiştirildi. 10. kaynağın (arşivde ayrılan pay) boş
  gelme nedeni bilinmiyor. Dokuz kod da geçici Console projesinde (`dotnet run`)
  gerçekten çalıştırılıp çıktılar doğrulandı (9/9).
- **Gerçek kapanış:** Özgür bu 9 dersi onayladı, `8dadbf2` ile commit+push edildi
  ("ck0460-ck0499: unite 04 kapanisi, 9 ders, onaylandi"). mufredat.md/README.md
  durum sütunları o an güncellenmemiş kalmıştı — 2026-09-19'da (arsiv/12 işlenirken
  fark edildi) "onay bekliyor"/"taslak" → "onaylandı"/"yayında" olarak senkronize
  edildi, bu backlog-log girişi de o zaman düzeltildi.

## 2026-09-19 — arsiv/12 geldi, numara alanı genişletildi

- `12cSharpÇekirdekKodlar.txt` (61 madde, kaynak `0000lunaveriTemizleTest`) ve
  `TALIMAT-12-icin-ck.md` okundu. Talimattaki şüpheli çakışma (madde [01]-[04]/[58] —
  42ciftUcgen/43piramitUcgen-ss/44piramitUcgenZor/45ücgenBaklava/46baklavaThreading —
  ck0460-499'un kaynağı olabilir uyarısı) `arsiv/11cSharpÇekirdekKodlar.txt` ile
  karşılaştırılarak doğrulandı: **çakışma yok**, 11'in içeriği tamamen farklı (basit,
  isimsiz 9 madde). Bu 5 madde atlanmayacak.
- Numara kapasitesi sorunu tespit edildi: ck0000-ck0499 fiilen doluydu (ck0499 son
  slottu), 61 yeni maddenin çoğu (while/do-while/switch/dizi/fonksiyon — 01'in kendi dil
  zincirinde) sığmıyordu. Özgür'e soruldu; 01'i ck0000-ck0999'a genişletme, 02'yi
  ck1000'den başlatma kararı çıktı. `D:\Atolye\cSharp\CLAUDE.md`/`AGENTS.md` (proje ve
  ünite tabloları), bu projenin `CLAUDE.md`/`AGENTS.md` kapsam satırı ve
  `02_cSharpForm_ck`'nin tüm ck05xx-ck09xx referansları (+500 kaydırma, `ck0500_formuTani`
  → `ck1000_formuTani` git mv dahil) güncellendi.
- Aynı oturumda fark edilen ayrı bir tutarsızlık da giderildi: ck0160-ck0210 (`338c787`)
  ve ck0220-ck0450 (`fd8c731`) commit mesajlarında "onaylandı" yazsa da mufredat.md/
  README.md durum sütunları hâlâ "onay bekliyor"/"taslak" kalmıştı; `backlog.md`
  temizlenmemişti. Hepsi senkronize edildi (bkz. yukarıdaki iki kapanış girişi).
- arsiv/12'nin ders tasarımı (blok bölme, sıralama) henüz yapılmadı — `backlog.md`'de
  canlı madde olarak duruyor.

## 2026-09-19 — arsiv/12 TAMAMLANDI (59 ders, ck0500-ck0790, 6 blok)

- Tam tasarım tablosu önceden çıkarılıp gösterildi, Özgür blok blok onayladı.
  Blok 1 (ck0500-0525, desen ailesi devamı) → Blok 2 (ck0530-0580, Random girişi +
  while/do-while) → Blok 3 (ck0585-0600, switch-case + kapanış) → Blok 4 (ck0605-0655,
  Random pekiştirme + zamanlama + renk — `(Tip)değer` cast'i ilk kez ck0650'de açık
  öğretildi, ck0790'daki planlı "ilk tanıtım" rolü pekiştirmeye döndü) → Blok 5
  (ck0660-0750, dizi ailesi, en büyük blok — ck0675/ck0680 bilerek kusurlu/düzeltilmiş
  karşılaştırma çifti) → Blok 6 (ck0755-0790, fonksiyon ailesi + cast kapanışı — ck0770
  kaynak hatası "topla" adlı çarpma metodu `carp` olarak düzeltildi). Her ders `dotnet
  run`/`dotnet build` ile gerçekten doğrulandı, `Thread.Sleep` gerektiren derslerde
  (`using System.Threading;` gerekliliği fark edilip NASIL: satırına eklendi) ve sonsuz
  döngülü derslerde sadece derleme + mantık simülasyonu yapıldı. Tüm bloklar Özgür
  tarafından onaylandı, commit+push edildi (9c5abf3, 8965140, bd5fccc, aae6d90, 81c402c,
  e0fdeff).

## 2026-09-19 — arsiv/13 TAMAMLANDI (26 ders, ck0795-ck0920, 6 blok)

- `13cSharpÇekirdekKodlar.txt` (29 madde, kaynak `0001lunaveriTemizleTest`, arsiv/12'den
  ayrı klasör) ve `TALIMAT-13-icin-ck.md` okundu. Talimattaki şüpheler kontrol edildi:
  [03] negatifPozitifSifir atlandı (kod "q" çıkışını hiç implemente etmemiş, zaten
  ck0535'te düzgün işlenmiş); [06]/[07] işlendi (ck0560'ın for-tabanlı versiyonu ve
  do-while varyantı, yeni fikir taşıyorlardı). Ayrıca kontrol edilip atlanan: [09]
  (ck0690'ın dizisiz basit hâli), [21] ([17] ile aynı ters-sıra sorunu, daha karmaşık).
  [11]/[12] isim çakışması talimatta doğru işaretlenmişti, ikisi de işlendi.
- Özgür "arsiv/13 bitene kadar durma" dedi (Blok 2 üretilirken) — sonraki tüm bloklar
  onay durağı olmadan üretilip commit edildi.
- Blok 1 (ck0795-0810, giriş/döngü pekiştirme — ck0805 kasıtlı "10B'nin takıldığı" for
  noktalı virgül tuzağı, ck0810 arşivde kodsuz kalan görev tanımından ck tarafından
  üretildi) → Blok 2 (ck0815-0830, for/do-while pekiştirme + `foreach`'e giriş — ilk
  ANA halka) → Blok 3 (ck0835-0850, foreach pekiştirme + `Array.Sort` + dizi ortalaması
  — ck0730'un yanıltıcı "sıralamanın hazırı yok" notu ck0845'te düzeltildi) → Blok 4
  (ck0855-0870, dizi dağıtma + dizi döndüren fonksiyon + taban dönüşümü ailesi başlangıcı
  — ck0865 bilerek ters sırada, ck0870 `List<int>`'e giriş) → Blok 5 (ck0875-0890, List
  tersleme teknikleri + `ConsoleKeyInfo`'ya giriş — ikinci ANA halka) → Blok 6
  (ck0895-0920, şifre maskeleme/kontrolü + desen/renk/asal sayı kapanışı — ck0895'te
  kaynağın Enter-karakteri-de-şifreye-eklenme hatası düzeltildi, ck0900'de kaynağın
  `Convert.ToChar(tus.Key)` kullanımı güvenilir `tus.KeyChar`'a çevrildi).
- `ConsoleKeyInfo` tabanlı 4 ders (ck0885/0890/0895/0900) headless `dotnet run` ile test
  edilemedi (stdin yönlendirmesi ReadKey'i anında çökertiyor) — sadece `dotnet build`
  ile derleme doğrulandı, gerçek davranış Özgür'ün VS'te elle denemesini gerektiriyor.
  Tüm bloklar commit+push edildi (dbd8c44, fd595cc, 0bcef13, 69016ea, 536e0a6, + Blok 6).
- **01_cSharpGiris_ck için arşiv kuyruğu boşaldı** — yeni parça gelene kadar planlanmış
  ders yok. arsiv/14 (WinForms, 02_cSharpForm_ck için) geldi ama bu projenin kapsamı değil.
