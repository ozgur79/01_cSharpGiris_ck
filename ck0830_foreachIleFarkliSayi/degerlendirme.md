# Değerlendirme — ck0830

1. foreach (int gecici in sayilar) satırı ne yapar, for'dan farkı ne?
   (Özgür için: sayilar dizisindeki HER elemanı sırayla gecici değişkenine koyup
   döngü gövdesini çalıştırır — indis (i, sayilar[i]) yazmana gerek kalmaz, C#
   diziyi senin için gezer.)

2. Programı birkaç kez çalıştırınca 0 hiç çıkmıyor, neden?
   (Özgür için: int[] sayilar = new int[3] ile oluşturulan dizinin varsayılan
   değeri 0'dır (henüz hiçbir şey yerleştirilmemiş 3 kutu da 0 gösterir). foreach
   0 üretilen bir tutulansayi'yi bu boş kutulardan biriyle "aynı" sanıp reddeder —
   ck0615'teki -1 sentinel dersiyle birebir aynı tuzak.)
