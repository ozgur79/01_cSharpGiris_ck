# Değerlendirme — ck0600

1. do-while'ın şartı (`sayi > 9999 || sayi < 0`) neden if'in şartıyla birebir aynı?
   (Özgür için: if geçersizse uyarı basıyor; while de "geçersizse devam et" demek
   için aynı şartı kullanıyor — ck0430'daki retry-on-invalid deseniyle aynı mantık.)

2. sayi=250 girilirse switch(sayi/1000) hangi case'e girer?
   (Özgür için: hiçbirine — 250/1000 = 0 (int bölmesi), 0 için tanımlı bir case yok,
   switch hiçbir şey yapmadan devam eder; binler basamağı olmayan sayılarda bu
   normaldir.)
