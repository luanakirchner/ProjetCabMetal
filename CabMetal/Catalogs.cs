using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabMetal
{
    class Catalogs
    {
        private int id;
        private string catalog;

        public Catalogs (int id, string catalog)
        {
            this.id = id;
            this.catalog = catalog;
        }
        public Catalogs(string catalog)
        {
            this.catalog = catalog;
        }

        public int Id { get => id;}
        public string Catalog { get => catalog;}

        public override string ToString()
        {
            return catalog;
        }
    }
}
