using System;
using System.Collections.Generic;

namespace kitchorgapi.recipe
{
    public class Section
    {
        public string Name { get; set; }
        // Name or description
        // A list of ingredients
        // A list of steps
        private IngredientList _ingredients = new IngredientList();
        public IngredientList Ingredients 
        {
            get { return _ingredients; }
        }

        private StepList _steps = new StepList();
        public StepList Steps 
        {
            get { return _steps; }
        }
    }

    public class SectionList : List<Section>
    {
    }
}