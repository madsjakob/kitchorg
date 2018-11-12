using System;

namespace kitchorgapi.recipe
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private SectionList _sections = new SectionList();
        public SectionList Sections 
        {
            get { return _sections; }
        }
    }
}