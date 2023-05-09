# Pizza Otomasyonu

<p align="center"><img src="https://socialify.git.ci/epbalaban01/Pizza-Otomasyonu/image?name=1&amp;owner=1&amp;theme=Light" alt="project-image"></p>

## Raporun İçeriği
Projenin tamamının ve her kısmının ekran görüntüleri ve kodlarıyla anlatıldığı, projemizi tam olarak tanımlayan bir rapordur.

## Projenin Yapılma Amacı
Proje sisteme giriş yapan müşterilerin kolay, hızlı pratik ve güvenli bir şekilde pizza siparişi vermesine olanak tanıyor. Müşteri istediği boyut, malzeme, içecek ve ekstralar gibi çeşitli malzemeleri kolayca seçerek siparişini verebiliyor.

## Projenin Özellikleri

* Müşteri, admin olarak kullanıcıların bulunması.
* Gelişmiş, basit, kolay ve hızlı kullanılabilmesi.
* Toplam ücreti görüntüleme.
* İsteğine göre pizza yapılandırma.(Boy ve malzeme olarak)
* Otomatik olarak indirim yapma.
* Sipariş özeti bulunması.
* Eklenen ürünlerin görüntülenebilmesi (sepet özelliği).
* Nakit ve kredi kartı olarak ödeme seçenekleri.
* Siparişi iptal etme, yeni sipariş oluşturma.

## Pizza Otomasyonu Giriş Ekranı
<p align="center">
<img src="https://user-images.githubusercontent.com/42430554/176411573-054a274f-bb70-4e6a-8ff7-0d78db97fd07.png"></p>
<p align="center"> 
  Programı çalıştırdığınızda karşınıza ilk olarak bu ekran gelecek. Bu ekranda Kayıt Ol kısmına tıklayıp istenilen bilgileri girerek bir kullanıcı kaydı oluşturabilir, mevcut bir kaydınız varsa da daha önceden oluşturmuş olduğunuz kullanıcı adı ve şifre kısmıyla giriş yapabilirsiniz.
</p>

<p align="center">
<img src="https://user-images.githubusercontent.com/42430554/136610583-29747aa4-58b5-4e43-90f2-91edf2bd5d86.png"></p>
<p align="center"> 
  Kullanıcı adminse onu admin ekranına yönlendiren kod
</p>

<p align="center">
<img src="https://user-images.githubusercontent.com/42430554/136610603-70d547a1-6377-499e-b06e-2674e5a08c60.png"></p><br/>
<p align="center">
  Kullanıcı normal üyeyse onu müşteri ekranına yönlendiren kod
</p><br/>


## Müşteri Ekranı
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136611924-13754391-c8c6-411f-a323-ecc1170ed778.jpg"></p>
<p align="left"> 
Müşteri giriş yaptıktan sonra bu ekrana yönlendirilebilir ve buradan sipariş verme ekranına bilgiler ekranına geçmiş siparişler ve ödemeler kısmıan göz atabilir.
</p> 


## Admin Paneli
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136611952-bd30d5c5-ab32-4ec4-92e7-e2546239ca0b.jpg"></p>
<p align="left"> 
Admin kullanıcı adı ve şifresiyle giriş yapıldığında admin kullanıcısının görebileceği ve kontrol edebileceği alanlar bulunuyor, ayrıca yan taraftaki kısımda ise giriş yapan kullanıcı kendi bilgilerini görebiliyor.
</p> 

## Sipariş İşlemleri
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136611999-d9657cdc-165d-45a5-9e7a-1cc4928115c1.jpg"></p>
<p align="left"> 
  Adminin görebileceği bu kısma giriş yapıldığında mevcut siparişleri ve müşterilerin tüm bilgilerini görebilir onları düzenleyebilir, beklemede ve tamamlandı gibi ayarlamalar yapabilir.
</p> 

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612025-92322353-fc77-40e2-b305-be3c45091f30.png"></p>
<p align="center"> 
  Düzenlemelerin yapılmasını sağlayan kod
</p> 

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612040-8a19f876-1300-4972-8b7a-9d8fe00a4386.png"></p>
<p align="center"> 
  Textbox’a Sipariş ID numarası yazdığında o siparişi sildiren kod
</p> 


## Kullanıcı İşlemleri
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612078-e7cc7c75-4661-4332-bf4c-b473a59bdc7c.jpg"></p>
<p align="left"> 
Kullanıcıların bilgilerini güncellemek, düzeltmek, adına göre arama yapmak, eklemek, silmek ve bilgilerini görüntülemek için kullanılan ekran.
</p> 

## Cari Yönetim
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612114-191c7378-ba12-4e84-afe3-b2118a5778cb.png"></p>
<p align="left"> 
Şirketin gelirleri ve giderleri siparişleri kayıtlı olan kullanıcıları ve müşterilere yapılan indirimleri, menülerden içeceklerden ve pizzalardan kazanılan toplam paraları listeleyen ekran.
</p> 

<p align="center">
<img src="https://user-images.githubusercontent.com/42430554/136612122-674e2002-3bfe-4d56-964f-2f85f5569b2e.png"></p>
<br/>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612129-20ce5a83-0e46-4162-902c-adb9faa3b141.png"></p>

## Geçmiş Sipariş
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612154-4352eaac-f543-4372-881e-3a8e58da12c1.jpg"></p>
<p align="left"> 
Geçmiş sipariş kısmında admin ise bütün kişileri mevcut olan siparişleri, müşteri ise kendi ID’si olan siparişi görüntüleyebilir.
</p>

## Sipariş Ekranı
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612211-091bfe96-dc38-45cd-9604-293f4ba799b0.jpg"></p>
<p align="left"> 
Müşteri kendi kaydıyla giriş yaptıktan sonra buradan pizzasını, menüsünü, içeceğini seçebilir. Seçtiği ürünleri ve toplam tutarını kontrol ettikten sonra siparişi tamamla diyerek ödeme ekranına yönlendirilir.
</p>

## Ödeme
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612233-a07903f1-1fb5-40dd-893e-510da8aea399.png"></p>
<p align="left"> 
Müşteri siparişi tamamla butonuna tıkladıktan sonra ödeme ekranına gelir. Ödeme ekranında “nakit” veya “kredi kartı” olarak 2 seçenek sunulur. Müşterinin seçtiğine göre sistem otomatik olarak ona indirim uygular. Daha sonra öde diyerek siparişini öder.
</p>

## Hakkımızda
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612260-6b58374a-4076-4619-9770-5dfabcf585a1.png"></p>
<p align="left"> 
  Burada programın versiyonu, dosyanın adı, geri bildirim, e-postası ve programı oluşturan kişiler Eyüp Can Balaban ve Halil Çağrı Sert yer almaktadır.
</p>

## Sipariş Göster
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612306-f80cb69f-0320-43fa-98dc-3335b4dd08ef.jpg"></p>
<p align="center"> 
  Sipariş beklemede görünümü
</p>

<p align="left"> 
Müşteri kendi ekranından tıklamış olduğu sipariş göster kısmında burada kendi siparişlerini beklemede ve hazır olarak görebilir.
</p>

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612337-505bae41-6c84-4e5f-b913-a16c23fb892b.jpg"></p>
<p align="center"> 
  Sipariş hazır görünümü
</p>

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612359-a2cd92d0-9ed7-4e62-90b1-9a70828fa313.png"></p>
<p align="center"> 
  Müşteride siparişin beklemede olduğunu gösteren kodlar
</p>

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612370-5e46d3be-2d94-492c-99e3-a68a115788e1.png"></p>
<p align="center"> 
  Müşterinin siparişi tamamlandığında hazır olarak gösteren kod
</p>

## Ödeme Ekranı
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612388-086d42e9-b68a-41de-9bd8-aa32910a8857.png"></p>
<p align="center"> 
  Müşterinin sipariş ID sini girip daha önceki ödemelerine bakabildiği kısım
</p>

<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612397-b2c6fa82-a816-4bfc-8a9c-ace4462b5c77.png"></p>
<p align="center"> 
  Müşteri ödemelerini veri tabanından okuyup forma yazdıran kod
</p>

## Bilgiler
<p align="center"> 
<img src="https://user-images.githubusercontent.com/42430554/136612426-88d04898-b9d8-4f3a-b196-ed7f3573f891.jpg"></p>
<p align="center"> 
  Müşteri bilgiler ekranında sisteme yazarak kayıt olduğu bilgileri görebilir.
</p>

<hr/>

> Lisans bilgisi tüm kod, GPL Sürüm 3 lisansı altındadır. Lisansın kullanım koşulları için LİSANS dosyasını okuyun..

