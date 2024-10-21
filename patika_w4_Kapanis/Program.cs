namespace patika_w4_Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iphone = new Phone("AA1","İphone 13", "Eşsiz Tasarım", "IOS",true);
            iphone.WriteInfos();

            Console.WriteLine("\r\n-----------------------------------------\r\n");

            Computer monster = new Computer("BB2","Monster","Güçlü Dizüstü Bilgisayar","Windows",2,true);
            monster.WriteInfos();

            Console.WriteLine("\r\n-----------------------------------------\r\n");

            Phone samsung = new Phone("AA2", "S24 Ultra", "Sen nesin bee öyle bişey", "Android", false);
            samsung.WriteInfos();

            Console.WriteLine("\r\n-----------------------------------------\r\n");

            Computer dell = new Computer("BB2", "Dell XPS", "Güçlü bir dizüstü bilgisayar.", "Windows 10", 3, false);
            dell.WriteInfos();
        }
    }
}
