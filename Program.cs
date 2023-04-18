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
    }
}