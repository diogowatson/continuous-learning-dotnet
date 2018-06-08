namespace csharp_tutorial_10
{
    //tutorial 10 - Interfaces
    class PowerButton : Icommand
    {
        IEletronicDevice device;//an instance of any deice modeled after that interface

        //constructor receive the device
        public PowerButton(IEletronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
