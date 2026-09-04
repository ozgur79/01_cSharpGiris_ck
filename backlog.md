# Backlog

Canlı durum. Biten madde silinir, `backlog-log.md`'ye taşınır.

- **Kara kutu satırı formatı çözülmedi, yeniden düşünülecek.** Aynı oturumda 3 farklı
  format denendi (ck0020-ck0080'e uygulanıp commit edildi), üçünde de Özgür "anlaşılır
  değil / kapalı" dedi — bkz. CLAUDE.md/AGENTS.md "Console kod.cs şablonu" ve memory
  `feedback_kara_kutu_kisa.md`. Küçük ayarla çözülmüyor, format baştan düşünülmeli
  (belki örnekle/soru-cevap şeklinde, belki hiç tek satıra sıkıştırmadan). Sıradaki
  oturumda mevcut derslere (ck0020-ck0080) dokunmadan önce Özgür'le birlikte netleştir.
- **ck0060/ck0070 onaylandı**, commit edildi.
- **ck0080_stringToplamaTuzagi onay bekliyor.** `arsiv/02cSharpÇekirdekKodlar.txt` madde
  8'in "kısım b"sinden üretildi (string + string birleştirme yapar, toplama değil). Madde
  8'in geri kalanı atlandı: isim selamlama kısmı ck0020 ile örtüşüyor, `Convert.ToInt16`
  kullanan iki alt kısım da ck0030'daki `ToInt32` çözümüyle aynı fikri tekrarlıyor (proje
  kuralı zaten `ToInt16`'yı `ToInt32`'ye düzeltiyor). Gösterilip onaylanınca commit edilecek.
- **`arsiv/02cSharpÇekirdekKodlar.txt`'den 2 madde daha işlenecek** (madde 9, 10),
  ck0080 onaylandıktan sonra sırayla:
  - madde 9: `Console.Read()` — tek karakter okuma, ASCII kod döndürmesi. Yeni konu.
  - madde 10: temel veri tipleri toplu tanıtımı (byte, int, double, bool, char, string).
    Yeni konu, muhtemelen kapsamlı bir ders.
  Sıradaki ders numaraları içeriğin dil-zinciri konumuna göre belirlenecek, arşivdeki madde
  sırasına bağlı değil (bkz. CLAUDE.md "İsimlendirme").
