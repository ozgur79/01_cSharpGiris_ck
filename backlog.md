# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **arsiv/12 işleniyor — 59 derslik tam tasarım çıkarıldı, blok blok üretiliyor.**
  Tam sıra ve numara ataması `mufredat.md`'de. Atlanan: madde [06] (ck0410 ile
  duplicate). İşlenmeyen: `İNCELE: 303karekökMetodunuÖğrencilerYazsın` (kaynak yok).
  **Blok 1-3 (ck0500-ck0600) onaylandı, commit edildi.**
  **Blok 4/10 (ck0605-ck0655, Random pekiştirme + zamanlama + renk, 11 ders) üretildi,
  onay bekliyor:** ck0605 for(;;)+break ile sınırsız tahmin, ck0610 döngüde N adet
  random, ck0615 ardışık aynı sayı engelleme (kaynaktaki `gecici` bugı düzeltildi,
  dizisiz basit bir mantıkla), ck0620 Random aralığı klavyeden (kapanış), ck0625
  Thread.Sleep'e giriş, ck0630 hızlanan sayaç, ck0635 ileri-geri sonsuz sayma, ck0640
  sade sonsuz sayaç, ck0645 baklava+zamanlama (desen ailesine geri bağlanıyor), ck0650
  ConsoleColor'a giriş (**önemli not:** `(Tip)değer` cast yazımı ilk kez burada AÇIK
  öğretildi — ck0060'ta sadece ipucu verilmişti; bu, ck0790'ı "ilk tanıtım" olmaktan
  çıkarıp pekiştirmeye çeviren bir sıralama kararı, mufredat.md'ye not düşüldü), ck0655
  ConsoleColor+if kapanışı. **Önemli teknik not:** Thread.Sleep VS2013'ün varsayılan
  using listesinde yok — bu 5 dersin NASIL: satırına "using System.Threading; ekle"
  talimatı eklendi (doğrulandı: ImplicitUsings kapalı projede Thread.Sleep gerçekten
  derlenmiyor, dotnet run testlerimin normalde ImplicitUsings=enable kullandığını fark
  edip bu dersten itibaren testleri ImplicitUsings=disable ile yapmaya geçtim — VS2013
  koşullarına daha yakın). Hepsi `dotnet run`/`dotnet build` ile doğrulandı (sonsuz
  döngülü olanlarda sadece derleme + mantık simülasyonu, çalıştırma değil — kendileri
  hiç durmuyor). mufredat.md/README.md güncellendi. **Commit yok, onay bekleniyor.**
- **Sıradaki blok: Blok 5 (ck0660-0750) — dizi ailesi, en büyük blok (19 ders).**
