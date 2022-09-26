using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecryptConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i != 0)
            {
                //var input = "Data Source=INHY-DDB-FIT01;Initial Catalog=Conflator;Persist Security Info=True;User Id=sa;Password=@WSX1qaz;MultipleActiveResultSets=True";
                Console.WriteLine("\nInput : ");
                var input = Console.ReadLine();
                var output = EncryptDecrypt.Encrypt(input);
                Console.WriteLine("\nOutput : \n" + output);
                Console.WriteLine("\nPress 1 to continue and press 0 to exit...");
                var option = Console.ReadLine();
                i = Convert.ToInt32(option);
            }
        }
    }
}
