# Değerlendirme — ck0180

1. `else if (puan < 50)` satırına gelindiğinde puan'ın 25'ten küçük OLMADIĞI nereden
   biliniyor, kodda bunu kontrol eden ayrı bir satır var mı?
   (Özgür için: ayrı bir satır yok — bir üstteki `else if (puan < 25)` yanlış çıktığı için
   zaten oraya gelinmiştir; else if zinciri bu eleme işini otomatik yapar.)

2. puan=25 girilirse hangi not yazılır, neden "Not : 0" değil?
   (Özgür için: "Not : 1" — 25 < 25 yanlış olduğu için o dal atlanır, 25 < 50 doğru olduğu
   için "Not : 1" çalışır; alt sınır her aralıkta bir üst nota dahildir.)

3. Bu kodda `Convert.ToInt16` yerine `Convert.ToInt32` neden kullanıldı?
   (Özgür için: projede sayı okurken tutarlılık için hep ToInt32 kullanıyoruz — ToInt16
   daha dar bir sayı aralığı tutar, gereksiz sınırlama.)
