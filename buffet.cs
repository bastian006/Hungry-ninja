class Buffet
{
public List<Food> Menu;

    public Buffet()
    {
        Menu = new List<Food>
        {
            new Food("Sushi", 400, true, false),
            new Food("Pizza", 800, false, true),
            new Food("Burger", 1200, false, false),
            new Food("Taco", 500, true, false),
            new Food("Ice Cream", 600, false, true),
            new Food("Salad", 300, false, false),
            new Food("Curry", 900, true, false)
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, Menu.Count);
        return Menu[randomIndex];
    }
}

