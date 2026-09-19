# Değerlendirme — ck0555

1. toplam neden 0 girildiğinde de bir kez daha topluyor (toplam = toplam + 0)?
   (Özgür için: toplama satırı döngü şartından önce, her turda koşulsuz çalışıyor;
   0 eklemek toplamı değiştirmediği için sorun olmuyor ama satırın kendisi yine çalışıyor.)

2. do-while yerine while kullanılsaydı ilk "Sayı girin" isteği için ekstra bir satır
   gerekir miydi?
   (Özgür için: evet — while önce şartı kontrol eder, sayi'nin bir ilk değeri olması
   gerekirdi (ck0535'teki gibi döngü öncesi bir okuma satırı). do-while bunu gerektirmez.)
