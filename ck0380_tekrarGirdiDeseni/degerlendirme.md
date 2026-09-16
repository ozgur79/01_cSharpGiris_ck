# Değerlendirme — ck0380

1. Soru sorma satırı kodda neden iki kez var (biri döngüden önce, biri içinde)?
   (Özgür için: döngü koşulu boş `for(;;)` olduğu için döngüye "ilk giriş" için bir
   değer gerekiyor — o da döngüden önceki soru. İçerideki soru ise her turun sonunda bir
   sonraki tur için yeni değer alıyor.)

2. sayi=0 ile başlanırsa (ilk soruya 0 yazılırsa) "Pozitif" ya da "Negatif" hiç yazdırılır
   mı?
   (Özgür için: hayır — döngüye girer girmez else dalına düşer, break çalışır, döngü hiç
   turlamadan biter.)
