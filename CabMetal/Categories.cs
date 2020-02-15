using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabMetal
{
    class Categories
    {
        private int id;
        private string categorie;

        public Categories(int id, string categorie)
        {
            this.id = id;
            this.categorie = categorie;
        }
        public Categories(string categorie)
        {

            this.categorie = categorie;
        }

        public int Id { get => id; }
        public string Categorie { get => categorie; }

        public override string ToString()
        {
            return categorie;
        }
    }
}
