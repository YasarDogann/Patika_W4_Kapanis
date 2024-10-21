namespace patika_w4_Kapanis
{
    internal class Program
    {
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
    }
}
