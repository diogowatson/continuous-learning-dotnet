namespace csharp_tutorial_10
{
    //tutorial 10 - Interfaces

    class TVRemote
    {
        public static IEletronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
