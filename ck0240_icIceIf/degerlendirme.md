# Değerlendirme — ck0240

1. kadi="mehmet" girilirse şifre hiç sorulmuyor. Neden?
   (Özgür için: dıştaki if false çıktığı için içindeki blok (şifre sorma dahil) hiç
   çalıştırılmıyor — içteki if'e sıra bile gelmiyor.)

2. kadi="Ogrenci", sifre="Kalfa123" (büyük K ile) girilirse sonuç ne olur?
   (Özgür için: "Hatalı Şifre" — string karşılaştırması büyük/küçük harfe duyarlı,
   kullanıcı adı kontrolünde üç varyant ayrı ayrı yazıldığı hâlde şifrede tek bir
   yazım (`"kalfa123"`) var.)
