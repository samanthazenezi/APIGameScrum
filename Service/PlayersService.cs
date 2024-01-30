using GameScrum.Api.Models;

namespace GameScrum.Api.Service
{
    public class PlayersService
    {
        public List<PlayerModel> listPlayers;

        public PlayersService()
        {
            listPlayers = new List<PlayerModel>();
        }
    }
}
