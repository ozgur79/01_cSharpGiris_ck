# Değerlendirme — ck0250

1. ck0240 iki if kullanıyordu, ck0250 tek if kullanıyor. İkisi de aynı üç senaryoda aynı
   sonucu veriyor mu? Neden?
   (Özgür için: evet, aynı sonucu verir — && "ikisi de doğru olmalı" derken, iç içe if de
   "dıştaki doğruysa içtekine bak" diyordu; iki koşulu aynı anda istemenin iki farklı
   yazım şekli.)

2. `&&`'nin solundaki parantez `(kadi == "ogrenci" || ...)` kaldırılsa ne olurdu?
   (Özgür için: ck0210'da gördüğümüz gibi C#'ta && ||'den önce işlenir — parantez
   olmadan satır farklı gruplanır, kadi="mehmet" olsa bile sifre doğruysa bazı durumlarda
   yanlışlıkla giriş kabul edilebilirdi. Parantez niyeti netleştiriyor.)
