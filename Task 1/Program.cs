using System;
using System.Collections.Generic;

namespace Classes
{       class Program {
        static void Main(string[] args)
        {
            List<Color> colors = new List<Color>();
            Color CL1 = new Color(21, 31, 15, "Brown");
            Color CL2 = new Color(21, 21, 10, "Light Brown");
            Color CL3 = new Color(21, 41, 20, "Dark Brown");

            colors.Add(CL1);
            colors.Add(CL2);
            colors.Add(CL3);

            List<Cookie> cookies = new List <Cookie>();
            Cookie C1 = new Cookie(5, "Round", CL1);
            Cookie C2 = new Cookie(3, "Square", CL3);
            Cookie C3 = new Cookie(4, "Round", CL1);
            Cookie C4 = new Cookie(5, "Square", CL2);

            cookies.Add(C1);
            cookies.Add(C2);
            cookies.Add(C3);
            cookies.Add(C4);


            System.Console.WriteLine("Cookie 1's weight is: " + C1.Weight);
            System.Console.WriteLine("Cookie 2's Shape is: " + C2.Shape);
            System.Console.WriteLine("Cookie 3's color name is: " + C3.color.colorName);
            System.Console.WriteLine("Cookie 4's RGB colors are: " + C4.color.Red + " " + C4.color.Green + " " + C4.color.Blue);

 
        }
    
}
}
