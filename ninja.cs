class Ninja
{
 private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    public bool IsFull
    {
        get { return calorieIntake > 1200; }
    }

    public void Eat(Food item)
    {
        if (!IsFull)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);

            Console.WriteLine($"Ninja is eating {item.Name}. Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
        }
        else
        {
            Console.WriteLine("Ninja is full and cannot eat more.");
        }
    }
}

