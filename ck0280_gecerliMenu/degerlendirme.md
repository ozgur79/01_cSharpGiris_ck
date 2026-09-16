# Değerlendirme — ck0280

1. islemTipi="9" girilince sayılar neden hiç sorulmuyor?
   (Özgür için: dış if (geçerlilik kontrolü) false çıkıyor, bloğun içindeki hiçbir satır
   — sayı sorma dahil — çalıştırılmıyor.)

2. Dış if olmasaydı, doğrudan içteki else if zincirine gidilseydi ne sakıncası olurdu?
   (Özgür için: islemTipi="9" gibi geçersiz bir değer son else'e (bölme) düşerdi, kullanıcı
   hiç bölme istemediği hâlde yanlışlıkla bölme sonucu görürdü — dış if bu hatayı önlüyor.)
