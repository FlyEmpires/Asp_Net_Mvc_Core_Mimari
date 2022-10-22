using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeContent { get; set; }
        public string Recipeİngredient { get; set; }
        public string RecipeImage { get; set; }
        public string CategoryID { get; set; }
        public bool RecipeStatus { get; set; }
        public string UserName { get; set; }
        public DateTime RecipeDate { get; set; }
        public int RecipeRate { get; set; }
    }
}
