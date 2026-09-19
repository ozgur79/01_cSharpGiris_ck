# Değerlendirme — ck0795

1. "3.5" yazınca program çöker mi?
   (Özgür için: hayır, çökmez — ama nokta "binlik ayracı" gibi yorumlanır, "3.5"
   aslında 35 olarak okunur. Bu, hatasız görünen ama SESSİZCE yanlış çalışan tehlikeli
   bir durumdur.)

2. Neden "3,5" doğru, "3.5" yanlış sonuç veriyor?
   (Özgür için: Convert.ToDouble, bilgisayarın bölge ayarına (Türkçe) göre metni
   okur; Türkçe ayarda ondalık ayracı virgüldür, nokta değildir.)
