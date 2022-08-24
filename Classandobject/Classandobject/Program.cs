using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classandobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Q7 q7 = new Q7();
               q7.initial("gr", 12345, "savings", 1000);
               q7.deposit(1000);
               q7.display();  */

            Q8 q8 = new Q8(2, "DB", 88, 65, 89);
            q8.Total();
            q8.Percentage();
            
        }
    }
}
