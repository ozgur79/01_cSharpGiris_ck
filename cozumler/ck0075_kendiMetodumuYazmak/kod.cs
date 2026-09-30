// ck0075 SEN YAP çözümü
// 1) Main() içinde iki kez çağırınca "ben tanit metoduyum" bloğu iki kez yazılır:
tanit();
tanit();
// 2) Topla() içinde sayıları değiştirmek sonucu değiştirir; örn. 10 + 20 yerine 7 + 5 → 12:
//    static int Topla() { int sonuc = 7 + 5; return sonuc; }
// Metot bir kez yazılır, istediğin kadar çağrılır — tekrar eden kodu kopyalamana gerek kalmaz.
