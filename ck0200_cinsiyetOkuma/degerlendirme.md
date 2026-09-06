# Değerlendirme — ck0200

1. Convert.ToChar ne işe yarar, girdisi ne tür, çıktısı ne tür?
   (Özgür için: girdi string (Console.ReadLine()'ın döndürdüğü), çıktı char — tek
   karakterlik yazıyı char tipine çevirir.)

2. İki karakter birden girilirse (örn. "ek") ne olur?
   (Özgür için: program hata verip çöker — "String must be exactly one character long."
   mesajını verir; Convert.ToChar tam olarak bir karakter bekler.)

3. `cinsiyet == 'e' || cinsiyet == 'E'` neden iki ayrı karşılaştırma içeriyor?
   (Özgür için: char karşılaştırması da büyük/küçük harfe duyarlı; kullanıcı küçük ya da
   büyük harfle yazabilir, ikisini de kabul etmek için || ile birleştiriyoruz.)
