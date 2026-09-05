# Değerlendirme — ck0120

1. 7, 8, 10 sayılarını girersen program kaç yazar, gerçek ortalama kaçtır?
   (Özgür için: program 8 yazar (25/3 int bölmesiyle 8), gerçek ortalama 8.33'tür —
   küsurat int bölmesinde atılır.)

2. `(s1 + s2 + s3) / 3` yerine parantezsiz `s1 + s2 + s3 / 3` yazılsaydı ne olurdu?
   (Özgür için: önce `s3 / 3` hesaplanır, sonra `s1` ve `s2` eklenir — istenen ortalama
   değil, tamamen farklı bir sayı çıkar.)

3. Aynı soruyu iki değişken kullanarak yapabilir miyiz? Nasıl?
   (Özgür için: evet — üç sayıyı ayrı ayrı tutmak yerine bir `toplam` değişkeninde
   biriktirip (her okumada üstüne ekleyerek), ikinci değişken olarak `ortalama`yı
   kullanabiliriz. s1/s2/s3 yerine tek bir toplam değişkeni yeterli olur.)

4. Aynı soruyu bir değişken kullanarak yapabilir miyiz? Nasıl?
   (Özgür için: evet — tek bir değişkende önce toplamı biriktirip sonunda üstüne bölme
   sonucunu (ortalamayı) yazabiliriz; ama artık değişkenin adı "ortalama" değil, önce
   toplamı sonra ortalamayı tutan genel bir isim (örn. `sayi`) olmalı — okunabilirlik
   düşer, bu yüzden pratikte tercih edilmez.)