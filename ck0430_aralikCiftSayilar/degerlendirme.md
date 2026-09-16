# Değerlendirme — ck0430

1. s1=5, s2=3 girilince program ne yapıyor, sonra ne oluyor?
   (Özgür için: "İlk sayı küçük olmalıdır! Tekrar giriniz" yazdırıyor, dış `for(;;)`
   döngüsü break görmediği için başa dönüp tekrar soruyor.)

2. s2=10 girildiği hâlde 10 neden listede yok?
   (Özgür için: içteki döngü `i < s2` koşuluyla çalışıyor, `<=` değil — s2'nin kendisi
   aralığa dahil edilmiyor.)
