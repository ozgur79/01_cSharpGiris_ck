// sayi=1005: sayi/1000=1 -> "bin"; sayi%1000/100 = 5/100=0 -> case yok, atlanır;
// (sayi%100)/10 = 5/10=0 -> case yok, atlanır; sayi%10=5 -> "beş".
// Sonuç: "binbeş". Hiçbir case eşleşmemesi hata değil — switch'te default zorunlu
// değildir, eşleşme yoksa switch bloğu sessizce hiçbir şey yapmadan biter.
