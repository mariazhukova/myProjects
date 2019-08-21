using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Cake
    {
        public Filling Filling{ get; set; }
        public Addengs Addengs { get; set; }
        public Pastry Pastry { get; set; }
        public Decoration Decoration { get; set; }

        public string GetIngredients()
        {
            return String.Format("Ingredients is {0}, {1}, {2}, {3}", Pastry?.Name, Filling?.Name, Addengs?.Name, Decoration?.Name);
        }

    }
}
