# Patika+ Week4 Kapanış Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta Kapanış kapsamında bütün bilgilerin tekrarı için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Inheritance Method yapısını öğrenmek
- Polymorphism
- Abstract

## 💣 İstenilen Görev
Bir teknoloji mağazasında Telefon ve Bilgisayar kayıtları alıyoruz.

- Telefon -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Tr Lisanslı olup olmama durumu özelliklerine sahip.
- Bilgisayar -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Usb Giriş Sayısı, Bluetooth olup olmama durumu özelliklerini sahip

    - BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarına miras veriniz. (Inheritance)
    - Bilgisayar için Usb giriş sayısı 2 veya 4 atanabilir, aksi durumda bir uyarı mesajı verilerek -1 değeri atansın. (Encapsulation)
    - Üretim Tarihi değeri bir nesne oluşturulduğu anda otomatik olarak atansın. Telefon için de Bilgisayar için de geçerli.
    - Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi gibi ortak olan bilgileri yazdıran bir BilgileriYazdir() metodu tanımlansın. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.   (Polymorphism)

    - UrunAdiGetir() diye abstract bir metot tanımlayarak Telefon ve Bilgisayar için ayrı ayrı ezerek
        - "Telefonunuzun adı ---> ......"
        - "Bilgisayarınızın adı ---> ......"
        şeklinde konsol mesajları yazdırılabilsin.  (Abstraction)

Program akışı:
1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.
2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.
3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek isteyip istemediğini sorunuz.
4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek uygulamayı sonlandırınız.


## 💻 BaseMachine Class Kod
```csharp
public abstract class BaseMachine
{
    public DateTime Date { get; private set; } // Üretim tarihini saklar
    public string SerialNumber { get; set; } // Seri numarasını saklar
    public string Name { get; set; }  // Ürün adını saklar
    public string Description { get; set; } // Açıklama saklar
    public string OperatingSystem { get; set; } // İşletim sistemini saklar
      
    // Yapıcı Method
    public BaseMachine(string serialNumber, string name, string description, string operatingSystem)
    {
        Date = DateTime.Now; // üretim tarihini otomatik atar
        SerialNumber = serialNumber;
        Name = name;
        Description = description;
        OperatingSystem = operatingSystem;
    }

    // bilgileri yazdırma methodu
    public virtual void WriteInfos()
    {
        Console.WriteLine($"Üretim Tarihi   : {Date}");
        Console.WriteLine($"Seri Numarası   : {SerialNumber}");
        Console.WriteLine($"Ürün Adı        : {Name}");
        Console.WriteLine($"Ürün Açıklaması : {Description}");
        Console.WriteLine($"İşletim Sistemi : {OperatingSystem}");

    }

    //Ürün adını döndüren soyut method
    public abstract string GetProductName();

}
```
Interface, abstract class tanımlandı. Kalıtım kullanıldı

## 💻 Phone Class Kod
```csharp
public class Phone : BaseMachine
{
    private bool trLicance;  // Tr lisans durumu

    public bool TrLicance  // Tr lisans özelliği
    {
        get { return trLicance; }
        set
        {
            trLicance = value; //değeri  ayarladık
            if (trLicance)  // lisans durum kontrolü
            {
                Console.WriteLine("Tr Lisans Mevcut");
            }
        }
    }

    // yapıcı method : base 
    public Phone(string serialNumber, string name, string description, string operatingSystem, bool trLicance) : base(serialNumber, name, description, operatingSystem)
    {
        TrLicance = trLicance; // Tr lisansı ayarlanıyor
    }

    // ürün adını döndürme methodu : override
    public override string GetProductName()
    {
        return $"Telefon Adı : {Name}";
    }

    // bilgileri yazdırma methodu : override
    public override void WriteInfos()
    {
        base.WriteInfos(); // Base sınıf bilgileri yazdırlı
        Console.WriteLine($"Tr Lisans Durum : {TrLicance}"); // lisans durumu yazdırılır
        Console.WriteLine(GetProductName());  // telefon adı yazdırılır
    }
}
```

## 💻 Computer Class Kod
```csharp
public class Computer : BaseMachine
{
    private int usbIn; // Usb giriş sayısı

    public int UsbIn // usb giriş sayısı özelliği
    {
        get { return usbIn; }

        set
        {
            if ((value == 2) || (value == 4)) // geçerli sayı kontrolü
            {
                usbIn = value; // değer ayarlanıyor
            }
            else
            {
                usbIn = -1; // geçersiz değer
                Console.WriteLine($"2 veya 4 adet port verilmediği için {usbIn} değeri oldu");  // hata mesajı
            }
        }
    }

    private bool bluetooth;  // bluetooth durumu
    bool Bluetooth  // bluetooth özelliği
    {
        get { return bluetooth; }
        set
        {
            bluetooth = value; // Değer ayarlama
            if (bluetooth)  // bluetooh durum kontrolü
            {
                Console.WriteLine("Bluetooth mevcut");
            }
        }
    }

    // yapıcı method
    public Computer(string serialNumber, string name, string description, string operatingSystem, int usbIn, bool bluetooth) : base(serialNumber, name, description, operatingSystem)
    {
        UsbIn = usbIn;  // usb girişi ayarlanır
        Bluetooth = bluetooth; // bluetooh durumu ayarlanır
    }

    // ürün adını döndüren method : override
    public override string GetProductName()
    {
        return $"Bilgisyarınızın Adı : {Name}";
    }

    // Bilgileri ekrana yazdırma : override
    public override void WriteInfos()
    {
        base.WriteInfos();
        Console.WriteLine(GetProductName());
    }

}
```

## 🔥 Main Method Kod
```csharp
static void Main(string[] args)
{
    // Telefon nesnesi oluşturuldu.  TR lisansı: True 
    Phone iphone = new Phone("AA1","İphone 13", "Eşsiz Tasarım", "IOS",true);
    iphone.WriteInfos();

    Console.WriteLine("\r\n-----------------------------------------\r\n");

    // bilgisayar nesnesi oluşturuldu. Usb giriş: 2 ve Bluetooth: True
    Computer monster = new Computer("BB2","Monster","Güçlü Dizüstü Bilgisayar","Windows",2,true);
    monster.WriteInfos();

    Console.WriteLine("\r\n-----------------------------------------\r\n");

    // Telefon2 nesnes oluşturuldu. TR Lisansı: False
    Phone samsung = new Phone("AA2", "S24 Ultra", "Sen nesin bee öyle bişey", "Android", false);
    samsung.WriteInfos();

    Console.WriteLine("\r\n-----------------------------------------\r\n");

    // Computer2 nesnesi oluşturuldu. Usb Giri: 3 ve Blueetooth: False
    Computer dell = new Computer("BB2", "Dell XPS", "Güçlü bir dizüstü bilgisayar.", "Windows 10", 3, false);
    dell.WriteInfos();
}
```
