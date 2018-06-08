using System;

namespace csharp_tutorial_8
{
    class attackPowerException : Exception
    {
        public attackPowerException(string message) : base(message)
        { }
    }
}
