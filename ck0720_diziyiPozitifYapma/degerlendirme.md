# Değerlendirme — ck0720

1. liste[i] *= -1; ne yapar, liste[i] = liste[i] * -1; ile aynı mı?
   (Özgür için: evet birebir aynı — *= "kendisiyle çarp ve ata" demenin kısa yolu,
   ck0350'deki += ile aynı aile.)

2. 0 sayısı bu kodda değiştirilir mi?
   (Özgür için: hayır — if (liste[i] < 0) şartı 0 için yanlıştır (0<0 yanlış), 0
   matematikte ne pozitif ne negatiftir, kod bunu doğru ele alıyor, olduğu gibi
   bırakıyor.)
