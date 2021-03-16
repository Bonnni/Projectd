using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IPlayers
    {
        ICollection<Player> GetAllPlayers();
        Player PlayerById(int id);
        void PlayerDelete(int id);
        void PlayerSave(Player player);
        void PlayerCreate(Player player);
    }
}
