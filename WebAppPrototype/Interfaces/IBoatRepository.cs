using WebAppPrototype.Models;

namespace WebAppPrototype.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();
        Boat GetBoat(string boatName);

        void AddBoat(Boat bo);
    }
}
