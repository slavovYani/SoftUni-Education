using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class PilotRepository : IRepository<IPilot>
    {
        private HashSet<IPilot> models;

        public PilotRepository()
        {
            this.models = new HashSet<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Models
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

        public void Add(IPilot pilot)
        {
            this.models.Add(pilot);
        }

        public IPilot FindByName(string fullName)
        => this.models.FirstOrDefault(m => m.FullName == fullName);

        public bool Remove(IPilot pilot)
        => this.models.Remove(pilot);
    }
}
