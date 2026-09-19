# Değerlendirme — ck0735

1. index değişkeni neden bir kez üretilip iki dizide de kullanılıyor, her dizi için
   ayrı ayrı üretilmiyor?
   (Özgür için: amaç "eşleşen" bir çift almak (aynı sıradaki erkek/bayan ismi) —
   iki ayrı index üretilseydi eşleşme rastgele bozulurdu, alakasız iki isim çıkardı.)

2. rastgele.Next(0, erkek.Length) yerine rastgele.Next(0, bayan.Length) yazılsaydı
   sorun olur muydu?
   (Özgür için: iki dizi de aynı uzunlukta (7) olduğu için burada fark etmez, ama
   diziler farklı uzunlukta olsaydı yanlış dizinin boyutunu kullanmak
   IndexOutOfRangeException riski doğururdu.)
