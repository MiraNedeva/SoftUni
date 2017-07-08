using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

