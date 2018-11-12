using System;
using System.Collections.Generic;

namespace kitchorgapi.recipe
{
    public class Ingredient
    {
        public Unit Unit { get; set; }
        public double Amount { get; set; }
        public string Name { get; set;}
    }

    public class IngredientList : List<Ingredient>
    {
    
    }
}