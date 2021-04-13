using GamingApp.Entities;

namespace GamingApp.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
