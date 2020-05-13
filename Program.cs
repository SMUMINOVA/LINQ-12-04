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
            foreach(var v in m)
            Console.Write(v);
            System.Console.WriteLine();
            
            
            s = "h3 th2r2";
            c = s.ToCharArray();
            m = c.Select(x => Converter(x));
            foreach(var v in m)
            Console.Write(v);

            
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
