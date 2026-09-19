# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **arsiv/12 TAMAMLANDI ve commit edildi** (59 ders, ck0500-ck0790, 6 blok).
- **arsiv/13 işleniyor (26 ders, ck0795-ck0920, 6 blok planlandı).**
  Atlanan: [03] (zaten ck0535'te var), [09] (ck0690'ın basit hâli), [21] ([17] ile
  aynı sorun, daha karmaşık). **Blok 1/6 (ck0795-ck0810, 4 ders) üretildi, onay
  bekliyor:** ck0795 ondalıklı sayı girişi (virgül/nokta tuzağı), ck0800 do-while +
  `string.IsNullOrWhiteSpace`, ck0805 **kasıtlı hata** (`for(...);` sonrası fazladan
  noktalı virgül — "10B'nin takıldığı kod", gerçekten test edildi: çıktı 7,8,9,10
  yerine tek satır 11 çıkıyor), ck0810 başlangıç/adım/bitiş hepsi klavyeden (arşivde
  sadece görev tanımı vardı, kod hiç yazılmamıştı, ck tarafından uygulandı ve
  arşivdeki beklenen örnek çıktıyla — "7 11 15 19 23 27" — birebir eşleştiği
  doğrulandı). Hepsi `dotnet run` ile gerçekten çalıştırılıp doğrulandı. mufredat.md/
  README.md güncellendi. **Commit yok, onay bekleniyor.**
- **Geriye dönük küçük düzeltme gerekiyor (henüz yapılmadı):** ck0790'dan sonra [11]
  (Array.Sort) işlenirken ck0730'un "sıralamanın hazırı yok" notu düzeltilecek —
  Array.Sort zaten vardı, henüz tanıtılmamıştı sadece; ders/kod değişmiyor, sadece
  yanıltıcı cümle düzelecek.
- **Sıradaki blok: Blok 2 (ck0815-0830) — for(;;)/do-while pekiştirme + foreach'e
  giriş (4 ders).**
- **Ayrıca not: arsiv/14 geldi (WinForms, 45 madde, 02_cSharpForm_ck için) — bu
  projenin kapsamı değil.** Ortak bildirdi, Özgür'ün "üretim beklemede" onayı
  kalktı (02'nin CLAUDE.md'sindeki not artık geçersiz). 01 (arsiv/13) bitince ya
  da ayrı bir oturumda 02'ye geçilip bakılacak.
