using System.Collections.Generic;
using System.Linq;

namespace Foodie.Models
{
    class Data
    {
        public static readonly Recipe[] Recipes =
        {
            new Recipe{ Name = "Lasagnia", MealType = "Dinner", Difficulty = "Hard", PrepTime = "10 min"},
            new Recipe{ Name = "Blueberry Muffins", MealType = "Breakfast", Difficulty = "Medium" , PrepTime = "20 min"},
            new Recipe{ Name = "Burger", MealType = "Dinner", Difficulty = "Medium" , PrepTime = "34 min"},
            new Recipe{ Name = "Qunioa Salad", MealType = "Lunch", Difficulty = "Easy", PrepTime = "8 min"},
            new Recipe{ Name = "Carrot Cake", MealType = "Breakfast", Difficulty = "Medium", PrepTime = "15 min"},
            new Recipe{ Name = "Oatmeal", MealType = "Breakfast", Difficulty = "Easy", PrepTime = "5 min"},
            new Recipe{ Name = "Smoothie", MealType = "Breakfast", Difficulty = "Easy", PrepTime = "3 min"},
        };

        public static IEnumerable<ListViewGrouping<Recipe>> GroupedRecipes { get; } = new[]
        {
            new ListViewGrouping<Recipe>("Easy", "E", Recipes.Where(r => r.Difficulty == "Easy")),
            new ListViewGrouping<Recipe>("Medium", "M", Recipes.Where(r => r.Difficulty == "Medium")),
            new ListViewGrouping<Recipe>("Hard", "H", Recipes.Where(r => r.Difficulty == "Hard")),
        };
    }
}
