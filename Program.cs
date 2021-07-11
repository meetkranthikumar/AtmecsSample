using System;
using System.Collections.Generic;

namespace AtmecsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventsList = new List<Action>();
            eventsList.Add(() =>
            {
                Console.WriteLine("Action 1");
            });
            eventsList.Add(() =>
            {
                Console.WriteLine("Action 2");
            });
            eventsList.Add(() =>
            {
                Console.WriteLine("Action 3");
            });

            var obj = new CustomEventsClass();
            obj.RunActions(eventsList);
            Console.ReadKey();
        }
    }
}
