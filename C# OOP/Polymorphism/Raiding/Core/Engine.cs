
namespace Raiding.Core
{
    using System.Collections.Generic;
    using System.Linq;

    using Factories.Interfaces;
    using IO;
    using Exceptions;
    using Raiding.Interfaces;
    using Models;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IBaseHeroFactory BaseHeroFactory;

        private readonly ICollection<IBaseHero> heroes;

        private Engine()
        {
            this.heroes = new HashSet<IBaseHero>();
        }
        public Engine(IReader reader, IWriter writer, IBaseHeroFactory baseHeroFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            BaseHeroFactory = baseHeroFactory;
        }


        public void Run()
        {
            int lines = int.Parse(reader.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string heroName = reader.ReadLine();
                string heroType = reader.ReadLine();

                try
                {
                    BaseHero currentHero = BaseHeroFactory.CreateHero(heroType, heroName);

                    if (currentHero != null)
                    {
                        heroes.Add(currentHero);
                        

                    }

                }
                catch (InvalidHeroException ihe)
                {
                    i--;
                    writer.WriteLine(ihe.Message);
                   
                }



            }
            int heroesPower = 0;

            if (heroes.Any())
            {
                heroesPower = heroes.Sum(h => h.Power);

                foreach (var currentHero in heroes)
                {
                    writer.WriteLine(currentHero.CastAbility());
                }

            }

            int enemyPower = int.Parse(reader.ReadLine());


            writer.WriteLine(heroesPower >= enemyPower ? "Victory!" : "Defeat...");


        }
    }
}
