# Değerlendirme — ck0745

1. i neden metin.Length - 1'den başlıyor, metin.Length'ten değil?
   (Özgür için: string'in son geçerli indisi Length-1'dir — 5 harfli bir kelimede
   indisler 0,1,2,3,4'tür, 5 değil.)

2. metin.Length'ten başlatılırsa ne olur?
   (Özgür için: program çöker — IndexOutOfRangeException, çünkü metin[metin.Length]
   dizinin/string'in sınırları dışındadır.)
