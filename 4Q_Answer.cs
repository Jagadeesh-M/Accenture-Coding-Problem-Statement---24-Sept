using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Reverse The Words In A String";
            string reversedString_1 = ReverseWordsInString_1(inputString);
            /*+++ This is reversing words of a string using Split and Reverse +++*/
                Console.Write(reversedString_1);
            Console.WriteLine("\n---------------------------------------------------------------------------------------------\n");
            string reversedString_2 = ReverseWordsInString_2(inputString);
            /*+++ This is reversing words of a string WITHOUT using Split and Reverse +++*/
                Console.WriteLine(reversedString_2);
        }
        
        /*+++ This is reversing words of a string using Split and Reverse +++*/
        public static string ReverseWordsInString_1(string inputString)
        {
            string[] str = inputString.Split(' ');
            StringBuilder reversedString = new StringBuilder();
            Array.Reverse(str);
            foreach(string s in str)
            {
                reversedString.Append(s.ToString() + " ");
            }
            return reversedString.ToString();
        }
        /*--- This is reversing words of a string using Split and Reverse ---*/

        /*+++ This is reversing words of a string WITHOUT using Split and Reverse +++*/
        public static string ReverseWordsInString_2(string inputString)
        {
            ArrayList inputStringArrayList = new ArrayList();
            string splittedWords = "";
            StringBuilder reversedString = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    splittedWords = splittedWords + inputString[i];
                    if (i == (inputString.Length - 1))
                        inputStringArrayList.Add(splittedWords);
                    continue;
                }
                inputStringArrayList.Add(splittedWords);
                splittedWords = "";
            }
            for (int i = inputStringArrayList.Count; i >= 1; i--)
            {
                reversedString.Append(inputStringArrayList[i - 1] + " ");
            }
            return reversedString.ToString();
        }
        /*--- This is reversing words of a string WITHOUT using Split and Reverse ---*/
    }
}
