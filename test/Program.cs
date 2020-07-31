using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (int.TryParse("1", out int result))
            {
                Console.WriteLine(result);
            }
            
        }
    }
}