using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    public static class MyExtension
    {
        public static IEnumerable<int> GetOddNumbers(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return source.Where(x => x % 2 == 1);
        }

        public static int CalculateAge(this Person person)
        {
            return DateTime.Now.Year - person.DoB.Year + 1;
        }
    }
}
