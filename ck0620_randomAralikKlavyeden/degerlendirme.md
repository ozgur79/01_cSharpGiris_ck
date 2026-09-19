# Değerlendirme — ck0620

1. min ve max neden döngüden önce, sadece bir kez okunuyor?
   (Özgür için: aralık bir kez belirlenip aynı aralıkta kacAdet kez sayı üretiliyor;
   döngü içine konsaydı her turda tekrar sorulurdu, istenmeyen bir davranış olurdu.)

2. max, min'den küçük girilirse program ne yapar?
   (Özgür için: çöker — rastgele.Next(min, max) min>max olduğunda
   ArgumentOutOfRangeException fırlatır. min==max girilirse çökmez, hep min değerini
   döndürür.)
