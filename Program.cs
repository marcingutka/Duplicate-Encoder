using System;
using System.Collections.Generic;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DuplicateEncode("()("));            
        }
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();

            Dictionary<char, char> CompareList = new Dictionary<char, char>();

            foreach (char c in word) {
                if (!CompareList.ContainsKey(c)) CompareList.Add(c, '(');
                else CompareList[c] = ')';
            }

            string modyfiedWord = "";
            for (int i = 0; i < word.Length; i++) {
                if(CompareList.ContainsKey(word[i])) modyfiedWord += CompareList[word[i]];
            }

            return modyfiedWord;
        }
    }
}
