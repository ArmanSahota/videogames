using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogames
{
    internal class GameStore
    {
        private List<VideoGame> _games;

        public GameStore()
        {
            _games = new List<VideoGame>();
        }

        public IReadOnlyList<VideoGame> Games
        {
            get { return _games.AsReadOnly(); }
        }

        public void AddGame(VideoGame game)
        {
            _games.Add(game);
        }

        public void RemoveGame(VideoGame game)
        {
            _games.Remove(game);
        }

        public void ListAllGames()
        {
            foreach (var game in _games)
            {
                Console.WriteLine(game);
            }
        }

        public override string ToString()
        {
            return $"There are {_games.Count} games in the store.";
        }
    }

}

