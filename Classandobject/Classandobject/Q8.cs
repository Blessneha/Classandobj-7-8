using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classandobject
{
    
    internal class Q8
    {
        public int rollno;
        public string studname;
        public int markineng;
        public int markinmaths;
        public int markinscience;


        public Q8(int roll, string name,int eng,int math,int science)
        {
            rollno = roll;
            studname = name;
            markineng = eng;
            markinmaths = math;
            markinscience = science;
        }

        public void Total()
        {
            int tot = markineng + markinmaths + markinscience;
            Console.WriteLine(tot);
        }

        public void Percentage()
        {
            int f = markineng;
            int s = markinmaths;
            int t = markinscience;
            
            Console.WriteLine("Percentage: " + (f + s + t) / 3);
        }

    }

}
