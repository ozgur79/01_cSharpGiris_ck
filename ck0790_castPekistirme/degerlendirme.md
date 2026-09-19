# Değerlendirme — ck0790

1. (float)x / y ile (float)(x / y) neden farklı sonuç veriyor?
   (Özgür için: ilkinde x ÖNCE float'a çevrilip SONRA bölünüyor (int bölmesi hiç
   olmuyor, 2,5 çıkıyor); ikincisinde x/y ÖNCE tam sayı olarak bölünüp (2 kalıyor,
   küsurat kayboluyor), SONRA bu 2 float'a çevriliyor (hâlâ 2,0) — cast'in konumu
   işlem sırasını değiştiriyor.)

2. Bu dersin ck0060 ile bağlantısı ne?
   (Özgür için: ck0060'ta "int bölmesi küsuratı atar" demiştik ve SEN YAP'ta
   (double)x / y ipucu vermiştik ama açıklamamıştık; bu ders o ipucunun tam açıklaması
   ve ck0650'deki cast bilgisinin (renk için kullanmıştık) sayılar üzerindeki pekiştirmesi.)
