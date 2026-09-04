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
