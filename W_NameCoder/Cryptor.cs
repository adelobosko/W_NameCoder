using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace W_NameCoder
{
    public static class Cryptor
    {
        public static class HexNormal
        {
            public static string Crypt(string text)
            {
                var ba = Encoding.UTF8.GetBytes(text);
                return FormatBytes(ba);
            }

            public static string Decrypt(string text)
            {
                var ba = HexStringToByteArray(text);
                return Encoding.UTF8.GetString(ba);
            }

            private static string FormatBytes(IEnumerable<byte> bytes)
            {
                return bytes.Aggregate("", (current, byt) => current + $"{byt:X2}");
            }

            private static byte[] HexStringToByteArray(string hex)
            {
                return Enumerable.Range(0, hex.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                    .ToArray();
            }
        }
    }
}
