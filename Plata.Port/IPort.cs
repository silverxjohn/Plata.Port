using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plata.Port
{
    interface IPort
    {
        void Connect(int address);
        void Send(int data);
        char Read();
    }
}
