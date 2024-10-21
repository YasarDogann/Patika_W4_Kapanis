using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public class Computer : BaseMachine
    {
        private int usbIn;
        public int UsbIn
        {
            get { return usbIn; }

            set
            {
                if ((value == 2) || (value == 4))
                {
                    usbIn = value;
                }
                else
                {
                    usbIn = -1;
                    Console.WriteLine($"2 veya 4 adet port verilmediği için {usbIn} değeri oldu");
                }
            }
        }

        private bool bluetooth;
        bool Bluetooth
        {
            get { return bluetooth; }
            set
            {
                bluetooth = value;
                if (bluetooth)
                {
                    Console.WriteLine("Bluetooth mevcut");
                }
            }
        }


        public Computer(string serialNumber, string name, string description, string operatingSystem, int usbIn, bool bluetooth) : base(serialNumber, name, description, operatingSystem)
        {
            UsbIn = usbIn;
            Bluetooth = bluetooth;
        }

        public override string GetProductName()
        {
            return $"Bilgisyarınızın Adı : {Name}";
        }

        public override void WriteInfos()
        {
            base.WriteInfos();
            Console.WriteLine(GetProductName());
        }

    }
}
