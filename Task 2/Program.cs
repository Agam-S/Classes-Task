using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person p1 = new Person("Agam", "Singh", "28/02/2003", 164);
            Person p2 = new Person("Steven", "Nguyen", "01/01/1999", 170);

            persons.Add(p1);
            persons.Add(p2);



            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(p2.Height);
            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p1.Height);
            System.Console.WriteLine("==========HEIGHT DIFFERENCE============");
            System.Console.WriteLine(p1.GetHeightDifference().Height);

        }
    }
}
