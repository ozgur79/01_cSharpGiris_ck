# Değerlendirme — ck0895

1. tus.Key == ConsoleKey.Enter kontrolü neden döngü ŞARTINDA değil, gövdenin
   İÇİNDE (break ile)?
   (Özgür için: Enter'a basılınca hem döngüden çıkmak hem de Enter karakterinin
   sifre'ye eklenmesini ÖNLEMEK gerekiyor — break, kontrolü daha karakter
   eklenmeden önce yapmamızı sağlıyor.)

2. Backspace'e basınca ne oluyor, silme gerçekleşiyor mu?
   (Özgür için: hayır — sadece "yeni karakter ekleme" atlanıyor, daha önce
   eklenmiş karakterler ve ekrandaki yıldızlar silinmiyor; gerçek bir silme
   için hem sifre'nin son karakterini çıkarmak hem ekrandaki son yıldızı
   Console.Write("\b \b") gibi bir teknikle silmek gerekirdi.)
