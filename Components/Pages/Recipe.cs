using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Components.Pages
{
    public partial class Recipe
    {
        public required List<Recipe> Recipes { get; set; }
        public required string Name { get; set; }
        public List<Ingredient> Ingredients { get; } = [];
    }
    //Connect to Open Food Facts API here? For Ingredients?
    public class Ingredient
    {
        public List<Recipe> Recipes { get; } = [];
    }
    //Above maps Recipes to Ingredients in many-to-many relationship.

    //public class Direction  

    ////    //Add directions as numbered list of Steps here, with output to Recipe.razor
    //{
    //      public  List<string> steps =
    //    [
    //        "Step 1",
    //        "Step 2",
    //        "Step 3"    
    //    ];

    //        for (int i = 0; i < /Steps.Count; i++)
    //        {
    //            Console.WriteLine($"{i + 1}. {items[i]}");
    //        }
    //    }
    //} 
}
