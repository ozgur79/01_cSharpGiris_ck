// ck0210 SEN YAP çözümü
// (e, 20) -> Asker olabilir            (cinsiyet doğru VE yaş>=18 doğru)
// (e, 15) -> Askerlik için uygun değil!  (cinsiyet doğru AMA yaş>=18 yanlış, && ikisini de ister)
// (k, 25) -> Askerlik için uygun değil!  (cinsiyet koşulu yanlış)
//
// Parantez kaldırılıp "if (cinsiyet == 'e' || cinsiyet == 'E' && yas >= 18)" yazılırsa:
// C#'ta && işlemi ||'den önce hesaplandığı için satır aslında
// "cinsiyet=='e' || (cinsiyet=='E' && yas>=18)" gibi çalışır. (cinsiyet=e, yas=15)
// girişinde "cinsiyet=='e'" tek başına true olduğundan yaş hiç kontrol edilmeden
// "Asker olabilir" yanlış sonucunu verir -- oysa parantezli halde doğru sonuç
// "Askerlik için uygun değil!" idi.
