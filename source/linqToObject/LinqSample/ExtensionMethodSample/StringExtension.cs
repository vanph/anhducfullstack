using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    public static class StringExtension
    {
        public static string SayHello(this string source)
        {
            return $"Hello {source}";
        }

        [Obsolete("sap ko dung roi, hay dung ham WordCountNew di")]
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int WordCountNew(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
