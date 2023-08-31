using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorOperatorPrac
{
    internal class Program
    {
        public delegate void SendString(string messge);

        static void Main(string[] args)
        {
            SendString seyHello;
        }
    }
}
