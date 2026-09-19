# Değerlendirme — ck0585

1. Her case'in sonundaki break; ne işe yarıyor, silinirse ne olur?
   (Özgür için: eşleşen case'den sonra switch'ten çıkmayı sağlar. Silinirse kod bir
   sonraki case'e "düşer" (fall-through) ve onun kodunu da çalıştırır — istenmeyen
   bir davranış.)

2. default: bloğu ne zaman çalışır?
   (Özgür için: hiçbir case ile eşleşmeyen bir değer geldiğinde — burada 1,2,3 dışında
   bir sayı girilirse.)
