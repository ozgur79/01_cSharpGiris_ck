# Değerlendirme — ck0630

1. for (int i = 0; i >= 0; i++) şartı hiç yanlış olur mu? Bu döngü ne zaman durur?
   (Özgür için: i hep artıyor, i>=0 pratikte hiç yanlış olmaz — döngü kendiliğinden
   bitmez, program VS'in kırmızı Durdur butonuyla elle kapatılmalı.)

2. sleep neden bir noktadan sonra (sleep>40 yanlış olunca) hep 40'ta sabitleniyor?
   (Özgür için: sleep - i sürekli küçülürse eninde sonunda negatif olurdu — negatif
   bekleme süresi anlamsız/hataya yol açar; 40'ta sabitlemek sayacın çok hızlanıp
   "kilitlenmesini" önler.)
