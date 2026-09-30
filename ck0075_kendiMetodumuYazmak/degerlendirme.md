# Değerlendirme — ck0075 Kendi Metodumu Yazmak

1. `tanit()` ile `Topla()` arasındaki fark nedir? Biri ekrana yazarken diğeri ne yapıyor?
   > Cevap notu: `tanit` (void) sadece iş yapar, geriye değer vermez; `Topla` (int) işin
   > sonucunu `return` ile geri gönderir ve bu sonuç `a = Topla();` ile bir değişkene
   > alınabilir. "void = geri vermez, int = sayı geri verir" yeterli.

2. Bir metodu yazmakla çağırmak aynı şey mi? Main() içinde `tanit();` satırını silersen
   ne olur?
   > Cevap notu: Hayır — yazmak tarif etmektir, çağırmak çalıştırmaktır. Satır silinirse
   > metot tanımlı kalır ama hiç çalışmaz, "ben tanit metoduyum" çıktısı görünmez.
