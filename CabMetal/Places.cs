using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabMetal
{
    class Places
    {
        private int id;
        private string place;

        public Places(int id, string place)
        {
            this.id = id;
            this.place = place;
        }
        public Places(string place)
        {
          
            this.place = place;
        }
        public int Id { get => id; }
        public string Place { get => place;}

        public override string ToString()
        {
            return place;
        }
    }
}
