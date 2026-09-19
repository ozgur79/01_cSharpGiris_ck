# Değerlendirme — ck0680

1. k=-1 satırı neden var, k-- yerine neden bu kullanılıyor?
   (Özgür için: inner for döngüsünün kendi k++ artışı k=-1'i hemen k=0'a getirir —
   böylece yeni girilen değer BAŞTAN itibaren (k=0'dan) tüm önceki elemanlarla
   yeniden karşılaştırılır. ck0675'teki k-- bunu garanti etmiyordu.)

2. Aynı test sırasıyla (10,20,20,30,40) bu ders toplam kaç giriş istiyor?
   (Özgür için: 6 — 5 normal eleman + 1 tekrar (20 çakışması için). ck0675'te aynı
   senaryo gereksiz fazladan bir "3. elemanını girin" daha isteyip 7 giriş alıyordu.)
