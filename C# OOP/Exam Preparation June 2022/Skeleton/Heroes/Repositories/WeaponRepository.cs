
namespace Heroes.Repositories
{
   
    using Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using Heroes.Models.Contracts;

    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly List<IWeapon> models;
        public WeaponRepository()
        {
            models = new List<IWeapon>();
        }
        public IReadOnlyCollection<IWeapon> Models => this.models.AsReadOnly();

        public void Add(IWeapon model)
        {
            models.Add(model);
        }

        public bool Remove(IWeapon model) => models.Remove(model);

        public IWeapon FindByName(string name) => models.FirstOrDefault(m => m.Name == name);


    }
}
