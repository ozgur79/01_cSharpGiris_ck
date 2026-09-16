# Değerlendirme — ck0230

1. `!(a > b)` ile `a <= b` aynı şeyi mi kontrol eder? (a=5, b=3 iken ikisini de değerlendir)
   (Özgür için: a=5,b=3 için ikisi de False çıkar ama kavram olarak aynı şey — ! sonucu
   ters çevirir, `a <= b` doğrudan farklı bir koşul yazar. Bu örnekte ikisi denk, ama her
   zaman böyle olmayabilir; öğrenciye "ne zaman aynı, ne zaman değil" sorusu açık bırakılır.)

2. `!(a > b) || (b == 5)` satırında önce hangi işlem yapılır, ! mi yoksa parantez içi
   karşılaştırma mı?
   (Özgür için: önce parantez içi `a > b` hesaplanır (True), sonra ! onu tersine çevirir
   (False), en son || devreye girer. ! her zaman kendi hemen sağındaki tek ifadeye uygulanır.)
