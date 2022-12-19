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

        public Boat GetBoat(string boatName)
        {
            foreach (Boat b in GetAllBoats())
            {
                if (b.BoatName == boatName)
                    return b;
            }
            return new Boat();
        }
    }
}
