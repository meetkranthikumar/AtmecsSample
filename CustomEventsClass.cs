using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AtmecsSample
{
    public class CustomEventsClass
    {
        public async void RunActions(IEnumerable<Action> actions)
        {
            foreach (var action in actions)
            {
                await Task.Delay(1200);
                await Task.Run(action);
                Console.WriteLine($"Completed on thread:{Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
