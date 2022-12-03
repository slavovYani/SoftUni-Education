
namespace Formula1.Repositories
{
    using Formula1.Models;
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class RaceRepository : IRepository<IRace>
    {
        private HashSet<IRace> models;
        public RaceRepository()
        {
            models = new HashSet<IRace>();
        }
        public IReadOnlyCollection<IRace> Models
        {
            get
            {
                return models;
            }
            private set
            {
                this.models = value.ToHashSet();
            }

        }

        public void Add(IRace race)
        {
            this.models.Add(race);
        }

        public IRace FindByName(string raceName)
        => this.models.FirstOrDefault(m => m.RaceName == raceName);

        public bool Remove(IRace race)
        => this.models.Remove(race);
    }
}
