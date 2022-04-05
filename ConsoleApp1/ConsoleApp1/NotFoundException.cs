using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string msg):base(msg)
        {
        }
    }
}
