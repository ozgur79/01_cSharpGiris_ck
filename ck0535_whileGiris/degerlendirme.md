# Değerlendirme — ck0535

1. Bu döngünün kaç kez çalışacağı programı yazarken belli mi?
   (Özgür için: hayır — for'daki gibi sabit bir sayaç yok, kullanıcı 'q' yazana kadar
   sürer; bu yüzden while "belirsiz sayıda tekrar" gerektiğinde kullanılır.)

2. giris = Console.ReadLine(); satırı neden hem döngüden ÖNCE hem döngünün İÇİNDE var?
   (Özgür için: while şartı kontrol edilmeden önce giris'in bir değeri olması gerekir
   (ilk kontrol için); döngü içindeki tekrar aynı satır, bir sonraki turun şartını
   hazırlar. Biri eksik olsa döngü hiç başlamaz ya da hiç bitmez.)
