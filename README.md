# Proje Yapım Aşamaları

1. Projenin analizi çıkartılıp istenilen çözüm formülize edildi.
2. Projede oluşturulacak yapı tasarlandı.
3. Tasarlanan yapının kodlaması yapıldı.



Özet

Projenin yapım aşamasında ilk olarak verilen problemin örnek girdi ve çıktı değerleri incelenerek formulize edildi. Örnek olarak verilen "1 2 N" konum bilgisinde  "N , E , S , W" yön değerlerini 90 ve katları katları açı değeri olarak düşünüldüğünde ve uygulanan "LMLMLMLMM" giriş verilerinde "L ve M" için konumun duruma göre +90  veya -90 derecelik açılar uygulandığında son konum ve yön bilgisi belirlenmiş olacaktır. 

Sonrasında formulüze edilmiş bu akışı kodlama tarafına dökmek için "Models" ve "Services" library'leri oluşturulup "PostNewLocation" servisi eklendi.

Models Library' sinde base response ve PostNewLocation servisi için kullanılan request ve response modeli bulunmaktadır. Services Library'sinde ise dependency injection ile kullandığımız ve formülize ettiğimiz bilgileri içermektedir.

 /swagger linkine giderek örnek deneyebilir veya test caselerinden çıktılara ulaşabilirsiniz. 
