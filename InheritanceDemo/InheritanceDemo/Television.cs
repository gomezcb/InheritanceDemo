using System;
namespace InheritanceDemo
{
    public class Television : ElectricalDevice
    {
        public Television(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void WatchTelevsion()
        {
            if(IsOn == true)
                Console.WriteLine("Welcome back to the 2010 NBA finals!");
            else
                Console.WriteLine("Try plugging in the TV, then switch it on");
        }
    }
}
