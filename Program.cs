using AccountApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AccountControler manager = new AccountControler();
            manager.Run();
        }
    }
}
