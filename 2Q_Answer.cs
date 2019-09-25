using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[5] { "bAt", "caT", "jiM", "Tim", "@ $%" };

            CharacterFrquencyCalculator(strArray);
        }
        public static void CharacterFrquencyCalculator(string[] strArray)
        {
            string str = "";
            StringBuilder sbOuput = new StringBuilder(); 
            foreach (string st in strArray)
                str += st.ToString();

            var characterCount = new Dictionary<char, int>();
            foreach (var cr in str)
            {
                if (characterCount.ContainsKey(cr))
                    characterCount[cr]++;
                else
                    characterCount[cr] = 1;
            }

            foreach (KeyValuePair<char, int> dictKeyValues in characterCount)
            {
                //Console.WriteLine("Key = {0}, Value = {1}", dictKeyValues.Key, dictKeyValues.Value);
                sbOuput.Append(dictKeyValues.Key + ":" + dictKeyValues.Value + ",");
            }
            Console.WriteLine(sbOuput.ToString());
        }
     }
 }
