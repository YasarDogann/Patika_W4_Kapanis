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

## İstenilen Görev
Bir teknoloji mağazasında Telefon ve Bilgisayar kayıtları alıyoruz.
Telefon -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Tr Lisanslı olup olmama durumu özelliklerine sahip.
Bilgisayar -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Usb Giriş Sayısı, Bluetooth olup olmama durumu özelliklerini sahip
    BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarına miras veriniz. (Inheritance)

    Bilgisayar için Usb giriş sayısı 2 veya 4 atanabilir, aksi durumda bir uyarı mesajı verilerek -1 değeri atansın. (Encapsulation)

    Üretim Tarihi değeri bir nesne oluşturulduğu anda otomatik olarak atansın. Telefon için de Bilgisayar için de geçerli.

    Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi gibi ortak olan bilgileri yazdıran bir BilgileriYazdir() metodu tanımlansın. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.   (Polymorphism)

    UrunAdiGetir() diye abstract bir metot tanımlayarak Telefon ve Bilgisayar için ayrı ayrı ezerek

    "Telefonunuzun adı ---> ......"

    "Bilgisayarınızın adı ---> ......"

    şeklinde konsol mesajları yazdırılabilsin.  (Abstraction)

    Program akışı:

    1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.

    2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.

    3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek isteyip istemediğini sorunuz.

    4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek uygulamayı sonlandırınız.


## Kod
```csharp
//IDepartment arayüzü: tüm departmanlar için bir görev methodu tanımlar
public interface IDepartment
{
    void PerformTask();  // Görev Methodu tanımlanması
}

// Company sınıfı : Tüm çalışanlar için ortak özellikleri barındıran abstract bir sınıf
public abstract class Company : IDepartment
{
    // Çalışan için ad soyad ve pozisyon için ortak özellikler (Properties)
    public string Name { get; set; }
    public string LastName {  get; set; }
    public string Position { get; set; }


    // Company sınıfı yapıcı methodu.
    public Company(string name, string lastname,string position)
    {
        Name = name;
        LastName = lastname;
        Position = position;
    }

    // soyut görev methodu: türeyen sınıflar tarafından kullanılmak zorundadır.
    public abstract void PerformTask();
}


// Employee sınıfı: Company sınıfından miras almıştır. Çalışan için özel görev davranışını tanımlar
public class Employee : Company
{
    // Emplooye yapıcı methodu: Company sınıfı yapıcı methoduna parametreleri iletir.
    public Employee(string name, string lastname,string position) : base(name, lastname, position) { }

    // PerformTask methodu override eder. Çalışanın isim soyisim ve görevini ekrana yazdırır.
    public override void PerformTask()
    {
        Console.WriteLine($"{Name} {LastName} şirketin {Position} olarak çalışıyor");
    }
}
```
Interface, abstract class tanımlandı. Kalıtım kullanıldı

```csharp
 static void Main(string[] args)
 {
     Employee employee = new Employee("Yaşar", "Doğan", "Yazılım Mühendisi");
     employee.PerformTask();

     Console.WriteLine("\r\n*********************************************************\r\n");

     Employee employee2 = new Employee("Hasan", "Çıldırmış", "Proje Yöneticisi");
     employee2.PerformTask();
 }
```
Main method içinde sınıftan nesneler oluşturuldu.



