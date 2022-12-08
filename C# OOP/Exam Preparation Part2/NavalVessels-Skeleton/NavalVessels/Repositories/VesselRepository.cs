
namespace NavalVessels.Repositories
{
    using Contracts;
    using System.Collections.Generic;
    using NavalVessels.Models.Contracts;
    using System.Linq;

    public class VesselRepository : IRepository<IVessel>
    {
        private HashSet<IVessel> models;
        public VesselRepository()
        {
            models = new HashSet<IVessel>();
        }
        public IReadOnlyCollection<IVessel> Models => models;

        public void Add(IVessel vessel)
        {
           models.Add(vessel);
        }

        public IVessel FindByName(string name) => models.FirstOrDefault(v=>v.Name== name);
        

        public bool Remove(IVessel vessel) => models.Remove(vessel);
        
    }
}
