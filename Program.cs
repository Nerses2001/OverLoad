using System;
using System.Linq;

namespace OverLoad
{
    internal class Program
    {
        static void Main()
        {
            int[] number = { 1, 5, 6, 9, 2, 5 };
            var query = from n in number
                        where n > 3
                        select n.ToString();
      
       
            Console.ReadKey();  
        
        }

      
    }
}
