using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkList
{
    class Program
    {
        static void Main(string[] args)
        {


            List<double> lst = new List<double>();

 
            System.Collections.Generic.IList<double> ilst = lst;

            Console.WriteLine(ilst.Remove(2)); 
            ilst.RemoveAt(0);


            ilst.Add(1);

            Console.WriteLine(ilst.Remove(1)); 
            Console.WriteLine(ilst.Remove(3)); 
            ilst.RemoveAt(0);
            ilst.RemoveAt(2);


            ilst.Clear();



            ilst.Add(1);
            ilst.Add(2);
            ilst.Add(3);

            Console.WriteLine(ilst.Remove(1));
            Console.WriteLine(ilst.Remove(3));
            ilst.RemoveAt(0);
            ilst.RemoveAt(2);

            ilst.RemoveAt(0);




            Console.ReadLine();
        }
    }
}
