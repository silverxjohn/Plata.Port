using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Plata.Port.Parallel
{
    public class ParallelPort : IPort, IDisposable
    {
        #region "DLL Import"

        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        private static extern void DOutput(int adress, int value);

        [DllImport("inpout32.dll", EntryPoint = "Inp32")]
        private static extern char DRead(int address);

        #endregion

        private int _address;
        public int address
        {
            get { return _address; }

            private set { _address = value; }
        }

        public void Connect(int address)
        {
            this.address = address;
        }
        
        public void Send(int data)
        {
            DOutput(address, data);
        }

        public void SendTo(int port, int data)
        {

        }

        public char Read()
        {
            return DRead(address);
        }

        public void Dispose()
        {
            address = -1;
        }
    }
}
