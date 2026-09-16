# Değerlendirme — ck0360

1. int.TryParse ile Convert.ToInt32 arasındaki temel fark ne?
   (Özgür için: Convert.ToInt32 dönüşüm başarısız olursa hata fırlatıp programı çökertir;
   TryParse başarısız olursa çökmez, sadece false döner — biz false'u yakalayıp kendi
   hata mesajımızı gösterebiliriz.)

2. `out sayi` ne işe yarıyor?
   (Özgür için: TryParse'ın hesapladığı sayıyı `sayi` değişkenine "geri yazmasını" sağlar —
   normal bir metot tek bir sonuç döndürür (true/false), `out` sayesinde ikinci bir sonuç
   (çevrilen sayı) da aynı anda dışarı çıkarılabiliyor.)
