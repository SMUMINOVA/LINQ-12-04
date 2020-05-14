using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            var m = s.ToCharArray().Select(x => Converter(x));          
            foreach(var v in m)
            Console.Write(v);
            System.Console.WriteLine();
            
            
            s = "h3 th2r2";
            m = s.ToCharArray().Select(x => Converter(x));
            foreach(var v in m)
            Console.Write(v);
            System.Console.WriteLine();
            s = "fdghkj234gh54dfg*23fgh42";
            m = s.ToCharArray().Where(x => (x == '1'|| x == '2'|| x == '3'||x == '4'||x == '5'||x == '6'||x == '7'||x == '8'||x == '9'||x == '*'||x == '-'||x == '+'||x == '/')).Select(x => x);
            char action = m.First(x => (x == '*'||x == '-'||x == '+'||x == '/'));
            var n1 = double.Parse(m.TakeWhile(x => x != action).ToArray());
            var n = (m.SkipWhile(x => x != action)).ToList<char>();
            n.RemoveAt(0);
            var n2 = double.Parse(n.ToArray());
            switch(action){
                case '+': System.Console.WriteLine(n1 + n2); break;
                case '-': System.Console.WriteLine(n1 - n2); break;
                case '*': System.Console.WriteLine(n1 * n2); break;
                case '/': System.Console.WriteLine(n1 / n2); break;
            }
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
