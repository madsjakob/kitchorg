using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace kitchorgapi.recipe
{
    public class Ingredient
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Unit Unit { get; set; }
        public double Amount { get; set; }
        public string Name { get; set;}
        public string Category { get; set; }
    }

    public class IngredientList : List<Ingredient>
    {
    
    }
}