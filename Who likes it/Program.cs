using System;

namespace Who_likes_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] zero = { };
            string[] one = { "Jack Sparou" };
            string[] two = { "Good Cop", "Bad Cop" };
            string[] three = { "Harry Potter", "Hermiona Granger", "Ron Vizley" };
            string[] four = { " Leonardo", "Michelangelo", "Donatello", "Raphael" };
            
            Console.WriteLine(MyMethod(zero));
            Console.WriteLine(MyMethod(one));
            Console.WriteLine(MyMethod(two));
            Console.WriteLine(MyMethod(three));
            Console.WriteLine(MyMethod(four));
            
        }

        static string MyMethod(string[] str)
        {
            if (str == null)
                throw new NotImplementedException();
            else
            {
                string result = "";
                switch (str.Length)
                {
                    case 0:
                        result = "no one likes this";
                        break;
                    case 1:
                        result = $"{str[0]} likes this";
                        break;
                    case 2:
                        result = $"{str[0]} and {str[1]} like this";
                        break;
                    case 3:
                        result = $"{str[0]}, {str[1]} and {str[2]} like this";
                        break;
                    default:
                        result = $"{str[0]}, {str[1]} and {str.Length - 2} others like this";
                        break;
                }
                return result;
            }
        }
    }
}
