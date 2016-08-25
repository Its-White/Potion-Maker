using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionMaker
{
    class Recipe
    {
        public List<string> ingredients = new List<string>();
        public Recipe() { }
        public Recipe(string[] ingredient) { ingredients.AddRange(ingredient); }
    }
}
