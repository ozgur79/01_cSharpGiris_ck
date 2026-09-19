// 5 kez çalıştırınca hep 1,2,3'ün karışık sıralamaları çıktı, HİÇ 0 çıkmadı.
// Sebep: sayilar dizisi new int[3] ile 0,0,0 olarak başlar. Rastgele üretilen 0,
// foreach kontrolünde bu "henüz doldurulmamış" 0'larla eşleşip "zaten var" sanılır,
// hiçbir zaman gerçek bir slota yerleşemez — tıpkı ck0615'teki oncekiSayi=0 tuzağı gibi.
