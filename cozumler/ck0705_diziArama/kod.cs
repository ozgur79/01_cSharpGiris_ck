// break kaldırılırsa: eşleşme bulununca bulundu=true olur AMA döngü devam eder,
// kalan tüm elemanlarla karşılaştırmaya devam eder (gereksiz iş) — sonuç yine doğru
// çıkar (bulundu true kalır) ama daha verimsiz çalışır, eşleşme birden fazlaysa
// sadece SONUNCUSUNUN mesajı ekranda kalır.
