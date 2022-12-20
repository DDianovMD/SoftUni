using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> models;

        public WeaponRepository()
        {
            this.models = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => this.models.AsReadOnly();

        public IWeapon FindByName(string weaponTypeName)
        {
            return this.Models.FirstOrDefault(x => x.GetType().Name == weaponTypeName);
        }

        public void AddItem(IWeapon weapon)
        {
            this.models.Add(weapon);
        }

        public bool RemoveItem(string weaponTypeName)
        {
            int removedWeaponsCount = this.models.RemoveAll(x => x.GetType().Name == weaponTypeName);

            if (removedWeaponsCount == 0)
            {
                return false;
            }

            return true;
        }
    }
}
