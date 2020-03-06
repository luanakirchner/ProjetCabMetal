using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabMetal
{
    class Controller
    {
        public static void characterController(string nom)
        {
            if (nom.IndexOf("%") > 0)
            {
                throw new ExceptionCaracterespeciaux("Pas des % permit");
            }  
        }
    }
}
