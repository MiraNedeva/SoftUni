using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* IT Researchers at the MIT (Massachusetts Institute of Technology) have discovered that, at certain (room) temperatures, the lambda expressions in their code are acting strange. In particular, a dancing behavior has been observed in them. The specialists choose to call this phenomenon – The Lambada expressions.
You will be given several input lines in the following format:
{selector} => {selectorObject}.{property}
All elements of the input are strings. You need to store every lambada expression, as it is given.
In some rare cases you will receive the input “dance”, which indicates that the lambada expressions are starting to dance. When that happens, you must COPY the selectorObject ONCE with a dot (“.”) between it., so that it becomes “{selectorObject}.{selectorObject}”
in every lambada expression’s condition. 
In other words, if you have “x => x.Value”, and you say “dance”, you should get “x => x.x.Value”.
Check the examples for more info.
If you meet a selectorObject which already, you must replace its property with the given new one.
When you receive the command “lambada” you must end the input sequence. When that happens, you must print all lambada expressions.
Exemples:
Input	                              Output
x => x.Key                         lambada	x => x.Key
object => object.Property          object => object.Property
entry => entry.Name                entry => entry.Name

*/

namespace LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var expressions = new Dictionary<string, Dictionary<string,string>>();

            while (input != "lambada")
            {
              
                    string[] inputLine = input.Split(new char[] {' ','=','>','.'}, StringSplitOptions.RemoveEmptyEntries);

                    if (inputLine.Length > 1)
                    {
                        string selector = inputLine[0];
                        string selectorObject = inputLine[1];
                        string property = inputLine[2];

                        if (!expressions.ContainsKey(selector))
                        {
                            expressions[selector] = new Dictionary<string, string>();
                        }
                        expressions[selector][selectorObject] = property;
                    }
                else
                {
                    expressions = expressions
                   .ToDictionary(selector => selector.Key, x => x.Value
                   .ToDictionary(selectorObject => selectorObject.Key, 
                   selectorObject => selectorObject.Key + "." + selectorObject.Value));

                }
                input = Console.ReadLine();
            }

            foreach (var selector in expressions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}", selector.Key, selectorObject.Key, selectorObject.Value);
                }
            }

     }
   }
 }

