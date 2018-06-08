using System;

namespace csharp_tutorial_10
{
    class TutorialTen
    {
        public static void Main()
        {
            IEletronicDevice TV = TVRemote.GetDevice();//Is creating an object of new television

            PowerButton powBut = new PowerButton(TV);//creating a new power button and injecting tv on it

            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();
        }
    }
}
