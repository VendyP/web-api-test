using System.Collections.Generic;

namespace WebApi.Services
{
    public static class PalindromHelper
    {
        public static List<string> Get(string str)
        {
            List<string> list = new List<string>();

            // to check last word for palindrome  
            str = str + " ";

            // to store each word  
            string word = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                // extracting each word  
                if (ch != ' ')
                {
                    word = word + ch;
                }
                else
                {
                    if (CheckPalin(word))
                    {
                        list.Add(word);
                    }
                    word = "";
                }
            }

            return list;
        }

        private static bool CheckPalin(string word)
        {
            int n = word.Length;
            word = word.ToLower();
            for (int i = 0; i < n; i++, n--)
            {
                if (word[i] != word[n - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}