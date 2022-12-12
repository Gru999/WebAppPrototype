using WebAppPrototype.Models;

namespace WebAppPrototype.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();
        Boat GetBoat(int id);

        void AddBoat(Boat bo);

       
    }
}
