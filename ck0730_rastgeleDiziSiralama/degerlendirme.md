# Değerlendirme — ck0730

1. gecici değişkeni olmadan direkt dizi1[i] = dizi1[j]; dizi1[j] = dizi1[i]; yazsak
   ne olurdu?
   (Özgür için: ilk satır dizi1[i]'nin eski değerini kaybettirir; ikinci satırda
   dizi1[j]'ye atanan değer artık dizi1[j]'nin KENDİSİ olur (yanlış) — iki değeri
   gerçekten takas etmek için üçüncü bir "geçici kutu" (gecici) şart.)

2. İç içe iki döngü (i ve j) neden dizinin TAMAMINI (0'dan Length'e) geziyor, sadece
   i'den sonrasını değil?
   (Özgür için: bu basit ama israflı bir yöntem — her çift birden fazla kez
   karşılaştırılıyor (gereksiz tekrar var) ama sonuç yine de doğru çıkıyor; daha
   verimli sıralama yöntemleri var ama bu ders "önce çalışsın" mantığıyla en basit
   hâli gösteriyor.)
