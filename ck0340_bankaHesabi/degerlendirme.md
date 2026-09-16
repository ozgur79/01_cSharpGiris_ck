# Değerlendirme — ck0340

1. `bakiye` değişkeni neden `for` döngüsünün dışında, en üstte tanımlanmış — döngünün
   içinde olsaydı ne fark ederdi?
   (Özgür için: döngünün içinde tanımlansaydı her turda yeniden `= 1000` ile başlardı,
   önceki işlemler unutulurdu. Dışarıda tanımlandığı için değerini turlar arasında korur.)

2. Bu program neden hiç kendiliğinden bitmiyor?
   (Özgür için: `for(;;)` içinde break yok — böyle tasarlanmış, gerçek bir banka
   uygulaması da kullanıcı kapatana kadar açık kalır; kapatmak için VS'in Durdur
   butonu kullanılır.)
