
namespace BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BorderControl.Models.Interfaces;
    using IO;
    using Models;
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        //private readonly Citizen citizen = new Citizen();  // trying to set instance of object without going trhrough empty constructor.
        //private readonly Robot robot = new Robot();

        private List<Citizen> citizens;
        private List<Robot> robots;

        private IIdentity identity;
        private List<IIdentity> identities;
        private IBirthDay birth;
        private List<IBirthDay> personsBirth;

        private List<Rebel> rebels;


        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;

            this.citizens = new List<Citizen>();
            this.robots = new List<Robot>();
            this.identities = new List<IIdentity>();

            this.personsBirth = new List<IBirthDay>();

            this.rebels = new List<Rebel>();

        }

        public void Run()
        {
            int numberOfLines = int.Parse(reader.ReadLine());

            string command;

            for (int i = 0; i < numberOfLines; i++)
            {
                command = reader.ReadLine();

                SplitTheCommand(command);


            }
            int totalFood = 0;
            int totalFoodRebel= 0;

            string buyer;

            while ((buyer = reader.ReadLine()) != "End")
            {
                
                var currentCitizen = citizens.FirstOrDefault(p => p.Name == buyer);

                if (currentCitizen != null)  currentCitizen.BuyFood();

                var currentRebel = rebels.FirstOrDefault(p => p.Name == buyer);

                if (currentRebel != null)  currentRebel.BuyFood();


            }

            foreach (var citizen in citizens)
            {
                totalFood += citizen.Food;

            }
            foreach (var rebel in rebels)
            {
                totalFood += rebel.Food;
            }

            writer.WriteLine((totalFood).ToString());

            //string lastDigits = reader.ReadLine();


            //int counter = 0;

            //foreach (var identity in personsBirth)
            //{
            //    if (identity.BirthDay.EndsWith(lastDigits))
            //    {
            //        writer.WriteLine(identity.BirthDay);
            //        //counter++;

            //    }

            //}

            //if (counter == 0) writer.WriteLine("<empty output>");




        }
        //private void Print(IBirthDay birthDay, string lastDigits)
        //{
        //    if (birthDay.BirthDay.EndsWith(lastDigits)) writer.WriteLine(birthDay.BirthDay);

        //}
        private void SplitTheCommand(string command)
        {
            string[] inputSplitted = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (inputSplitted.Length == 4)
            {

                var citizen = new Citizen(inputSplitted[0], int.Parse(inputSplitted[1]), inputSplitted[2], inputSplitted[3]);

                citizens.Add(citizen);


            }
            else if (inputSplitted.Length == 3)
            {

                var rebel = new Rebel(inputSplitted[0], int.Parse(inputSplitted[1]), inputSplitted[2]);

                rebels.Add(rebel);


            }

            else
            {
                throw new ArgumentException("Invalid input!");
            }
        }


    }
}
