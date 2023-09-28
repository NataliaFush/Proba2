namespace GG
{
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    class UserRun
    {
        public static int Digital = 0;
        public static int CountWords = 0;
        public static string[] Split(string sentense, char splitSymbol)
        {
            var strB = new StringBuilder();

            List<string> arrayWord = new ();

            for (int i = 0; i < sentense.Length; i++)
            {
                if (sentense[i] != splitSymbol || i == sentense.Length - 1)
                {
                    strB.Append(sentense[i]);
                }
                else
                {
                    arrayWord.Add(strB.ToString());
                    strB.Clear();
                }
            }

            arrayWord.Add(strB.ToString());

            return arrayWord.ToArray();
        }

        public static string ChangeWord(string str)
        {

            string[] words = Split(str, 'a');

            var strB = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                strB.Append(words[i]);
                strB.Append(" ");
            }

            return strB.ToString();
        }



        static void Main(string[] args)
        {
            string str = " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.  ";

            Console.WriteLine(ChangeWord(str));


        }
    }
}