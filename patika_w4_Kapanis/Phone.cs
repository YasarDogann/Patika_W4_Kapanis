using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public class Phone : BaseMachine
    {
        private bool trLicance;
        public bool TrLicance
        {
            get { return trLicance; }
            set
            {
                trLicance = value; //değeri  ayarladık
                if (trLicance)
                {
                    Console.WriteLine("Tr Lisans Mevcut");
                }
            }
        }
        public Phone(string serialNumber, string name, string description, string operatingSystem, bool trLicance) : base(serialNumber, name, description, operatingSystem)
        {
            TrLicance = trLicance;
        }

        public override string GetProductName()
        {
            return $"Telefon Adı : {Name}";
        }

        public override void WriteInfos()
        {
            base.WriteInfos();
            Console.WriteLine($"Tr Lisans Durum : {TrLicance}");
            Console.WriteLine(GetProductName());
        }
    }
}
