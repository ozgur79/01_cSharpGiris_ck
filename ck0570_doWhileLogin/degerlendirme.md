# Değerlendirme — ck0570

1. Şart neden && değil || ile yazılmış?
   (Özgür için: kullanıcı adı YANLIŞ OLABİLİR VEYA şifre YANLIŞ OLABİLİR — ikisinden
   biri bile tutmuyorsa tekrar sorulmalı. && olsaydı ikisi de aynı anda yanlışken
   tekrar sorardı, bu da hatalı girişleri es geçerdi.)

2. Doğru kullanıcı adı/şifre girildiğinde "Yanlış giriş yaptınız!" ekranda görünür mü?
   (Özgür için: yazılır ama görünmez — do-while gövdesi önce çalışıp o satırı basar,
   sonra şart kontrol edilince doğru girişte döngü biter ve hemen Console.Clear()
   ekranı temizler; mesaj göz açıp kapayana kadar silinir.)
