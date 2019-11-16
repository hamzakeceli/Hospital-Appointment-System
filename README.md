# Hospital-Appointment-System
Sistemde kullanıcı üye olarak istediği hastane,departman,polikinlikten kendine uygun boş seanslardan randevu alabilmektedir. Kullanıcı tüm randevularını görüntüleyebilmekte ve ileri tarihli olanları silebilmektedir.
Doktor randevularını görebilmekte, reçete yazabilmekte ve tahlil isteyebilmektedir.
Eczacı reçete numarasıyla hastanın tüm reçetelerini görüntüleyebililmektedir.
Admin sistemden doktor ve eczacı ekleme imkanına sahiptir.

### C# Windows Form yöntemiyle yapılmış olup, Katmanlı Mimari (N-Tier), Ado.Net kullanılıp, veritabanı olarak MSSQL kullanılmıştır.

### Login Ekranı
Giriş yapılırken  mail ve şifre kontrolü yapılır.
Yeni üye olurken mail formatı ve şifre uygunluk kontrolleri yapılır.
![LoginPage](https://user-images.githubusercontent.com/43986232/68993888-dda1c980-088d-11ea-87c6-e6306cee842a.png)

### Admin İşlemleri Doktor ve Eczacı Ekleme
Admin sisteme gerekli bilgileri girerek yeni doktor ve eczacı ekleyebilmektedir.
![AdminPanel](https://user-images.githubusercontent.com/43986232/68993956-412bf700-088e-11ea-9372-eec6b8906f0f.png)

### Randevu Alma ve Randevuları Görüntüleme
Hasta sisteme giriş yaparak randevu alabilir ve aldığı  tüm randevuları görüntüleyebilir. 

Gideömeyeceği ileri tarihli randevuları silebilir.
![PatientPanel](https://user-images.githubusercontent.com/43986232/68994009-df1fc180-088e-11ea-9caa-bd05d238ec08.png) 

### Doktor Ekranı
Doktor günün muayenelerini ve geçmiş muayenelerini görebilmektedir.
![DoctorPanel](https://user-images.githubusercontent.com/43986232/68994065-9b798780-088f-11ea-8a9a-a2f3a84a4d0f.png)

### Eczacı Ekranı
Eczacı reçete numarasıyla hastanın tüm reçetelerini ve ilaçları görebilmektedir.
![PharmacistPanel](https://user-images.githubusercontent.com/43986232/68994099-12168500-0890-11ea-9ddf-35f1f113aabd.png)
