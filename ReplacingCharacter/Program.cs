using System;
using System.Text;

namespace ReplacingCharacter
{
    class Program
    {
        static String str = "Ameke";
        static void Main(string[] args)
        {
            Console.WriteLine("Replacing the Character e from Ameke:" +ReplacingCharacter('e',"XXX"));
        }


        static String ReplacingCharacter(char ch, String Str1)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    sb.Append(Str1);
                }
                else
                {
                    sb.Append(str[i]);
                }
            }


            return sb.ToString();

        }
    }
}
