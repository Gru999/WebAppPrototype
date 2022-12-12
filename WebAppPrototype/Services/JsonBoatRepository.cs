using WebAppPrototype.Helpers;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Services
{
    public class JsonBoatRepository : IBoatRepository {
        string jsonFileName = @"JsonData\JsonBoats.json";

        private List<Boat> _boats;

        public void AddBoat(Boat bo)
        {
            throw new NotImplementedException();
        }

        public List<Boat> GetAllBoats()
        {
            return JsonFileReader.ReadJsonBoats(jsonFileName);
        }

        public Boat GetBoat(int boatId)
        {
            foreach (Boat b in GetAllBoats())
            {
                if (b.BoatId == boatId)
                    return b;
            }
            return new Boat();
        }
    }
}
