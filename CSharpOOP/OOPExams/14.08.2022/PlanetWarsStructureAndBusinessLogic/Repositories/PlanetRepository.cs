using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> models;

        public PlanetRepository()
        {
            this.models = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.models.AsReadOnly();

        public void AddItem(IPlanet planet)
        {
            this.models.Add(planet);
        }

        public IPlanet FindByName(string name)
        {
            return this.Models.FirstOrDefault(x => x.Name == name);
        }

        public bool RemoveItem(string planetName)
        {
            int removedPlanetsCount = this.models.RemoveAll(x => x.Name == planetName);

            if (removedPlanetsCount == 0)
            {
                return false;
            }

            return true;
        }
    }
}
