using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // methode TimesThree herschreven als lambda-expressie
            Func<int, int> timesThree = x => 3 * x;

            output.AppendFormat("TimesThree({0}) = {1}\n", num1, timesThree(num1));

            Func<int, int, int, int> addNumbers = delegate (int a, int b, int c)
            {
                return a + b + c;
            };

            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2, num3, addNumbers(num1, num2, num3));

            Func<int, bool> isEven = x => x % 2 == 0;

            output.AppendFormat("IsEven({0}) = {1}\n", num1, isEven(num1));

            Func<int, String> num2String = delegate (int x)
            {
                switch (x)
                {
                    case 0:
                        return "zero"; break;
                    case 1:
                        return "one"; break;
                    case 2:
                        return "two"; break;
                    case 3:
                        return "three"; break;
                    case 4:
                        return "four"; break;
                    case 5:
                        return "five"; break;
                    case 6:
                        return "six"; break;
                    case 7:
                        return "seven"; break;
                    case 8:
                        return "eight"; break;
                    case 9:
                        return "nine"; break;
                    default:
                        return "undefined"; break;
                }
            };

            output.AppendFormat("Num2String({0}) = {1}\n", num1, num2String(num1));

            Func<int, int, int, bool> inBetween = delegate (int x, int y, int z)
            {
                return (x < y && y < z) || (z < y && y < x);
            };

            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, inBetween(num1, num2, num3));

            Person p = new Person { Name = "Jan" };

            Action<Person> resetName = x => x.Name = null;

            resetName(p);

            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);

            return output.ToString();
        }

    }
}
