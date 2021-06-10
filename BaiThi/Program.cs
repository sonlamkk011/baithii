using System;

namespace Baithi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.PhoneName = "Iphonelamson";
            mobilePhone.PhoneType = "mobile";
            mobilePhone.PhonePirce = 2001;
            mobilePhone.display();

            Phone phone = new Phone();
            phone.PhoneName = "Ip";
            phone.PhoneType = "phone";
            phone.PhonePirce = 2001;
            phone.display();
        }
    }
}