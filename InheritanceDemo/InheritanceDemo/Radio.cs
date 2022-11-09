using System;
namespace InheritanceDemo
{
    public class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void ListenToRadio()
        {
            if(IsOn == true)
                Console.WriteLine("Now listening to 90's rock radio!");
            else
                Console.WriteLine("The radio is off, try switching it on");
        }
    }
}
