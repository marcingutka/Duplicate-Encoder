using System;
using System.Linq;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DuplicateEncode("aabcc))(("));            
        }
        public static string DuplicateEncode(string word)
        {
            return new string(word.ToLower().Select(c => word.ToLower().Count(x => x.ToString() == c.ToString()) > 1 ? ')' : '(').ToArray());
        }
    }
}
