# Değerlendirme — ck0880

1. baslangic ve bitis neden zıt yönlerde hareket ediyor (biri ++ biri --)?
   (Özgür için: baslangic baştan sona, bitis sondan başa doğru ilerliyor —
   ortada buluşana kadar her turda bir çift eleman takas ediliyor.)

2. Şart while (baslangic <= bitis) olsaydı sorun olur muydu?
   (Özgür için: hayır — ortadaki elemanda baslangic==bitis olur, eleman kendisiyle
   takas edilir (hiçbir şey değişmez), zararsızdır. `<` kullanmak sadece gereksiz
   bir kendi-kendine-takas adımını atlar.)
