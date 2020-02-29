using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabMetal
{
    class ExecpetionCode : Exception
    {
        public ExecpetionCode(string message) : base(message)
        {

        }
    }
}
