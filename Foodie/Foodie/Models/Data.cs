using System.Collections.Generic;
using System.Linq;

namespace Foodie.Models
{
    class Data
    {
        public static readonly Recipe[] Recipes =
        {
            new Recipe{ Name = "Lasagnia", MealType = "Dinner", Difficulty = "Hard"},
            new Recipe{ Name = "Blueberry Muffins", MealType = "Breakfast", Difficulty = "Medium"},
            new Recipe{ Name = "Burger", MealType = "Dinner", Difficulty = "Medium"},
            new Recipe{ Name = "Qunioa Salad", MealType = "Lunch", Difficulty = "Easy"},
            new Recipe{ Name = "Carrot Cake", MealType = "Breakfast", Difficulty = "Medium"},
            new Recipe{ Name = "Oatmeal", MealType = "Breakfast", Difficulty = "Easy"},
            new Recipe{ Name = "Smoothie", MealType = "Breakfast", Difficulty = "Easy"},
        };

        public static IEnumerable<ListViewGrouping<Recipe>> GroupedRecipes { get; } = new[]
        {
            new ListViewGrouping<Recipe>("Easy", "E", Recipes.Where(r => r.Difficulty == "Easy")),
            new ListViewGrouping<Recipe>("Medium", "M", Recipes.Where(r => r.Difficulty == "Medium")),
            new ListViewGrouping<Recipe>("Hard", "H", Recipes.Where(r => r.Difficulty == "Hard")),
        };
    }
}
