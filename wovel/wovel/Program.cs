using System;

namespace wovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] topic = { "Ağıllı ağıl eləyincə dəli vurdu keçdi" };
            Console.WriteLine(VowelLetter(topic));
        }
        static int VowelLetter(string[] text)
        {
            int count = 0;
            foreach (string word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i]=='a'|| word[i] =='e'||word[i] == 'u'|| word[i] == 'i' || word[i] == 'o' || word[i] == 'ə' || word[i] == 'ı' || word[i] == 'ö' || word[i] == 'ü')
                    {
                        count++;
                    }
                    
                }

            }
            return count;

        }
    }
}
