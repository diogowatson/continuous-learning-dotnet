using System;

namespace csharp_tutorial_10
{
    class Television : IEletronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The tv is off");
        }

        public void On()
        {
            Console.WriteLine("the tv is on");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The tv volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV volume is at {Volume}");

        }

    }//end of class

}//end of namespace
