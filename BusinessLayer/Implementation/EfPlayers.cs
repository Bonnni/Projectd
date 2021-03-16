using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Implementation
{
    public class EfPlayers : IPlayers
    {
        private readonly EFDBContext _context;

        public EfPlayers(EFDBContext context)
        {
            _context = context; 
        }

        public ICollection<Player> GetAllPlayers()
        {
            return _context.Players.Include(x => x.Team).ToList();
        }

        public Player PlayerById(int id)
        {
            return _context.Players.FirstOrDefault(x => x.Id == id);
        }

        public void PlayerDelete(int id)
        {
            _context.Players.Remove(_context.Players.Find(id));
            _context.SaveChanges();
        }

        public void PlayerSave(Player player)
        {
            var emp = _context.Players.Find(player);
            emp.FirstName = player.FirstName;
            emp.LastName = player.LastName;
            emp.BirthDay = player.BirthDay;
            emp.Gender = player.Gender;
            emp.TeamId = player.TeamId;
            emp.Country = player.Country;
            

            _context.Update(emp);
            _context.SaveChanges();
        }

        public void PlayerCreate(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }
    }
}
