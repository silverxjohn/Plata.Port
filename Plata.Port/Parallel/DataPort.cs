using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plata.Port.Parallel
{
    public static class DataPort
    {
        private static int[] _pins = new int[8];
        public static int pin1
        {
            get { return _pins[7]; }
            set
            {
                if (isBit(value))
                    _pins[7] = value;
            }
        }
        public static int pin2
        {
            get { return _pins[6]; }
            set
            {
                if (isBit(value))
                    _pins[6] = value;
            }
        }
        public static int pin3
        {
            get { return _pins[5]; }
            set
            {
                if (isBit(value))
                    _pins[5] = value;
            }
        }
        public static int pin4
        {
            get { return _pins[4]; }
            set
            {
                if (isBit(value))
                    _pins[4] = value;
            }
        }
        public static int pin5
        {
            get { return _pins[3]; }
            set
            {
                if (isBit(value))
                    _pins[3] = value;
            }
        }
        public static int pin6
        {
            get { return _pins[2]; }
            set
            {
                if (isBit(value))
                    _pins[2] = value;
            }
        }
        public static int pin7
        {
            get { return _pins[1]; }
            set
            {
                if (isBit(value))
                    _pins[1] = value;
            }
        }
        public static int pin8
        {
            get { return _pins[0]; }
            set
            {
                if (isBit(value))
                    _pins[0] = value;
            }
        }
        public static int pins
        {
            get
            {
                string pins_ = "";
                foreach (int pin in _pins)
                    pins_ += pin;

                return int.Parse(pins_);
            }
            
            set
            {
                string svalue = value.ToString();
                int i = addPointer(svalue.Length);

                if (svalue.Length > 8)
                    throw new IndexOutOfRangeException("value must be exactly 8 digits");

                foreach (char s in svalue)
                {
                    _pins[i] = int.Parse(s.ToString());
                    i++;
                }
            }
        }

        public static void Set()
        {
            for (int i = 0; i < 8; i++)
                _pins[i] = 1;
        }
        public static void Reset()
        {
            for (int i = 0; i < 8; i++)
                _pins[i] = 0;
        }
        private static int addPointer(int i)
        {
            int value = i;
            switch (i)
            {
                case 8:
                    value = 0;
                    break;
                case 7:
                    value = 1;
                    break;
                case 6:
                    value = 2;
                    break;
                case 5:
                    value = 3;
                    break;
                case 4:
                    value = 4;
                    break;
                case 3:
                    value = 5;
                    break;
                case 2:
                    value = 6;
                    break;
                case 1:
                    value = 7;
                    break;
                default:
                    break;
            }

            return value;
        }
        private static bool isBit(int value)
        {
            if (value == 0 || value == 1)
                return true;
            throw new InvalidBitException("A bit accepts only 1's and 0's");
        }
    }
}
