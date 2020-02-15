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
        private string places;

        public Catalogs (int id, string catalog)
        {
            this.id = id;
            this.catalog = catalog;
        }
        public Catalogs(string catalog)
        {
            this.catalog = catalog;
        }
        public Catalogs(string catalog,string places)
        {
            this.catalog = catalog;
            this.places = places;
        }

        public int Id { get => id;}
        public string Catalog { get => catalog;}
        public string Places { get => places;  }

        public override string ToString()
        {
            return catalog;
        }
    }
}
