using System;
using System.Runtime.InteropServices;

namespace Baithi
{
    public class Phone
    {

        public string PhoneName { get; set; }
        public string PhoneType { get; set; }
        
        public string PhonePirce { get; set;}

        public void display()
        {
            Console.WriteLine($"Phone {PhoneName}, Type {PhoneType}, Pirce {PhonePirce}");
        }
       
    }
}