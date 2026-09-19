# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **arsiv/12 TAMAMLANDI ve commit edildi** (59 ders, ck0500-ck0790, 6 blok).
- **arsiv/13 işleniyor (26 ders, ck0795-ck0920, 6 blok planlandı).**
  Atlanan: [03] (zaten ck0535'te var), [09] (ck0690'ın basit hâli), [21] ([17] ile
  aynı sorun, daha karmaşık). **Blok 1/6 (ck0795-ck0810) onaylandı, commit edildi.**
  **Blok 2/6 (ck0815-ck0830, 4 ders) üretildi, onay bekliyor:** ck0815 `for(;;)`+
  `break` ile çift toplama (ck0560'ın for-tabanlı versiyonu), ck0820 do-while ile
  tek toplama (0'da çıkış — küçük bir tutarsızlık [uyarı+çıkış aynı anda] SEN YAP'ta
  işlendi, çözümü cozumler'de), ck0825 puan/not çok dallı karar + retry, ck0830
  **foreach'e giriş** (yeni ANA halka) — dizide arama ile farklı sayı zorlama;
  **ilginç bulgu:** dizinin varsayılan değeri 0 olduğu için üretilen 0 hiç dizide
  yer alamıyor (5 kez test edildi, hiç 0 çıkmadı) — ck0615'teki -1 sentinel dersine
  bağlanan bir gözlem, düzeltilmedi, SEN YAP'a soru olarak işlendi. Hepsi `dotnet
  run` ile gerçekten çalıştırılıp doğrulandı. mufredat.md/README.md güncellendi.
  **Commit yok, onay bekleniyor.**
- **Geriye dönük küçük düzeltme gerekiyor (henüz yapılmadı):** ck0790'dan sonra [11]
  (Array.Sort) işlenirken ck0730'un "sıralamanın hazırı yok" notu düzeltilecek —
  Array.Sort zaten vardı, henüz tanıtılmamıştı sadece; ders/kod değişmiyor, sadece
  yanıltıcı cümle düzelecek.
- **Sıradaki blok: Blok 3 (ck0835-0850) — foreach pekiştirme + Array.Sort + dizi
  ortalaması (4 ders).**
- **Ayrıca not: arsiv/14 geldi (WinForms, 45 madde, 02_cSharpForm_ck için) — bu
  projenin kapsamı değil.** Ortak bildirdi, Özgür'ün "üretim beklemede" onayı
  kalktı (02'nin CLAUDE.md'sindeki not artık geçersiz). 01 (arsiv/13) bitince ya
  da ayrı bir oturumda 02'ye geçilip bakılacak.
