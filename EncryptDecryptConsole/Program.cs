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
            var input = "Data Source=INHY-DDB-FIT01;Initial Catalog=Conflator;Persist Security Info=True;User Id=sa;Password=@WSX1qaz;MultipleActiveResultSets=True";
            var output = EncryptDecrypt.Encrypt(input);
            Console.WriteLine(output);
        }
    }
}
