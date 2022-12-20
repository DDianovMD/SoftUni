using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private List<IMilitaryUnit> models;

        public UnitRepository()
        {
            this.models = new List<IMilitaryUnit>();
        }

        public IReadOnlyCollection<IMilitaryUnit> Models => this.models.AsReadOnly();    

        public IMilitaryUnit FindByName(string unitTypeName)
        {
            return this.Models.FirstOrDefault(x => x.GetType().Name == unitTypeName);
        }

        public void AddItem(IMilitaryUnit unit)
        {
            this.models.Add(unit);
        }

        public bool RemoveItem(string unitTypeName)
        {
            int removedUnitsCount = this.models.RemoveAll(x => x.GetType().Name == unitTypeName);

            if (removedUnitsCount == 0)
            {
                return false;
            }

            return true;
        }
    }
}
