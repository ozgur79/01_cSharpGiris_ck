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
