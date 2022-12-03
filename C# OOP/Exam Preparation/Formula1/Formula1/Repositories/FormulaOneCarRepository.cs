using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        private List<IFormulaOneCar> models;

        public FormulaOneCarRepository()
        {
            this.models = new List<IFormulaOneCar>();
        }

        public IReadOnlyCollection<IFormulaOneCar> Models
        {
            get
            {
                return models.AsReadOnly();
            }
            
        }

        public void Add(IFormulaOneCar car)
        {
            this.models.Add(car);
        }

        public IFormulaOneCar FindByName(string model)
       => this.models.FirstOrDefault(m => m.Model == model);

        public bool Remove(IFormulaOneCar car)
          => this.models.Remove(car);

    }
}
