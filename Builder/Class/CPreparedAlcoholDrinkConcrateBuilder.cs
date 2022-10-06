using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public class CPreparedAlcoholDrinkConcrateBuilder : IBuilder
    {
        private CPreparedDrink _prepareDrink;

        public CPreparedAlcoholDrinkConcrateBuilder()
        {
            Reset();
        }

        public void AddIngredients(string ingredients)
        {
            if (_prepareDrink.Ingredients == null)
                _prepareDrink.Ingredients = new List<string>();

            _prepareDrink.Ingredients.Add(ingredients);
        }

        public void Mix()
        {
            string ingredients = _prepareDrink.Ingredients.Aggregate((i, j) => i + ", " + j);
            _prepareDrink.Result = $"Bebida preparada con {_prepareDrink.Alcohol} de alcohol" +
                $"con los siguiente ingredientes; {ingredients}";
            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Reset()
        {
            _prepareDrink = new CPreparedDrink();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beber");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _prepareDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _prepareDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _prepareDrink.Water = water;
        }

        public CPreparedDrink GetPreparedDrink() => _prepareDrink;
    }
}
