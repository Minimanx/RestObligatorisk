using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;

namespace RestObligatorisk.Managers
{
    public class FootballPlayerManager
    {
        private static int _nextId = 1;

        private static readonly List<FootballPlayer> Players = new List<FootballPlayer>
        {
            new FootballPlayer() {Id = _nextId++, Name = "Jørgen", Price = 999, ShirtNumber = 20}
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Players);
        }

        public FootballPlayer GetById(int id)
        {
            return Players.Find(player => player.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Id = _nextId++;
            Players.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Players.Find(playerToDelete => playerToDelete.Id == id);
            if (player == null) return null;
            Players.Remove(player);
            return player;
        }

        public FootballPlayer Update(int id, FootballPlayer updatedPlayer)
        {
            FootballPlayer player = Players.Find(playerToUpdate => playerToUpdate.Id == id);
            if (player == null) return null;
            player.Name = updatedPlayer.Name;
            player.Price = updatedPlayer.Price;
            player.ShirtNumber = updatedPlayer.ShirtNumber;
            return player;
        }
    }
}
