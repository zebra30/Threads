using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Threading
{
    public class Program
    {
        public void Main(string[] args)
        {
            AnotherTask("ASDFASDF");
        }

        private void SpinUpTask()
        {
            Console.WriteLine("New  Task");
        }

        private void AnotherTask(string myString)
        {
            Task t = Task.Factory.StartNew((object lString) =>
                    {
                        Console.WriteLine(lString);
                    }
            , (String)myString);


            t.Wait();

          //dddd

        }
    }
}
