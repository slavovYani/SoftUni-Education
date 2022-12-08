

namespace Heroes.Repositories
{
    using Heroes.Models;
    using Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using Heroes.Models.Contracts;

    public class HeroRepository : IRepository<IHero>
    {
        private readonly List<IHero> models;


        public HeroRepository()
        {
            this.models = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Models => this.models.AsReadOnly();

        public void Add(IHero model)
        {
            models.Add(model);
        }
        public bool Remove(IHero model) => models.Remove(model);
        

        public IHero FindByName(string name) => models.FirstOrDefault(m=>m.Name == name);
        

    }
}
