using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Console.WriteLine(string.Join("\n", result));
        }
    }
}