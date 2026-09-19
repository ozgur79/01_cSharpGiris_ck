# Değerlendirme — ck0590

1. secim neden char, string değil?
   (Özgür için: kullanıcı tek bir karakter ('1','2','3','4') seçiyor, birden fazla
   karaktere gerek yok — char bu iş için yeterli ve doğru boyutta bir tip.)

2. 0'a bölme (case '4', sayi2=0) ne çıktı verir, program çöker mi?
   (Özgür için: çökmez — double'da bir sayının 0'a bölümü "∞" (sonsuz) olarak
   gösterilir; int'te olsaydı program çökerdi (DivideByZeroException), double'da çökmez.)
