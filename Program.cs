using videogames;

class Program
{
    static void Main(string[] args)
    {
        GameStore gameStore = new GameStore();
        Console.WriteLine(gameStore);

        VideoGame game1 = new VideoGame("The Last of Us Part II", "Sony", 2020, true, 49.99);
        VideoGame game2 = new VideoGame("Red Dead Redemption 2", "Rockstar", 2018, false, 59.99);
        VideoGame game3 = new VideoGame("Breath of the Wild", "Nintendo", 2017, true, 39.99);
        gameStore.AddGame(game1);
        gameStore.AddGame(game2);
        gameStore.AddGame(game3);

        Console.WriteLine(gameStore);
        gameStore.ListAllGames();

        gameStore.RemoveGame(game2);
        Console.WriteLine(gameStore);


        Console.WriteLine("   ");
        Console.WriteLine("   ");
        Console.WriteLine("   ");

        Apple_Orchard orchard = new Apple_Orchard("Green Valley Orchard", 100);
        Console.WriteLine(orchard); // Green Valley Orchard - Number of Apples: 100

        orchard.PickApples(50);
        Console.WriteLine(orchard); // Green Valley Orchard - Number of Apples: 150

        orchard.SellApples(20);
        Console.WriteLine(orchard); // Green Valley Orchard - Number of Apples: 130

        orchard.SellApples(-10);
        Console.WriteLine(orchard); // Green Valley Orchard - Number of Apples: 130

        Console.ReadLine();



    }
}