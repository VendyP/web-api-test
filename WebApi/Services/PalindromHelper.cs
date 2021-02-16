using System.Collections.Generic;
using System.Linq;

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


        public static List<string> Get2(string str)
        {
            List<string> list = new List<string>();

            var splitBySpace = str.Split(' ');
            for (int i = 0; i < splitBySpace.Length; i++)
            {
                var word1 = splitBySpace[i];
                if(list.Count > 0) break;
                var firstLetter = word1[0];

                int indexJ = i + 1;
                while (true)
                {
                    if (indexJ < splitBySpace.Length)
                    {
                        var word2 = splitBySpace[indexJ];
                        var lastLetter = word2[word2.Length - 1];
                        if (firstLetter == lastLetter)
                        {
                            if (list.Any(x => x == word1))
                            {
                                list.Add(word2);
                            }
                            else
                            {
                                list.Add(word1);
                                list.Add(word2);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                    indexJ++;
                }
            }

            // foreach (var item in splitBySpace)
            // {
            //     // get first letter


            //     if (item[0])

            // }

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