using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Gronsfeld
{
    static class Gronsfeld
    {
        public static StringBuilder Encode(StringBuilder toCode, string K)
        {
            StringBuilder newCode =
            new StringBuilder(toCode.ToString());
            for (int i = 1; i < toCode.Length; i++)
            {
                int T = (int)(((toCode[i]) + (int)(K[(i - 1) % (K.Length)] - (int)('0'))));
                newCode[i] = (Char)(T);
            }
            return newCode;
        }
        public static StringBuilder Decode(StringBuilder toDecode, string K)
        {

            StringBuilder newCode =
            new StringBuilder(toDecode.ToString());
            for (int i = 1; i < toDecode.Length; i++)
            {
                int T = (int)(((toDecode[i]) - (int)(K[(i - 1) % (K.Length)] - (int)('0'))));
                newCode[i] = (Char)(T);
            }
            return newCode;
        }

    }
}
