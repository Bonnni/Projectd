using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Interfaces;
using DataLayer.Entities;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BusinessLayer.Implementation
{
    public class EfTeams : ITeams
    {
        private readonly EFDBContext _context;

        public EfTeams(EFDBContext context)
        {
            _context = context;
        }

        public ICollection<Team> GetAllTeams()
        {
            return _context.Teams.Select(x => x).ToList();
        }

        public Team TeamById(int id)
        {
            return _context.Teams.FirstOrDefault(x => x.Id == id);
        }

        public void TeamDelete(Team Team)
        {
            _context.Teams.Remove(Team);
            _context.SaveChanges();
        }

        public void TeamSave(Team team)
        {
            _context.Update(team);
            _context.SaveChanges();
        }

        public void TeamCreate(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
        }
    }
}
