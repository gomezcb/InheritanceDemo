using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio rockRadio = new Radio(true, "Sony");
            rockRadio.SwitchOn();
            rockRadio.ListenToRadio();
        }
    }
}
