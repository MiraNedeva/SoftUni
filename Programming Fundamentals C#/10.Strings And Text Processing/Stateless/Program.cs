using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* You will be given groups of 2 strings, each on a new line. There will ALWAYS be at least 2 input lines, and there will
NEVER be a case when there are less than 2 input strings, for a given element of the input.
Now to the main logic – the elements of the input. You can refer to the elements of the input as states.
Each state also has a fiction – the collapsing factor. Your task is to collapse each state, by its given fiction.
The collapsing is done by removing all occurrences of the fiction in the state, and after that – removing the first and 
last element of the fiction. You must then repeat the process, until the fiction’s length becomes 0. 
When you finish the process, you must print what is left from the state. If the state is also empty, you should print 
“(void)”. NOTE: Border spaces should be removed.
Both the state and the fiction are strings, and will be given each on a separate line. You must read sequences of DOUBLE 
lines, and print the result from the collapsing, until you receive the command “collapse”.*/

namespace Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();
            var result = new List<string>();

            while (state != "collapse")
            {
                string fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    var found = state.IndexOf(fiction);

                    if (found >= 0)
                    {
                        state = state.Remove(found, fiction.Length);
                        if (state.Length == 0)
                        {
                            result.Add("(void)");
                            break;
                        }
                    }
                    else
                    {
                        if (fiction.Length > 2)
                        {
                            fiction = fiction.Substring(1, fiction.Length - 2);
                        }
                        else
                        {
                            result.Add(state);

                            if (fiction.Length == 2)
                            {
                                fiction = fiction.Remove(0, 2);
                            }
                            else if (fiction.Length == 1)
                            {
                                fiction = fiction.Remove(0, 1);
                            }
                        }
                    }
                }

                state = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}