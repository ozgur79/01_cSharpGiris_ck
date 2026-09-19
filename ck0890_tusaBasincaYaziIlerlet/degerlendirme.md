# Değerlendirme — ck0890

1. Bu derste hangi tuşa basıldığı önemli mi?
   (Özgür için: hayır — Console.ReadKey(true) sadece "bir tuşa basıldı mı"
   bilgisini bekliyor, hangi tuş olduğuyla ilgilenmiyor (dönen değer bile
   kullanılmıyor); herhangi bir tuşa basmak yeterli.)

2. i < metin.Length şartı olmasaydı ne olurdu?
   (Özgür için: metin[i] i, metnin uzunluğunu aşınca IndexOutOfRangeException
   fırlatıp çökerdi — bu şart döngünün metnin sonunda düzgünce durmasını sağlıyor.)
