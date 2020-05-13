using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            char[] c = s.ToCharArray();
            var m = c.Select(x => Converter(x));
            //m = c.Where(x => x == 'a').Select(x => x = '1');
            //m = m.Where(x => x == 'e').Select(x => x = '2');            
            //m = m.Where(x => x == 'i').Select(x => x = '3');
            //m = m.Where(x => x == 'o').Select(x => x = '4');
            //m = m.Where(x => x == 'u').Select(x => x = '5');
            foreach(var v in m)
            Console.Write(v);
            System.Console.WriteLine();
        }
        public static char Converter(char s){
            switch(s){
                case 'a': s = '1' ;break;
                case 'e': s = '2' ;break;
                case 'i': s = '3' ;break;
                case 'o': s = '4' ;break;
                case 'u': s = '5' ;break;
                case '1': s = 'a' ;break;
                case '2': s = 'e' ;break;
                case '3': s = 'i' ;break;
                case '4': s = 'o' ;break;
                case '5': s = 'u' ;break;

            }
            return s;
        }

    }
}
