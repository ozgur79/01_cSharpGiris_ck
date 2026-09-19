# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **arsiv/12 işleniyor — 59 derslik tam tasarım çıkarıldı, blok blok üretiliyor.**
  Tam sıra ve numara ataması `mufredat.md`'de. Atlanan: madde [06] (ck0410 ile
  duplicate). İşlenmeyen: `İNCELE: 303karekökMetodunuÖğrencilerYazsın` (kaynak yok).
  **Blok 1-4 (ck0500-ck0655) onaylandı, commit edildi.**
  **Blok 5/10 (ck0660-ck0750, dizi ailesi, en büyük blok — 19 ders) üretildi, onay
  bekliyor:** ck0660 diziye giriş → ck0665 literal başlatma → ck0670 for ile gir/oku →
  **ck0675/ck0680 kasıtlı karşılaştırma çifti** (ck0675 kaynaktaki `i--`/`k--` retry
  hatası BİLEREK korundu, gerçekten test edilip "beklenenden fazla soruyor" davranışı
  doğrulandı; ck0680 `tekrar` bayrağıyla düzeltilmiş hâli) → ck0685/0690/0695 dizi+Random
  ailesi → ck0700 dinamik boyut → ck0705 arama (kaynak bug düzeltildi: `else` her
  adımda yanlış "bulunamadı" basıyordu) → ck0710/0715/0720/0725 hazır dizi metotları
  (Array.Clear/Resize/Reverse + mutasyon) → ck0730 kendi sıralama mantığı (bubble-sort
  benzeri, swap+gecici) → ck0735 iki diziden eşleşen veri (kaynak bug düzeltildi:
  `Next(1,6)` ilk/son elemanı hiç seçmiyordu) → ck0740/0745 string/dizi köprüsü →
  ck0750 dizi+fonksiyon köprüsü (**yapısal istisna:** bu ders "hepsini Main() içine
  yapıştır" kalıbına uymuyor — iki alan + iki metot class Program içine, Main()'in
  dışına eklenmesi gerekiyor, kod.cs içinde "1. BÖLÜM"/"2. BÖLÜM" olarak ayrıca
  işaretlendi, hem top-level statement hem klasik `namespace/class Program/static Main`
  yapısıyla test edildi). Hepsi `dotnet run` ile gerçekten çalıştırılıp doğrulandı.
  mufredat.md/README.md güncellendi. **Commit yok, onay bekleniyor.**
- **Sıradaki blok: Blok 6 (ck0755-0790) — fonksiyon ailesi + cast pekiştirme kapanışı
  (8 ders), arsiv/12'nin son bloğu.**
- **Sırada arsiv/13 var (29 madde, kaynak 0001lunaveriTemizleTest, arsiv/12'den ayrı
  klasör) — Ortak (zihinEv) bildirdi, TALIMAT-13-icin-ck.md'de olası örtüşme şüpheleri
  var. Henüz açılmadı, arsiv/12 (Blok 6) bitince bakılacak.**
