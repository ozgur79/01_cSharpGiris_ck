# Değerlendirme — ck0855

1. tek ve cift dizileri neden 10 elemanlık açılıyor, sonuçta her biri muhtemelen
   10'dan az dolacak?
   (Özgür için: en kötü ihtimalde TÜM 10 sayı tek (ya da tümü çift) çıkabilir —
   dizi en kötü durumu karşılayacak kadar büyük açılmalı, sonra gerçek dolu kısım
   c/t sayaçlarıyla takip edilir.)

2. Çiftler/tekler yazdırılırken foreach değil, c/t sınırlı for neden kullanıldı?
   (Özgür için: foreach TÜM 10 slotu gezerdi, doldurulmamış slotlar da (varsayılan
   0) yazdırılırdı — bu da gerçek bir 0 mı yoksa boş slot mu belirsizliği yaratırdı,
   tıpkı ck0830/ck0835'teki gibi. c/t ile sınırlamak bu karışıklığı önler.)
