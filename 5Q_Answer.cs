using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentenceWithDuplicates = new string[5] { "Simple","Code","and","Clean","Code"};
            var output = RemoveDuplicateWords(sentenceWithDuplicates);
            for (int j = 0; j < output.Length; j++)
                Console.WriteLine(output[j]);
        }
        public static string[] RemoveDuplicateWords(string[] sentenceWithDuplicateWords)
        {
            var sentenceWithOutDuplicates = new ArrayList();

            for (int i = 0; i < sentenceWithDuplicateWords.Length; i++)
            {
                if (!sentenceWithOutDuplicates.Contains(sentenceWithDuplicateWords[i]))
                    sentenceWithOutDuplicates.Add(sentenceWithDuplicateWords[i]);
            }
            return (string[])sentenceWithOutDuplicates.ToArray(typeof(string));
        }
    }
}
