using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // DICTIONARY: LEGION NAME -> SOLDIER TYPE -> SOLDIER COUNT
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();
            //DICTIONARY: LEGION NAME -> LAST ACTIVITY
            var legionsWithActivity = new Dictionary<string, long>();

            //THE LOOP THAT GOES FROM 0 TO N TO READ N LINES
            for (int i = 0; i < n; i++)
            {
                string[] soldiersInfo = Console.ReadLine().Split(new char[] { '=', ' ', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                //EXTRACT THE DATA
                var lastActivity = int.Parse(soldiersInfo[0]);
                string legionName = soldiersInfo[1];
                string soldierType = soldiersInfo[2];
                var soldierCount = int.Parse(soldiersInfo[soldiersInfo.Length - 1]);

                //FIRST DICTIONARY
                if (!legionsWithSoldiers.ContainsKey(legionName))
                {
                    legionsWithSoldiers[legionName] = new Dictionary<string, long>();
                }
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName][soldierType] = 0;
                }

                legionsWithSoldiers[legionName][soldierType] += soldierCount;
                
                // SECOND DICTIONARY
                if (!legionsWithActivity.ContainsKey(legionName))
                {
                    legionsWithActivity.Add(legionName, lastActivity);
                }

                else
                {
                    if (lastActivity > legionsWithActivity[legionName])
                    {
                        legionsWithActivity[legionName] = lastActivity;
                    }
                }
            }
            //GET THE QUERY OF THE LAST LINE OF INPUT AFTER WE'VE PROCESSED ALL N INPUT LINES
            //SPLIT IT BY "\"
            //IF IT HAS 2 ELEMENTS THEN IT IS "activity\soldierType"
            //IF IT HAS 1 ELEMENT THEN IT IS "soldierType"

            string[] commandParams = Console.ReadLine().Split(new char[] { '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            

            if (commandParams.Length > 1)
            {
                var activity = int.Parse(commandParams[0]);
                string typeOfSoldier = commandParams[commandParams.Length - 1];
                //FILTER ALL LEGIONS
                //WHERE (TAKE) EVERY LEGION CONTAINS THE GIVEN SOLDIER TYPE
                //ORDER BY DESCENDING BY THE VALUE OF THE GIVEN SOLDIER TYPE
                foreach (var item in legionsWithSoldiers.Where(x => x.Value.ContainsKey(typeOfSoldier))
             .OrderByDescending(x => x.Value[typeOfSoldier]))
                {
                    //TAKE THE LEGION'S NAME AND CHECK IN THE DICTIONARY WITH ACTIVITIES
                    //IF ITS VALUE IS LOWER THAN THE GIVEN ACTIVITY, PRINT IT
                    if (legionsWithActivity[item.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, legionsWithSoldiers[item.Key][typeOfSoldier]);
                    }
                }
                                
            }
            else
            {
                string typeOfSoldier = commandParams[0];
                //THIS TIME FOREACH THE LEGIONS WITH ACTIVITY DICTIONARY
                //AND ORDER THEM DESCENDING BY VALUE (ACTIVITY)
                foreach (var item in legionsWithActivity.OrderByDescending(x => x.Value))
                {
                    //TAKE THE LEGION'S KEY (NAME) AND CHECK IN THE DICTIONARY WITH SOLDIER TYPES
                    //IF IT CONTAINS THE GIVEN SOLDIER TYPE
                    //IF YES, PRINT THE LEGION WITH ITS DATA
                    if (legionsWithSoldiers[item.Key].ContainsKey(typeOfSoldier))
                    {
                        Console.WriteLine("{0} : {1}", item.Value, item.Key);
                    }
                }
            }



        }
    }
}
