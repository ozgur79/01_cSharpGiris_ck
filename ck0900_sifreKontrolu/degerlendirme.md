# Değerlendirme — ck0900

1. Kaynak kodda tus.Key (ConsoleKey) doğrudan char'a çevriliyordu, burada
   tus.KeyChar kullanıldı — fark ne?
   (Özgür için: ConsoleKey rakam ve büyük harf tuşları için ASCII koduyla
   örtüşür ama küçük harf/sembollerde YANLIŞ sonuç verir; KeyChar her zaman
   GERÇEKTEN yazılan karakteri verir — daha güvenilir.)

2. 10 karakterden fazla tuşa basarsan ne olur?
   (Özgür için: program çöker — tuslar dizisi 10 elemanlık (new char[10]),
   11. karakterde tuslar[10] IndexOutOfRangeException fırlatır.)
