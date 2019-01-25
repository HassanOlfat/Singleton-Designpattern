using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static async Task<int> Fun1Task()
        {
            await Setting.getinstance();
            await Setting.getinstance();
            return 1;
        }

        static  void Main(string[] args)
        {
            Fun1Task();
            Console.WriteLine("Singleton design pattern");
            Console.ReadKey();
        }
    }
}
