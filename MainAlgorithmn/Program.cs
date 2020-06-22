using System;
using DataStructure;

namespace MainAlgorithmn
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack alist = new Stack();

            string ch;
            string word = "eyjjjye";
            bool isPalindrome = true;

            for(int x=0; x < word.Length; x++)
            {
                alist.push(word.Substring(x, 1));
            }

            int pos = 0;
            while (alist.Count > 0)
            {
                ch = alist.pop().ToString();
                if(ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }

            if(isPalindrome)
                Console.WriteLine(word + " is a palindrome.");
            else
                Console.WriteLine(word + " is not a palindrome.");
            Console.Read();
        }
    }
}
