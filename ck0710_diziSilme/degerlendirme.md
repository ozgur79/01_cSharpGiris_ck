# Değerlendirme — ck0710

1. Array.Clear(dizi, 2, 4) çağrısındaki 2 ve 4 ne anlama gelir?
   (Özgür için: 2 — hangi indisten başlanacağı, 4 — kaç eleman silineceği. Yani
   indis 2,3,4,5 sıfırlanır.)

2. "Silme" gerçekten diziyi küçültüyor mu?
   (Özgür için: hayır — dizinin boyutu (Length) hep 10 kalır, sadece belirtilen
   elemanların DEĞERİ 0'a döner. Gerçek boyut değişikliği için Array.Resize gerekir
   (ck0715'te işlenecek).)
