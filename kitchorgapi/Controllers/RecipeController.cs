using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kitchorgapi.recipe;
using Microsoft.AspNetCore.Mvc;

namespace kitchorgapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {

        private static Recipe Mock()
        {
            Recipe result = new Recipe 
                { 
                    Title = "Rugbrød", 
                    Description = "Min fars opskrift",
                };

            Section dag1 = new Section 
                {
                    Name = "Dag 1"
                };

            Ingredient surdej = new Ingredient { Unit = Unit.Stk, Amount = 1, Name = "Surdej" };
            dag1.Ingredients.Add(surdej);
            Ingredient vand = new Ingredient { Unit = Unit.Deciliter, Amount = 8.25d, Name = "Vand" };
            dag1.Ingredients.Add(vand);
            Ingredient rugmel = new Ingredient { Unit = Unit.Gram, Amount = 350, Name = "Rugmel" };
            dag1.Ingredients.Add(rugmel);
            Ingredient hvedemel = new Ingredient { Unit = Unit.Gram, Amount = 300, Name = "Hvedemel" };
            dag1.Ingredients.Add(hvedemel);
            Ingredient rugkerner = new Ingredient { Unit = Unit.Gram, Amount = 100, Name = "Rugkerner" };
            dag1.Ingredients.Add(rugkerner);
            Ingredient salt = new Ingredient { Unit = Unit.Tablespoon, Amount = 3, Name = "Salt" };
            dag1.Ingredients.Add(salt);
            result.Sections.Add(dag1);
            Section dag2 = new Section 
                {
                    Name = "Dag 2"
                };
            result.Sections.Add(dag2);
            return result;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> Get()
        {
            return new Recipe[] 
            { 
                Mock()
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
