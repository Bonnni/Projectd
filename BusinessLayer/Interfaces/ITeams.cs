using DataLayer.Entities;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface ITeams
    {
        ICollection<Team> GetAllTeams(); 
        Team TeamById(int id);
        void TeamDelete(Team Team);
        void TeamSave(Team team);
        void TeamCreate(Team team);
    }
}
