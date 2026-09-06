# Değerlendirme — ck0210

1. `&&` ile `||` arasındaki fark ne? (ck0190'da soru sorulmuştu, şimdi netleştir)
   (Özgür için: && İKİ koşulun da doğru olmasını ister, || EN AZ BİRİNİN doğru olması
   yeterlidir.)

2. cinsiyet='E', yas=17 girilirse sonuç ne olur?
   (Özgür için: "Askerlik için uygun değil!" — cinsiyet koşulu doğru ama yaş koşulu
   (17>=18) yanlış; && olduğu için ikisi birden doğru olmalıydı.)

3. Parantez `(cinsiyet == 'e' || cinsiyet == 'E')` neden var, kaldırılsa ne değişir?
   (Özgür için: C#'ta && işlemi ||'den önce hesaplanır. Parantez olmasa satır
   "cinsiyet=='e' || (cinsiyet=='E' && yas>=18)" gibi okunurdu — cinsiyet='e' (küçük harf)
   girilen her durumda ilk koşul tek başına true olur, yaş hiç kontrol edilmeden
   "Asker olabilir" yanlış sonucu çıkardı. Parantez bu hatayı önlüyor.)
