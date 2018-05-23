namespace Foodie.Models
{
    class Recipe
    {
        public string Name { get; set; }

        public string MealType { get; set; }

        public string Difficulty { get; set; }

        public string PrepTime { get; set; }

        public string ImageName { get; set; } = "bb-muffin.jpg";
    }
}
