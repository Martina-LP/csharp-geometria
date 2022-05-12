using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class LeggiNumeri
    {
        public static bool ReadNum(out int value)
        {
            value = 0;
            String s = new(Console.ReadLine());
            if (s == null)
                return false;
            return int.TryParse(s, out value);
        }
        public static bool ReadNum(string message, out int value)
        {
            Console.Write(message);
            return ReadNum(out value);
        }

        public static bool ReadNum(out long value)
        {
            value = 0;
            String s = new(Console.ReadLine());
            if (s == null)
                return false;
            return long.TryParse(s, out value);
        }
        public static bool ReadNum(string message, out long value)
        {
            Console.Write(message);
            return ReadNum(out value);
        }
        public static bool ReadNum(out double value)
        {
            value = 0;
            String s = new(Console.ReadLine());
            if (s == null)
                return false;
            return double.TryParse(s, out value);
        }
        public static bool ReadNum(string message, out double value)
        {
            Console.Write(message);
            return ReadNum(out value);
        }
    }
}
