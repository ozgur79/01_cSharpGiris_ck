# Değerlendirme — ck0615

1. while (tutulansayi == oncekiSayi) satırı ne işe yarıyor?
   (Özgür için: yeni üretilen sayı bir öncekiyle aynıysa, farklı bir sayı gelene
   kadar tekrar tekrar üretmeye devam eder — "aynıysa yeniden dene" mantığı.)

2. oncekiSayi neden -1 ile başlatılıyor, 0 ile değil?
   (Özgür için: rastgele.Next(0,10) 0'ı da üretebilir; oncekiSayi 0 olsaydı ilk turda
   gerçek bir "önceki sayı" olmadığı halde 0 çıkarsa yanlışlıkla reddedilirdi. -1,
   0-9 aralığının dışında olduğu için bu hataya düşmez.)
