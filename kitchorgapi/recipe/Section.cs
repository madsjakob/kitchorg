using System;

namespace kitchorgapi.recipe
{
    public class Section
    {
        // Name or description
        // A list of ingredients
        // A list of steps

        private StepList _steps;
        public StepList Steps 
        {
            get { return _steps; }
        }
    }
}