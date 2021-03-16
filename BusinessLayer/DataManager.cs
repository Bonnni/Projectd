using BusinessLayer.Interfaces;

namespace BusinessLayer
{
    public class DataManager
    {
        private IPlayers _Players;
        private ITeams _Teams;
        public DataManager(ITeams Teams, IPlayers Players)
        {
            _Teams = Teams;
            _Players = Players;
        }

        public ITeams Teams => _Teams;

        public IPlayers Players => _Players;
    }
}
