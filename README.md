# VisualProgramming-Görsel Programlama I
**3.Hafta**
18.10.2022
- Kullanıcı Adı ve Şifre ile sisteme giriş yapılıyor.
- Anasayfada "Strip Menü" ile uygulamalar arası geçiş yapılabiliyor.
- "Strip Menü"'den uygulama kapatılabiliyor.
- Uygulama 1 de textbox'a girilen değer büyük harfe dönüştürülüyor.
- Uygulama 2'de textbox'a girilen değerin rengi combobox ile değiştirilebiliyor.
- Uygulama 3'te "Yazılım" ve "Donanım" ismindeki radio butonların değerleri buton ile
listbox'a ekleniyor. Tenizleme butonu ile listbox temizleniyor.
- Uygulama 4'te combobox ile textbox'a girilen sayının yüzdesi alınıyor.
- Uygulama 5'te checkbox ile textbox'a girilen sayının yüzdesi alınıyor. Birden fazla 
yüzde seçilirse program uyarı veriyor.
- Uygulama 6'da butona basılınca combobox'a 0-99 arasındaki sayılar ekleniyor.

- Dashboard sayfasında sağ tıklama yapılınca uygulama kapatılabiliyor.
- Giriş ve Dashboard sayfası hariç diğer sayfalarda çıkış ve geri sayfaları bulunmaktadır.
----------------------------------------------------------------------------------------------------------
**4.Hafta**
25.10.2022
- İki adet textboxa ad ve soyad bilgileri girilerek bu bilgiler ekle butonu ile listboxa ekleniyor.

- Sil butonu ile listboxta seçilen veri siliniyor.

- Temizle butonuna basıldığı zaman listboxta bulunan bütün veriler siliniyor.

- Say butonuna tıklanıldığı zaman listboxtaki veri sayısını label'e yazdırıyor.

- Inputbox butonu eklenildi ve messagebox olarak gelen textboxta veri girilip girilen veri yeni bir messageboxta açıldı. Bunu eklemek için referanslardan VisualBasic seçilmelidir. Aksi taktirde hata fırlatacaktır.

- Yes/No butonu eklendi. Butona tıklanınca uygulamayı kapatıp kapatmayacağımızı seçiyoruz. Evet butonuna tıklayınca uygulama kapanıyor. Hayır butonuna tıklayınca program hiçbir şey yapmıyor. MessageBoxta extra olarak Error ikonu eklendi.

- OK-Cancel butonı eklendi. Butona basılınca messagebox açılıyor ve ekranda Evet-Hayır-İptal butonları çıkıyor. Evet butonuna basınca uygulamayı kapatıyor. Hayır butonuna basılınca program "Uygulama Kapatılmadı" diye mesaj veriyor ve devam ediyor. İptal butonuna basılınca program devam ediyor.

- AbortRetryIgnore butonu eklendi. Bu butona basılınca "Durdur-Yeniden dene-Yoksay" butonları ile birlikte messagebox geliyor. Durdur butonuna basılınca program kapanıyor. Yeniden dene butonuna basınca program AbortRetryIgnore butonuna geri dönüyor. Yoksay butonuna basınca bir şey yapmadan devam ediyor.
----------------------------------------------------------------------------------------------------------
**5.Hafta**
01.11.2022
- Ekran bir tane buton eklenildi. Butona basılınca Evet-Hayır-İptal butonları geliyor. Evete basılınca uygulama kapatılıyor. Hayıra basılınca uygulama kapatılmadı diyor. İptale basılınca hiçbir şey yapılamadı diyor.
- Dosya Aç butonu eklendi. Butona basılınca dosya ekleyebiliyoruz. Ekldediğimiz dosyanın yolu textboxta yazmaktadır.
- Kaydet butonu eklenildi. Butona basılınca kaydetme diyaloğu açılıyor.
- Renk butonu eklendi. Butona basılınca color dialog açılıyor ve seçilen renge göre label'in rengi değişiyor.
- Arka butonu eklendi. Butona basılınca color dialog açılıyor ve seçilen renge göre arka plan rengi değişiyor.
- Folder butonu eklendi. Butona basıldığı zaman klasör seçme diyaloğu açılıyor. Klasör seçtiğimiz zaman seçilen klasör yolu textboxta yazıyor.
----------------------------------------------------------------------------------------------------------
**5.Hafta-Ödev**
01.11.2022 (Notepad)
- Textboxa yazı yazılabilecek. ( Tab tuşu ile girinti verilebilecek. )
- Kaydet deyince txt olarak kaydedilicek.
- Klasör oluştur diyince klasör oluşturulabilecek.
- Aç diyince aktaracak
- Yazı tipi, yazı rengi değişecek.
----------------------------------------------------------------------------------------------------------
**6.Hafta**
08.11.2022
- Form ekranına iki adet textbox, bir adet buton, bir adet linklabel ve iki adet label eklendi.
- Oluştur butonuna basıldığı zaman bir tane linklabel oluşturuyor.
- Birinci textbox linklabelin adını, ikinci textbox ise linklabelin yolunu belirliyor.
- Form ilk açıldığında ekranın merkezinde açılıyor.(CenterScreen)
- Form'u küçültüp büyütme özelliği pasif durumdadır.

**DİCE GAME- ZAR OYUNU**
- Oyun ilk açılışında 1.Oyuncu ve 2.Oyuncu ismi istenilmektedir.
- Oyuna başlanıldığında sıra ile zar atılacak ve en büyük atan kim ise messagebox ile mesaj verilecek.
- Temizle butonuna tıklanıldığı zaman skorlar temizlenmektedir.

----------------------------------------------------------------------------------------------------------
**7.Hafta**
15.11.2022
- Başlat butonuna basıldığı zaman timer aktif ediliyor ve listbox'a belirlenen süre aralığında veri ekliyor.
- Bitir butonuna basıldığı zaman timer pasif hale getiriliyor.
- timer1.Enabled=false=timer1.Stop()
- timer1.Enabled=true=timer1.Start()
- Progres bar eklenildi. Progres bar timer ile ortak çalışmaktadır.
- 2 Adet Progres bar eklenildir. Başla butonuna basıldığı zaman birnci progres bar %100 olduğu zaman ikinci progres bar 10 artıyor. İkinci progres bar %100 olduğu zaman yüklenme tamamlandı diye mesaj veriyor.
**ReverseImage**
- Butona basıldığı zaman timer çalışıyor ve progres bar dolduğu zaman resimler yer değişiyor.